using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftGrow.Shares
{
    public partial class SharesSale : Form
    {
        DAL.SharesIssue objDAL = new DAL.SharesIssue();
        MyMessages Message = new MyMessages();        
                
        bool vOpenMode = false;
        bool vDirect=false;

        private int vUserID;

        public SharesSale(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
        }

        public void DirectLoad(Int64 VoucherID)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;                        
            OpenRecord(VoucherID);
            vDirect = true;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;            
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            
            if (!vDirect)
            {                
                ClearFields();
            }
            LoadSchemes();
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
        private void ForNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
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
                dtIssueDate.Value = DateTime.Now.Date;
                txtCheqNo.Text = string.Empty;
                txtMemberID.Text = string.Empty;
                txtMemberName.Text = string.Empty;
                txtNoOfShares.Text = "0";
                txtSharePrice.Text = "0";
                txtTotalAmount.Text = "0";
                optCash.Checked = true;
                lblCheqNo.Visible = false;
                txtCheqNo.Visible = false;
                txtRemarks.Text = string.Empty;
                cboScheme_SelectedIndexChanged(null, null);

                vOpenMode = false;
                btnPrint.Enabled = false;
                txtMemberID.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void LoadSchemes()
        {
            try
            {
                DAL.ShareScheme obj = new DAL.ShareScheme();
                obj.connectionstring = objDAL.connectionstring;
                DataTable dt = obj.getRecord("");

                cboScheme.DisplayMember = "SchemeTitle";
                cboScheme.ValueMember = "SchemeID";
                cboScheme.DataSource = dt;

            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }
        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberID.Text))
            {
                txtMemberName.Text = string.Empty;
            }
        }
        private void txtMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchMembers vForm = new Search.SchMembers();                                
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtMemberID.Text = vForm.MyID;
                    txtMemberName.Text = vForm.MyName;
                    txtNoOfShares.Focus();
                }
            }
            else
            {
                MoveNext_KeyDown(sender, e);
            }
        }
        private void cboScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboScheme.SelectedValue != null)
                {
                    DAL.ShareScheme obj = new DAL.ShareScheme();
                    obj.connectionstring = objDAL.connectionstring;
                    DataTable dt = obj.getRecord(" AND SchemeID=" + cboScheme.SelectedValue);

                    txtTotalShares.Text = dt.Rows[0]["TotalShares"].ToString();
                    txtSharePrice.Text = decimal.Parse(dt.Rows[0]["PerShareValue"].ToString()).ToString("G29");
                    txtAvailable.Text = obj.getAvailableShares(int.Parse(cboScheme.SelectedValue.ToString())).ToString();
                }
                else
                {
                    txtTotalShares.Text = string.Empty;
                    txtSharePrice.Text = string.Empty;
                    txtAvailable.Text = string.Empty;
                }

            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }
        private void optCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (optCheque.Checked)
            {
                lblCheqNo.Visible = true;
                txtCheqNo.Visible = true;
            }
        }
        private void optCash_CheckedChanged(object sender, EventArgs e)
        {
            if (optCash.Checked)
            {
                lblCheqNo.Visible = false;
                txtCheqNo.Visible = false;
            }
        }
        private void CalculateTotalAmount()
        {
            int vNoOfShare;
            decimal vPerShareVal;

            int.TryParse(txtNoOfShares.Text, out vNoOfShare);
            decimal.TryParse(txtSharePrice.Text, out vPerShareVal);

            txtTotalAmount.Text = (vPerShareVal * vNoOfShare).ToString("G29");

        }
        private void CalculatePerSharePrice()
        {
            int vNoOfShare;
            decimal vTotalAmount;

            int.TryParse(txtNoOfShares.Text, out vNoOfShare);
            decimal.TryParse(txtTotalAmount.Text, out vTotalAmount);

            txtSharePrice.Text = (vTotalAmount / vNoOfShare).ToString("G29");

        }
        private void txtNoOfShares_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfShares.Focused)
                CalculateTotalAmount();
        }
        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalAmount.Focused)
                CalculatePerSharePrice();
        }
        private void txtSharePrice_TextChanged(object sender, EventArgs e)
        {
            if (txtSharePrice.Focused)
                CalculateTotalAmount();
        }
        #endregion
       

        #region // Buttons Click

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage = string.Empty;

                if (txtMemberName.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Select From Account.";
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, vMessage);
                    txtMemberID.Focus();
                    return;
                }
                
                if (optCheque.Checked == true && txtCheqNo.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Enter Cheque No.";
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, vMessage);
                    txtCheqNo.Focus();
                    return;
                }

                int vNoOfShares = 0;
                int.TryParse(txtNoOfShares.Text, out vNoOfShares);

                if (vNoOfShares == 0)
                {
                    vMessage = "Please Enter Number of Shares.";
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, vMessage);
                    txtNoOfShares.Focus();
                    return;
                }

                decimal vPerShareVal = 0;
                decimal.TryParse(txtSharePrice.Text,out vPerShareVal);

                //Int64 vAmount;
                //Int64.TryParse(txtTotalAmount.Text, out vAmount);

                //if (vAmount == 0)
                //{
                //    vMessage = "Deposited Amount not entered.";
                //    new Speak().SayIt(vMessage);
                //    MessageBox.Show(vMessage, "Information Missing");
                //    txtTotalAmount.Focus();
                //    return;
                //}



                Objects.SharesIssue obj = new Objects.SharesIssue();
                obj.IssueID = Int64.Parse(txtID.Text);
                obj.IssueDate = dtIssueDate.Value;
                obj.SchemeID = int.Parse(cboScheme.SelectedValue.ToString());
                obj.MemberID = Int64.Parse(txtMemberID.Text);
                obj.NoOfShares = vNoOfShares;
                obj.PerShareValue = vPerShareVal;
                if (optCash.Checked)
                {
                    obj.ModeofPayment = "Cash";
                    obj.ChequeNo = "";
                }
                else
                {
                    obj.ModeofPayment = "Cheque";
                    obj.ChequeNo = txtCheqNo.Text.Trim();
                }

                
                obj.Remarks = txtRemarks.Text;
                obj.UserID = vUserID;

                if (!vOpenMode)
                {                    
                    //Insert                     
                    objDAL.InsertRecord(obj);
                }
                else objDAL.UpdateRecord(obj);

                Message.ShowMessage(MyMessages.MessageType.SaveRecord);                

                if(Message.ConfrmPrintMsg())
                    PrintRecord(obj.IssueID);

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

                string vMessage = string.Empty;

                if (!Message.ConfrmDelMsg()) return;

                //Delete Activity
                objDAL.DeleteRecord(Int64.Parse(txtID.Text));

                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);
                btnClear_Click(sender, e);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Search.SchSharesIssue vForm = new Search.SchSharesIssue();            
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenRecord(Int64.Parse(vForm.MyID));
            }
        }
        private void OpenRecord(Int64 vID)
        {
            try
            {
                DataTable dt = objDAL.getRecord(" AND SharesIssue.IssueID=" + vID);
                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["IssueID"].ToString();
                    dtIssueDate.Value = Convert.ToDateTime(dt.Rows[0]["IssueDate"].ToString());
                    cboScheme.SelectedValue = dt.Rows[0]["SchemeID"].ToString();
                    cboScheme.SelectedText = dt.Rows[0]["SchemeTitle"].ToString();
                    txtMemberID.Text = dt.Rows[0]["MemberID"].ToString();
                    txtMemberName.Text = dt.Rows[0]["MemberName"].ToString();
                    txtNoOfShares.Text = dt.Rows[0]["NoOfShares"].ToString();
                    txtSharePrice.Text = decimal.Parse(dt.Rows[0]["PerShareValue"].ToString()).ToString("G29");
                    CalculateTotalAmount();

                    if (dt.Rows[0]["ModeofPayment"].ToString() == "Cash")
                    {
                        optCash.Checked = true;
                        lblCheqNo.Visible = false;
                        txtCheqNo.Visible = false;
                        txtCheqNo.Text = string.Empty;
                    }
                    else
                    {
                        optCheque.Checked = true;
                        lblCheqNo.Visible = true;
                        txtCheqNo.Visible = true;
                        txtCheqNo.Text = dt.Rows[0]["ChequeNo"].ToString();
                    }                    
                    
                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();                    

                    vOpenMode = true;
                    btnPrint.Enabled = true;                    
                    dtIssueDate.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid ID.", "Invalid Information");
                    vOpenMode = false;
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (vOpenMode == false) return;
                PrintRecord(Int64.Parse(txtID.Text));

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
        private void PrintRecord(Int64 vID)
        {
            try
            {

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                DataTable dt = objDAL.getPrintData(vID);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }

                vForm.ShareSalesPrint(dt);
                vForm.ShowDialog();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
        #endregion

        

        

        

        

        

        

        
    }
}
