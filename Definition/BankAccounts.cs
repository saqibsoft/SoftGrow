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
    public partial class BankAccounts : Form
    {
        public BankAccounts()
        {
            InitializeComponent();
        }

        DAL.BankAccounts objDAL = new DAL.BankAccounts();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;

        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
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
                txtID.Text = objDAL.getNextNo().ToString();
                txtID.Tag = string.Empty;
                txtName.Text = string.Empty;
                txtBankName.Text = string.Empty;
                txtBranchName.Text = string.Empty;
                txtBranchCode.Text = string.Empty;
                txtOpDebit.Text = "0";
                txtOpCredit.Text = "0";
                
                vOpenMode = false;
                Grid.Enabled = false;
                txtName.Focus();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }

        #endregion

        #region // Grid Operations
        private void LoadGrid()
        {
            try
            {
                //Grid.Rows.Clear();
                string vWhere = string.Empty;
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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["ID"].Value.ToString();

                    DataTable dt = objDAL.getRecord(" AND BankAccountID=" + txtID.Text);

                    txtID.Tag = dt.Rows[0]["AccountID"].ToString();
                    txtName.Text = dt.Rows[0]["AccountTitle"].ToString();
                    txtBankName.Text = dt.Rows[0]["BankName"].ToString();
                    txtBranchCode.Text = dt.Rows[0]["BranchCode"].ToString();
                    txtBranchName.Text = dt.Rows[0]["BranchName"].ToString();
                    txtOpDebit.Text = decimal.Parse(dt.Rows[0]["OpeningDebit"].ToString()).ToString("G29");
                    txtOpCredit.Text = decimal.Parse(dt.Rows[0]["OpeningCredit"].ToString()).ToString("G29");

                    dt.Dispose();

                    vOpenMode = true;
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
               

                if (txtName.Text.Trim() == string.Empty)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Account Title.");
                    txtName.Focus();
                    return;
                }

                Objects.BankAccounts obj = new Objects.BankAccounts();
                obj.BankAccountID = int.Parse(txtID.Text);
                obj.AccountTitle = txtName.Text.Trim();
                obj.BankName = txtBankName.Text.Trim();
                obj.BranchName = txtBranchName.Text.Trim();
                obj.BranchCode = txtBranchCode.Text.Trim();
                obj.AccountID = txtID.Tag.ToString();

                decimal vOpDebit = 0;
                decimal vOpCredit = 0;

                decimal.TryParse(this.txtOpDebit.Text, out vOpDebit);
                decimal.TryParse(this.txtOpCredit.Text, out vOpCredit);

                var AccDAL = new DAL.AccountChart();
                AccDAL.connectionstring = objDAL.connectionstring;

                Objects.AccountChart objAcc = new Objects.AccountChart();
                objAcc.AccountNo = obj.AccountID;
                objAcc.AccountTitle = obj.AccountTitle;
                objAcc.AccountType = "ASSET";
                objAcc.AccountSubType = "Banks";
                objAcc.IsParty = false;                
                objAcc.IsBank = true;
                objAcc.OpeningDebit = vOpDebit;
                objAcc.OpeningCredit = vOpCredit;

                if (!vOpenMode)
                {

                    //Insert Account
                    objAcc.AccountNo = AccDAL.getNextNo("ASSET").ToString();
                    AccDAL.InsertRecord(objAcc);

                    //Insert Bank Account
                    obj.BankAccountID = int.Parse(objDAL.getNextNo().ToString());
                    obj.AccountID = objAcc.AccountNo;
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    AccDAL.UpdateRecord(objAcc);
                    objDAL.UpdateRecord(obj); 
                }

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

                //Delete Org Account
                objDAL.DeleteRecord(int.Parse(txtID.Text));

                //Delete Account
                var AccDAL = new DAL.AccountChart();
                AccDAL.connectionstring = objDAL.connectionstring;
                AccDAL.DeleteRecord(txtID.Tag.ToString());


                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);
                LoadGrid();
                btnClear_Click(sender, e);

            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void BankAccounts_KeyDown(object sender, KeyEventArgs e)
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
