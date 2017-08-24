using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftGrow.Finance
{
    public partial class ChequeDeposit : Form
    {
        DAL.BankDeposits objDAL = new DAL.BankDeposits();
        DAL.Vouchers objVouch = new DAL.Vouchers();
        bool vOpenMode = false;
        bool vDirect;

        private int vUserID;

        public ChequeDeposit(int UserID)
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
            objVouch.connectionstring = objDAL.connectionstring;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            if (!vDirect)
            {               
                ClearFields();
            }
        }
        

        #region // General Methods
        private void MoveNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private int CheckIsNumeric(int vKey)
        {
            int rKey = vKey;
            if ((vKey > 57 || vKey < 48) && vKey != 8)
            {
                rKey = 0;
            }
            return rKey;
        }
        private int CheckIsNumeric(int vKey, string vText)
        {
            int rKey = vKey;
            if ((vKey > 57 || vKey < 48) && vKey != 8)
            {
                rKey = 0;
            }
            else if (vText.IndexOf(".") != -1)
            {
                rKey = 0;
            }
            return rKey;
        }
        #endregion

        #region // Control Operations

        private void ClearFields()
        {
            try
            {
                txtID.Text = objDAL.getNextNo().ToString();
                dtDepositDate.Value = DateTime.Now.Date;                
                txtSlipNo.Text = string.Empty;
                txtCheqNo.Text = string.Empty;
                dtCheqDate.Value = DateTime.Now.Date;
                txtAccountNo.Text = string.Empty;
                txtAccountName.Text = string.Empty;
                txtBankAccNo.Text = string.Empty;
                txtBankAccName.Text = string.Empty;
                txtAmount.Text = "0";
                txtDepositby.Text = string.Empty;
                txtNarration.Text = string.Empty;                               

                vOpenMode = false;
                btnPrint.Enabled = false;
                txtDepositby.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNo.Text))
            {
                txtAccountName.Text = string.Empty;
            }
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND AccountChart.AccountNo = " + txtAccountNo.Text;
                DAL.AccountChart obj = new DAL.AccountChart();

                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getRecord(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txtAccountNo.Text = dt.Rows[0]["AccountNo"].ToString(); // vForm.MyID;
                    txtAccountName.Text = dt.Rows[0]["AccountTitle"].ToString();// vForm.MyName;

                }
            }
        }
        private void txtAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchAccounts vForm = new Search.SchAccounts();                
                vForm.IsBank = false;
                //vForm.IsDonor = true;
                //if (getVoucherType() == "JV") vForm.IsJV = true;

                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtAccountNo.Text = vForm.MyID;
                    txtAccountName.Text = vForm.MyName;
                    txtBankAccNo.Focus();
                }
            }
            else
            {
                MoveNext_KeyDown(sender, e);
            }
        }
        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void txtBankAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBankAccNo.Text))
            {
                txtBankAccName.Text = string.Empty;
            }
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND IsBank = 1 AND AccountChart.AccountNo = " + txtBankAccNo.Text;
                DAL.AccountChart obj = new DAL.AccountChart();

                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getRecord(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txtBankAccNo.Text = dt.Rows[0]["AccountNo"].ToString(); // vForm.MyID;
                    txtBankAccName.Text = dt.Rows[0]["AccountTitle"].ToString();// vForm.MyName;

                }
            }
        }
        private void txtBankAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchAccounts vForm = new Search.SchAccounts();                
                vForm.IsBank = true;
                //if (getVoucherType() == "JV") vForm.IsJV = true;

                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtBankAccNo.Text = vForm.MyID;
                    txtBankAccName.Text = vForm.MyName;
                    txtAmount.Focus();
                }
            }
            else
            {
                MoveNext_KeyDown(sender, e);
            }
        }
        private void txtBankAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !txtAmount.Text.Contains('.'))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }                
        private void dtDepositDate_ValueChanged(object sender, EventArgs e)
        {           
        }
        #endregion
       

        #region // Buttons Click

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage = string.Empty;


                if (txtSlipNo.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Enter Bank Deposit Slip Number.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtSlipNo.Focus();
                    return;
                }

                if (txtCheqNo.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Enter Cheque Number.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtCheqNo.Focus();
                    return;
                }

                if (txtAccountName.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Select From Account.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtAccountNo.Focus();
                    return;
                }

                if (txtBankAccName.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Select Bank Account.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtBankAccNo.Focus();
                    return;
                }

                Int64 vAmount;
                Int64.TryParse(txtAmount.Text, out vAmount);

                if (vAmount == 0)
                {
                    vMessage = "Deposited Amount not entered.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtAmount.Focus();
                    return;
                }



                Objects.BankDeposits obj = new Objects.BankDeposits();
                obj.DepositID = Int64.Parse(txtID.Text);
                obj.DepositDate = dtDepositDate.Value;                
                obj.SlipNo = txtSlipNo.Text.Trim();
                obj.AccountNo = txtAccountNo.Text;
                obj.BankAccountNo = txtBankAccNo.Text;
                obj.Amount = vAmount;
                obj.DepositedBy = txtDepositby.Text;
                obj.Narration = txtNarration.Text;                

                DAL.Settings obSet = new DAL.Settings();
                obSet.connectionstring = objDAL.connectionstring;
                obj.IsPosted = Convert.ToBoolean(obSet.GetSettingValue(DAL.Settings.ProSettings.IsAutoPost));
                
                obj.UserID = vUserID;
                obj.EntryDate = DateTime.Now.Date;

                obj.ChequeDate = dtCheqDate.Value;
                obj.ChequeNo = txtCheqNo.Text;
                obj.IsCheque = true;

                if (!vOpenMode)
                {                    

                    //Insert Activity
                    obj.DepositID = Int64.Parse(objDAL.getNextNo().ToString());                    
                    objDAL.InsertRecord(obj);
                }
                else objDAL.UpdateRecord(obj);

                vMessage = "Record Saved Successfully.";
                new Speak().SayIt(vMessage);
                MessageBox.Show(vMessage, "Confirmation");

                PrintVoucher(obj.DepositID);

                btnClear_Click(sender, e);


            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
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

                vMessage = "Are you Sure To Delete";
                new Speak().SayIt(vMessage);
                DialogResult dMsg = MessageBox.Show("Are you Sure To Delete!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dMsg == DialogResult.No) return;

                //Delete Activity                
                objDAL.DeleteRecord(int.Parse(txtID.Text));
                


                vMessage = "Record Deleted Successfully";
                new Speak().SayIt(vMessage);
                MessageBox.Show(vMessage, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Search.SchBanDeposit vForm = new Search.SchBanDeposit();
            vForm.IsChequeDeposit = true;
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenRecord(Int64.Parse(vForm.MyID));
            }
        }

        private void OpenRecord(Int64 vDepositID)
        {
            try
            {
                DataTable dt = objDAL.getRecord(" AND BankDeposits.DepositID=" + vDepositID );
                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["DepositID"].ToString();
                    dtDepositDate.Value = Convert.ToDateTime(dt.Rows[0]["DepositDate"].ToString());                    
                    txtSlipNo.Text = dt.Rows[0]["SlipNo"].ToString();
                    dtCheqDate.Value = dtDepositDate.Value = Convert.ToDateTime(dt.Rows[0]["ChequeDate"].ToString());
                    txtCheqNo.Text = dt.Rows[0]["ChequeNo"].ToString();
                    txtAccountNo.Text = dt.Rows[0]["AccountNo"].ToString();
                    txtAccountName.Text = dt.Rows[0]["AccountName"].ToString();
                    txtBankAccNo.Text = dt.Rows[0]["BankAccountNo"].ToString();
                    txtBankAccName.Text = dt.Rows[0]["BankAccountName"].ToString();
                    txtAmount.Text = decimal.Parse(dt.Rows[0]["Amount"].ToString()).ToString("g0") ;
                    txtDepositby.Text = dt.Rows[0]["DepositedBy"].ToString();
                    txtNarration.Text = dt.Rows[0]["Narration"].ToString();                    

                    vOpenMode = true;
                    btnPrint.Enabled = true;                    
                    dtDepositDate.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Purchase ID.", "Invalid Information");
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

        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (vOpenMode == false) return;

                PrintVoucher(Int64.Parse(txtID.Text));


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void PrintVoucher(Int64 vVoucherID)
        {
            try
            {                

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                DataTable dt = objDAL.getPrintData(vVoucherID);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }

                vForm.ShowReport("BANK DEPOSIT VOUCHER", dt);
                vForm.ShowDialog();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void ChequeDeposit_KeyDown(object sender, KeyEventArgs e)
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
                btnPrint_Click(null, null);
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
