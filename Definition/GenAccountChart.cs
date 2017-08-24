using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftGrow.Definition
{
    public partial class GenAccountChart : Form
    {
        
        public GenAccountChart()
        {
            InitializeComponent();
        }

        DAL.AccountChart objDAL = new DAL.AccountChart();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;

        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            cboAccountType.SelectedIndex = 0;
            LoadGrid();
            ClearFields();
        }

        #region // General Methods
        private void MoveNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void ForAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !mytxt.Text.Contains('.'))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        #endregion

        #region // Control Operations

        private void ClearFields()
        {
            try
            {
                txtAccountID.Text = objDAL.getNextNo(cboAccountType.Text).ToString();
                txtAccountTitle.Text = string.Empty;
                //cboAccountType.SelectedIndex = 0;
                txtFilter.Text = string.Empty;
                txtFilter.Enabled = false;
                cboAccountTypeFilter.Enabled = false;
                cboAccountTypeFilter.SelectedItem = cboAccountType.SelectedItem;
                cboAccountType.Enabled = true;
                this.txtOpDebit.Text = "0";
                this.txtOpCredit.Text = "0";
                txtAccountTitle.Focus();

                LoadGrid();

                vOpenMode = false;
                Grid.Enabled = false;

            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void cboAccountTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadGrid();
        }
        private void cboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAccountID.Text = objDAL.getNextNo(cboAccountType.Text).ToString();
            LoadGrid();
        }
        #endregion

        #region // Grid Operations

        private void LoadGrid()
        {
            try
            {
                string vWhere = string.Empty;
                if (!string.IsNullOrEmpty(txtFilter.Text))
                {
                    vWhere = " AND (accountchart.AccountTitle Like '%" + txtFilter.Text + "%' or accountchart.AccountNo Like '%" + txtFilter.Text + "%')";
                }

                vWhere += " AND isnull(accountchart.AccountSubType,'')<>'Employee'  AND isnull(accountchart.IsBank,0)=0 AND Isnull(accountchart.IsParty,0)=0  AND accountchart.accounttype='" + cboAccountType.Text + "'";

                DataTable dt = objDAL.getRecord(vWhere);
                Grid.AutoGenerateColumns = false;
                Grid.DataSource = dt;
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
           
        }
        private void Grid_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                    {
                        //cboAccountType.SelectedItem = cboAccountTypeFilter.SelectedItem;
                        txtAccountID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountNo"].Value.ToString();

                        DataTable dt = objDAL.getRecord(" AND AccountNo='" + txtAccountID.Text + "'");

                        txtAccountTitle.Text = dt.Rows[0]["AccountTitle"].ToString();
                        txtOpDebit.Text = decimal.Parse(dt.Rows[0]["OpeningDebit"].ToString()).ToString("G29");
                        txtOpCredit.Text = decimal.Parse(dt.Rows[0]["OpeningCredit"].ToString()).ToString("G29");

                        vOpenMode = true;
                        cboAccountType.Enabled = false;
                    }
                }
            }
            catch (Exception exc)
            {

                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }
        #endregion

        #region // Buttons Click

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage = string.Empty;


                if (txtAccountTitle.Text.Trim() == string.Empty)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Account Title.");
                    txtAccountTitle.Focus();
                    return;
                }

                Objects.AccountChart obj = new Objects.AccountChart();
                obj.AccountNo = txtAccountID.Text;
                obj.AccountTitle = txtAccountTitle.Text.Trim();
                obj.AccountType = cboAccountType.Text;

                decimal vOpDebit = 0;
                decimal vOpCredit = 0;

                decimal.TryParse(this.txtOpDebit.Text, out vOpDebit);
                decimal.TryParse(this.txtOpCredit.Text, out vOpCredit);

                obj.OpeningDebit = vOpDebit;
                obj.OpeningCredit = vOpCredit;

                obj.AccountSubType = string.Empty;

                if (!vOpenMode)
                {
                    obj.AccountNo = objDAL.getNextNo(cboAccountType.Text).ToString();
                    objDAL.InsertRecord(obj);
                }
                else objDAL.UpdateRecord(obj);

                Message.ShowMessage(MyMessages.MessageType.SaveRecord);
                LoadGrid();
                btnClear_Click(sender, e);


            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);      
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                if (!Message.ConfrmDelMsg()) return;

                //Delete Account
                objDAL.DeleteRecord(txtAccountID.Text);

                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);
                LoadGrid();
                btnClear_Click(sender, e);

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
            txtFilter.Enabled = true;
            cboAccountTypeFilter.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void GenAccountChart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                btnDelete_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                btnClose_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                //btnPrint_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                btnClear_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                btnSwitch_Click(null, null);
            }
        }

        

        
    }
}
