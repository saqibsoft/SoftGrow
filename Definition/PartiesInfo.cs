using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Definition
{
    public partial class PartiesInfo : Form
    {
        DAL.Parties objDAL = new DAL.Parties();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;

        public PartiesInfo()
        {
            InitializeComponent();
        }
        private void PartiesInfo_Load(object sender, EventArgs e)
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
                txtAddress.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtCNIC.Text = string.Empty;
                txtContactNo.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtWeb.Text = string.Empty;
                txtNTN.Text = string.Empty;
                this.txtOpDebit.Text = "0";
                this.txtOpCredit.Text = "0";
                vOpenMode = false;
                Grid.Enabled = false;
                txtFilter.Text = string.Empty;
                txtFilter.Enabled = false;
                chkCustomer.Checked = false;
                chkSupplier.Checked = false;
                txtName.Focus();
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
        #endregion

        #region // Grid Operations
        private void LoadGrid()
        {
            try
            {
                //Grid.Rows.Clear();
                string vWhere = string.Empty;
                if (!string.IsNullOrEmpty(txtFilter.Text))
                {
                    vWhere = " AND Parties.PartyName Like '%" + txtFilter.Text + "%'";
                }

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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["PartyID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND PartyID=" + txtID.Text);
                    txtID.Tag = dt.Rows[0]["AccountID"].ToString();
                    txtName.Text = dt.Rows[0]["PartyName"].ToString();
                    txtCNIC.Text = dt.Rows[0]["CNICNo"].ToString();
                    txtContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                    txtCity.Text = dt.Rows[0]["City"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtWeb.Text = dt.Rows[0]["Web"].ToString();
                    txtNTN.Text = dt.Rows[0]["NTN"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtID.Tag = dt.Rows[0]["AccountID"].ToString();
                    chkSupplier.Checked =Convert.ToBoolean(dt.Rows[0]["IsSupplier"].ToString());
                    chkCustomer.Checked = Convert.ToBoolean(dt.Rows[0]["IsCustomer"].ToString());

                    txtOpDebit.Text = decimal.Parse(dt.Rows[0]["OpeningDebit"].ToString()).ToString("G29");
                    txtOpCredit.Text = decimal.Parse(dt.Rows[0]["OpeningCredit"].ToString()).ToString("G29");

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
            txtFilter.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                if (!Message.ConfrmDelMsg()) return;
                                                
                objDAL.DeleteRecord(Int64.Parse(txtID.Text));

                //Delete Account
                var AccDAL = new DAL.AccountChart();
                AccDAL.connectionstring = objDAL.connectionstring;
                AccDAL.DeleteRecord(txtID.Tag.ToString());

                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);
                LoadGrid();
                btnClear_Click(sender,e);

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Party Name.");
                    txtName.Focus();
                    return;
                }


                Objects.Parties obj = new Objects.Parties();
                obj.PartyID = Int64.Parse(txtID.Text);
                obj.PartyName = txtName.Text.Trim();
                obj.ContactNo = txtContactNo.Text.Trim();
                obj.CNICNo = txtCNIC.Text.Trim();
                obj.City = txtCity.Text.Trim();
                obj.Address = txtAddress.Text.Trim();
                obj.Email = txtEmail.Text.Trim();
                obj.Web = txtWeb.Text.Trim();
                obj.NTN = txtNTN.Text.Trim();
                obj.AccountID = txtID.Tag.ToString();
                obj.IsSupplier = chkSupplier.Checked;
                obj.IsCustomer = chkCustomer.Checked;

                decimal vOpDebit = 0;
                decimal vOpCredit = 0;

                decimal.TryParse(this.txtOpDebit.Text, out vOpDebit);
                decimal.TryParse(this.txtOpCredit.Text, out vOpCredit);

                //Insert Account
                var AccDAL = new DAL.AccountChart();
                AccDAL.connectionstring = objDAL.connectionstring;
                Objects.AccountChart objAcc = new Objects.AccountChart();
                if (!string.IsNullOrEmpty(txtID.Tag.ToString()))
                    objAcc.AccountNo = txtID.Tag.ToString();
                objAcc.AccountTitle = obj.PartyName;
                objAcc.AccountType = "ASSET";
                objAcc.AccountSubType = "Parties";
                objAcc.IsParty = true;
                objAcc.IsBank = false;
                objAcc.OpeningDebit = vOpDebit;
                objAcc.OpeningCredit = vOpCredit;

                if (!vOpenMode)
                {

                    

                    

                    objAcc.AccountNo = AccDAL.getNextNo("ASSET").ToString();
                    AccDAL.InsertRecord(objAcc);

                    //Insert Party
                    obj.PartyID = objDAL.getNextNo();
                    obj.AccountID = objAcc.AccountNo;

                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate Opeinig in Account
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
        #endregion

        private void PartiesInfo_KeyDown(object sender, KeyEventArgs e)
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
