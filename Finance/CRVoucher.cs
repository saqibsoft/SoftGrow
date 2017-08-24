using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Finance
{
    public partial class CRVoucher : Form
    {
        bool vOpenMode;
        DAL.Vouchers objDAL = new DAL.Vouchers();
        DAL.Misc Msc = new DAL.Misc();
        MyMessages Message = new MyMessages();

        private int vUserID;


        public CRVoucher(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            Msc.connectionstring = objDAL.connectionstring;
            cboVoucherType.SelectedIndex = 0;            
            SetMode(false);
        }


        #region // General Methods
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
        private void GoToNextCont(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void txtVendorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }
        

        private string getVoucherType()
        {
            string vType = string.Empty;
            if (this.cboVoucherType.Text == "Cash Receiving")
            {
                vType = "CRV";
            }
            else if (this.cboVoucherType.Text == "Cash Payment")
            {
                vType = "CPV";
            }
            else
            {
                vType = "JV";
            }

            return vType;
        }

        private void SetMode(bool blnOpen)
        {
            try
            {
                if (blnOpen)
                {
                    vOpenMode = true;

                    //Buttons Setting
                    btnDelete.Enabled = true;
                    btnPrint.Enabled = true;

                    cboVoucherType.Enabled = false;                    

                }
                else
                {
                    vOpenMode = false;

                    cboVoucherType.Enabled = false;                    

                    txtVoucherNo.Text = objDAL.getNextID(getVoucherType()).ToString(); // Get New Order No
                    txtNarration.Text = string.Empty;                    
                    

                    ClearBodyControls();

                    Grid.Rows.Clear();

                    txtTotalDebit.Text =txtTotalCredit.Text = string.Empty;
                    
                    //Buttons Setting
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;

                    dtVoucherDate.Focus();
                }
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }

        private void ClearBodyControls()
        {
            txtAccountNo.Text = txtAccountName.Text = txtRemarks.Text= string.Empty;
            txtDebit.Text = txtCredit.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal vDebit = 0;
                decimal vCredit = 0;

                if (txtAccountNo.Text == string.Empty)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Select or Insert Valid Account #");                                    
                    txtAccountNo.Focus();
                    return;
                }


                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        if (txtAccountNo.Text == dr.Cells["AccountNo"].Value.ToString())
                        {
                            Message.ShowMessage(MyMessages.MessageType.General, "Account Already Inserted!!!"); 
                            txtAccountNo.Focus();
                            return;
                        }
                    }
                }

                decimal.TryParse(txtDebit.Text, out vDebit);
                decimal.TryParse(txtCredit.Text, out vCredit);

                if (vDebit == 0 && vCredit == 0)
                {
                    Message.ShowMessage(MyMessages.MessageType.General, "Zero Value Can not be Inserted.");                     
                    txtAccountNo.Focus();
                    return;
                }



                Grid.Rows.Add(txtAccountNo.Text, txtAccountName.Text,  txtRemarks.Text,  vDebit, vCredit);

                txtTotalDebit.Text = (decimal.Parse((string.IsNullOrEmpty(txtTotalDebit.Text) ? "0" : txtTotalDebit.Text)) + vDebit).ToString("G29");
                txtTotalCredit.Text = (decimal.Parse((string.IsNullOrEmpty(txtTotalCredit.Text) ? "0" : txtTotalCredit.Text)) + vCredit).ToString("G29");

                ClearBodyControls();
                txtAccountNo.Focus();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }


        }

        private void btnClearDetail_Click(object sender, EventArgs e)
        {
            ClearBodyControls();
            txtAccountNo.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetMode(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                if (!Message.ConfrmDelMsg()) return;
                

                objDAL.DeleteRecordBody(Convert.ToInt32(txtVoucherNo.Text),getVoucherType());
                objDAL.DeleteRecord(Convert.ToInt32(txtVoucherNo.Text),getVoucherType());

                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);
                SetMode(false);
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message); 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cboVoucherType.Text == string.Empty)
                {                    
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Select a Voucher Type");
                    cboVoucherType.Focus();
                    return;
                }
               
                if (Grid.Rows.Count == 0)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Insert Accounts Information");                    
                    txtAccountNo.Focus();
                    return;
                }

                if (getVoucherType() == "JV")
                {
                    if (txtTotalCredit.Text != txtTotalDebit.Text)
                    {
                        Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Total Debit and Credit not Equal!!! ");                        
                        txtAccountNo.Focus();
                        return;
                    }
                }


                Objects.VoucherHeader BAL = new Objects.VoucherHeader();

                BAL.VoucherID = Int32.Parse(txtVoucherNo.Text);
                BAL.VoucherDate = dtVoucherDate.Value;
                BAL.VoucherType = getVoucherType();                
                BAL.Narration = txtNarration.Text;

                DAL.Settings obSet = new DAL.Settings();
                obSet.connectionstring = objDAL.connectionstring;
                BAL.IsPosted = Convert.ToBoolean(obSet.GetSettingValue(DAL.Settings.ProSettings.IsAutoPost));
                
                BAL.UserID = vUserID;
                BAL.EntryDate = DateTime.Now.Date;

                if (vOpenMode)
                {
                    objDAL.UpdateRecord(BAL);
                    objDAL.DeleteRecordBody(Int32.Parse(txtVoucherNo.Text),getVoucherType());
                }
                else
                {
                    objDAL.InsertRecord(BAL);
                }

                //Save Detail
                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        Objects.VoucherBody objBody = new Objects.VoucherBody();
                        objBody.VoucherID = Int32.Parse(txtVoucherNo.Text);
                        objBody.VoucherType = getVoucherType();                        
                        objBody.AccountNo = dr.Cells["AccountNo"].Value.ToString();
                        objBody.Debit = decimal.Parse(dr.Cells["Debit"].Value.ToString());
                        objBody.Credit = decimal.Parse(dr.Cells["Credit"].Value.ToString());
                        objBody.Remarks = dr.Cells["Remarks"].Value.ToString();

                        objDAL.InsertRecordBody(objBody);

                    }
                }
                Message.ShowMessage(MyMessages.MessageType.SaveRecord);
                PrintVoucher();
                SetMode(false);
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message); 
            }
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchAccounts vForm = new Search.SchAccounts();                                

                //if (getVoucherType() == "JV") vForm.IsJV = true;

                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtAccountNo.Text = vForm.MyID;
                    txtAccountName.Text = vForm.MyName;
                    txtRemarks.Focus();
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNo.Text))
            {
                ClearBodyControls();
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

        private void OpenInvoice(Int64 vVoucherID, string vVoucherType)
        {
            try
            {
                DataTable dt = objDAL.getVouchersData(" AND VoucherHeader.VoucherID=" + vVoucherID + " AND VoucherHeader.VoucherType='" + vVoucherType +"'");
                if (dt.Rows.Count > 0)
                {                    
                    if (dt.Rows[0]["VoucherType"].ToString() == "CRV")                    
                    {
                        cboVoucherType.Text = "Cash Receiving";
                    }
                    else if (dt.Rows[0]["VoucherType"].ToString() == "CPV")
                    {
                        cboVoucherType.Text = "Cash Payment";
                    }
                    else
                    {
                        cboVoucherType.Text = "Journal Voucher";
                    }

                    txtVoucherNo.Text = dt.Rows[0]["VoucherNo"].ToString();
                    dtVoucherDate.Text = dt.Rows[0]["VoucherDate"].ToString();                    
                    txtNarration.Text = dt.Rows[0]["Narration"].ToString();                    

                    //Grid.DataSource = dt;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid.Rows.Add(dr["AccountNo"].ToString(), dr["AccountName"].ToString(), dr["Remarks"].ToString(), decimal.Parse(dr["Debit"].ToString()).ToString("g0"), decimal.Parse(dr["Credit"].ToString()).ToString("g0"));
                        txtTotalDebit.Text = (decimal.Parse((string.IsNullOrEmpty(txtTotalDebit.Text) ? "0" : txtTotalDebit.Text)) + decimal.Parse(dr["Debit"].ToString())).ToString("g0");
                        txtTotalCredit.Text = (decimal.Parse((string.IsNullOrEmpty(txtTotalCredit.Text) ? "0" : txtTotalCredit.Text)) + decimal.Parse(dr["Credit"].ToString())).ToString("g0");
                    }

                    SetMode(true);
                }
                else
                {
                    MessageBox.Show("Invalid Purchase ID.", "Invalid Information");
                    SetMode(false);
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Search.SchVoucher vForm = new Search.SchVoucher();
            vForm.RecordType = "CRV";
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenInvoice(Int64.Parse(vForm.MyID),vForm.MyType);
            }

        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    txtAccountNo.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountNo"].Value.ToString();
                    txtAccountName.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountName"].Value.ToString();
                    txtRemarks.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Remarks"].Value.ToString();
                    txtDebit.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Debit"].Value.ToString();
                    txtCredit.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Credit"].Value.ToString();

                    txtTotalDebit.Text = (double.Parse(txtTotalDebit.Text) - double.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["Debit"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint)).ToString("G29");
                    txtTotalCredit.Text = (double.Parse(txtTotalCredit.Text) - double.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["Credit"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint)).ToString("G29");
                    Grid.Rows.Remove(Grid.CurrentRow);
                    txtAccountNo.Focus();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void cboVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string vType = getVoucherType();
                txtVoucherNo.Text = objDAL.getNextID(vType).ToString(); // Get New Order No
                ClearBodyControls();
                Grid.Rows.Clear();

                if (vType == "CRV")
                {
                    this.txtDebit.Text = "0";
                    this.txtDebit.Enabled = false;
                    this.txtCredit.Enabled = true;
                }
                else if (vType == "CPV")
                {
                    this.txtDebit.Enabled = true;
                    this.txtCredit.Enabled = false;
                    this.txtCredit.Text = "0";
                }
                else {
                    this.txtDebit.Enabled = true;
                    this.txtCredit.Enabled = true;
                }
                

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (vOpenMode == false) return;
                PrintVoucher();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void PrintVoucher()
        {
            try
            {                
                string vWhere = string.Empty;
                string vVoucherType = getVoucherType();
                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                DataTable dt = objDAL.getVouchersData(" AND VoucherHeader.VoucherID=" + txtVoucherNo.Text + " AND VoucherHeader.VoucherType='" + vVoucherType + "'");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }

                if (vVoucherType == "JV")
                {
                    vForm.ShowReport("JOURNAL VOUCHER", dt);
                    vForm.ShowDialog();
                }
                else if (vVoucherType == "CRV")
                {
                    DAL.Settings objSet = new DAL.Settings();
                    objSet.connectionstring = objDAL.connectionstring;

                    DataRow dr = dt.NewRow();
                    dr["VoucherNo"] = dt.Rows[0]["VoucherNo"];
                    dr["VoucherType"] = dt.Rows[0]["VoucherType"];
                    dr["VoucherDate"] = dt.Rows[0]["VoucherDate"];                                        
                    dr["Narration"] = dt.Rows[0]["Narration"];
                    dr["AccountNo"] = 100000;
                    dr["AccountName"] = "Cash"; //objSet.GetSettingValue(DAL.Settings.ProSettings.CashAccTitle);

                    decimal vTotalAmount =
                dt.AsEnumerable().Sum(r => r.Field<Decimal>("Credit"));

                    dr["Debit"] = vTotalAmount.ToString("G29");
                    
                    //dr["Debit"] = dt.Rows[0]["Credit"];
                    dr["Credit"] = 0;
                    dr["TranStatus"] = "DEBIT";

                    dt.Rows.Add(dr);

                    vForm.ShowReport("CASH RECEIVING VOUCHER", dt);
                    vForm.ShowDialog();
                }
                else if (vVoucherType == "CPV")
                {
                    vForm.ShowReport("CASH PAYMENT VOUCHER", dt);
                    vForm.ShowDialog();
                }



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
       

        private void dtVoucherDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void CRVoucher_KeyDown(object sender, KeyEventArgs e)
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
                btnOpen_Click(null, null);
            }
        }
    }
}
