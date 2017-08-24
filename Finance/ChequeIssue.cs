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
    public partial class ChequeIssue : Form
    {
        DAL.BankIssues objDAL = new DAL.BankIssues();
        DAL.Vouchers objVouch = new DAL.Vouchers();
        bool vOpenMode = false;
        bool vDirect;

        private int vUserID;

        public ChequeIssue(int UserID)
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
                txtCheqNo.Text = string.Empty;
                dtCheqDate.Value = DateTime.Now.Date;
                txtAccountNo.Text = string.Empty;
                txtAccountName.Text = string.Empty;
                txtBankAccNo.Text = string.Empty;
                txtBankAccName.Text = string.Empty;
                txtAmount.Text = "0";
                txtReceivedby.Text = string.Empty;
                txtTotalAmount.Text = string.Empty;
                txtNarration.Text = string.Empty;
                txtWHTAmount.Text = txtChqAmount.Text = "0";                

                this.Grid.Rows.Clear();

                vOpenMode = false;                
                txtCheqNo.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void CalculateTotalAmount()
        {
            decimal vChqAmnt, vWHTAmnt;

            decimal.TryParse(this.txtChqAmount.Text, out vChqAmnt);
            decimal.TryParse(this.txtWHTAmount.Text, out vWHTAmnt);

            txtTotalCheqAmount.Text = (vChqAmnt + vWHTAmnt).ToString("g0");
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
                vWhere = " AND AccountChart.AccountNo = " + txtAccountNo.Text;
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
                    txtAmount.Focus();
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
                    txtReceivedby.Focus();
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

        #region // Grid Operations
        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {                    
                    this.txtAccountNo.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountNo"].Value.ToString();
                    this.txtAccountName.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountName"].Value.ToString();
                    txtAmount.Text =decimal.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["Amount"].Value.ToString()).ToString("g0");                    
                    txtTotalAmount.Text = (decimal.Parse(txtTotalAmount.Text) - decimal.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["Amount"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint)).ToString("g0");
                    Grid.Rows.Remove(Grid.CurrentRow);
                    txtAccountNo.Focus();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }        
        #endregion

        #region // Buttons Click
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage = string.Empty;

                if (txtAccountName.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Select an Account First.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtAccountNo.Focus();
                    return;
                }

                decimal vInAmount = 0;
                decimal.TryParse(txtAmount.Text, out vInAmount);

                if (vInAmount == 0)
                {
                    vMessage = "Please enter Amount.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtAmount.Focus();
                    return;
                }

                decimal vTotalAmount = 0;

                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        if (txtAccountNo.Text == dr.Cells["AccountNo"].Value.ToString())
                        {
                            vMessage = "Account Already Entered.";
                            new Speak().SayIt(vMessage);
                            MessageBox.Show(vMessage, "Duplicate Information");
                            txtAccountNo.Focus();
                            return;
                        }

                        vTotalAmount += decimal.Parse(dr.Cells["Amount"].Value.ToString());
                    }
                }                

                Grid.Rows.Add(txtAccountNo.Text, txtAccountName.Text, decimal.Parse(this.txtAmount.Text).ToString("g0"));
                vTotalAmount += decimal.Parse(this.txtAmount.Text);
                txtTotalAmount.Text = vTotalAmount.ToString("g0");
                btnClearAccounts_Click(null, null);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void btnClearAccounts_Click(object sender, EventArgs e)
        {
            this.txtAccountNo.Text = string.Empty;
            this.txtAccountName.Text = string.Empty;
            this.txtAmount.Text = "0";
            this.txtAccountNo.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage = string.Empty;

                if (txtCheqNo.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Enter Cheque Number.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtCheqNo.Focus();
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

                Int64 vAmount,vChqAmount,vWHTAmnt;
                
                Int64.TryParse(txtTotalAmount.Text, out vAmount);
                Int64.TryParse(txtTotalCheqAmount.Text, out vChqAmount);
                Int64.TryParse(txtWHTAmount.Text, out vWHTAmnt);

                if (vAmount != vChqAmount)
                {
                    vMessage = "Amount Detail not equal to Total Cheques Amount.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtAccountNo.Focus();
                    return;
                }

                if (Grid.Rows.Count == 0)
                {
                    vMessage = "Amount Detail not entered.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtAccountNo.Focus();
                    return;
                }


                Int64.TryParse(txtChqAmount.Text, out vChqAmount);

                Objects.BankIssues obj = new Objects.BankIssues();
                obj.IssueID = Int64.Parse(txtID.Text);
                obj.IssueDate = dtDepositDate.Value;         
                obj.BankAccountNo = txtBankAccNo.Text;
                obj.Amount = vChqAmount;
                obj.WHTAccountNo = "200000";
                obj.WHTAmount = vWHTAmnt;
                obj.ReceivedBy = txtReceivedby.Text;
                obj.Narration = txtNarration.Text;                

                DAL.Settings obSet = new DAL.Settings();
                obSet.connectionstring = objDAL.connectionstring;
                obj.IsPosted = Convert.ToBoolean(obSet.GetSettingValue(DAL.Settings.ProSettings.IsAutoPost));
                
                obj.UserID = vUserID;
                obj.EntryDate = DateTime.Now.Date;

                obj.ChequeDate = dtCheqDate.Value;
                obj.ChequeNo = txtCheqNo.Text;
                obj.IsLost = false;



                if (!vOpenMode)
                {

                    //Insert Activity
                    obj.IssueID = Int64.Parse(objDAL.getNextNo().ToString());
                    objDAL.DeleteRecordBody(obj.IssueID);

                    objDAL.InsertRecord(obj);
                }
                else
                {
                    objDAL.DeleteRecordBody(obj.IssueID);
                    objDAL.UpdateRecord(obj); 
                }

                //Save Detail
                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        Objects.BankIssueBody objDon = new Objects.BankIssueBody();
                        objDon.IssueID = obj.IssueID;
                        objDon.AccountNo = dr.Cells["AccountNo"].Value.ToString();
                        objDon.Amount = decimal.Parse(dr.Cells["Amount"].Value.ToString());
                        objDAL.InsertRecordBody(objDon);

                    }
                }

                vMessage = "Record Saved Successfully.";
                new Speak().SayIt(vMessage);
                MessageBox.Show(vMessage, "Confirmation");
                PrintVoucher(obj.IssueID);
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
                objDAL.DeleteRecordBody(Int64.Parse(txtID.Text));
                objDAL.DeleteRecord(Int64.Parse(txtID.Text));
                


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
            Search.SchCheqIssue vForm = new Search.SchCheqIssue();            
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenRecord(Int64.Parse(vForm.MyID));
            }
        }

        private void OpenRecord(Int64 vIssueID)
        {
            try
            {
                DataTable dt = objDAL.getRecord(" AND BankIssues.IssueID=" + vIssueID);
                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["IssueID"].ToString();
                    dtDepositDate.Value = Convert.ToDateTime(dt.Rows[0]["IssueDate"].ToString());                    
                    dtCheqDate.Value = dtDepositDate.Value = Convert.ToDateTime(dt.Rows[0]["ChequeDate"].ToString());
                    txtCheqNo.Text = dt.Rows[0]["ChequeNo"].ToString();                    
                    txtBankAccNo.Text = dt.Rows[0]["BankAccountNo"].ToString();
                    txtBankAccName.Text = dt.Rows[0]["BankAccountName"].ToString();
                    txtChqAmount.Text = decimal.Parse(dt.Rows[0]["TotalAmount"].ToString()).ToString("g0") ;
                    txtWHTAmount.Text = decimal.Parse(dt.Rows[0]["WHTAmount"].ToString()).ToString("g0");
                    txtTotalAmount.Text = (decimal.Parse(dt.Rows[0]["TotalAmount"].ToString()) + decimal.Parse(dt.Rows[0]["WHTAmount"].ToString())).ToString("g0");
                    txtReceivedby.Text = dt.Rows[0]["ReceivedBy"].ToString();
                    txtNarration.Text = dt.Rows[0]["Narration"].ToString();                    

                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid.Rows.Add(dr["AccountNo"].ToString(), dr["AccountName"].ToString(), decimal.Parse(dr["Amount"].ToString()));
                    }

                    vOpenMode = true;                    
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

                vForm.ShowReport("BANK PAYMENT VOUCHER", dt);
                vForm.ShowDialog();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
        private void txtChqAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtWHTAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void ChequeIssue_KeyDown(object sender, KeyEventArgs e)
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
