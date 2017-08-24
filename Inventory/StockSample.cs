using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Inventory
{
    public partial class StockSample : Form
    {
        bool vOpenMode;
        DAL.StockSamples objDAL = new DAL.StockSamples();
        DAL.Misc Msc = new DAL.Misc();

        private int vUserID;

        public StockSample(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
        }

        private void SaleInfo_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            Msc.connectionstring = objDAL.connectionstring;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
           // PopulateSalesman();
            SetMode(false);
        }

        private void PopulateSalesman()
        {
            try
            {
                DAL.Employees objSal = new DAL.Employees();
                objSal.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;


                DataTable dt = objSal.getRecord(string.Empty);
                DataRow dr = dt.NewRow();
                dr["EmployeeID"] = 0;
                dr["EmployeeName"] = "-No Selection-";

                dt.Rows.Add(dr);
                if (dt.Rows.Count > 0)
                {
                    cboSalesman.DataSource = dt;
                    cboSalesman.DisplayMember = "EmployeeName";
                    cboSalesman.ValueMember = "EmployeeID";
                }

                cboSalesman.SelectedValue = 0;
                cboSalesman.SelectedText = "-No Selection-";
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
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
                }
                else
                {
                    vOpenMode = false;

                    txtInvNo.Text = objDAL.getNextNo().ToString(); // Get New Order No
                    txtCustomerID.Text = string.Empty;
                    txtCustomerName.Text = string.Empty;                    
                    txtSearch.Text = string.Empty;

                    ClearBodyControls();

                    Grid.Rows.Clear();

                    
                    txtSecurity.Text = string.Empty;
                    
                    txtRemarks.Text = string.Empty;
                    
                    cboSalesman.SelectedValue = 0;
                    cboSalesman.SelectedText = "-No Selection-";
                    //Buttons Setting
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;

                    dtEntryDate.Focus();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void ClearBodyControls()
        {
            txt_ProductID.Text = string.Empty;
            txt_ProductName.Text = string.Empty;
            txt_Qty.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_Disc.Text = string.Empty;
            txtDiscPerc.Text = string.Empty;
            txt_TotalValue.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtUnit.Tag = string.Empty;
            txt_Qty.Tag = string.Empty;
            txtStockQty.Text = string.Empty;
            txtCostPrice.Text = string.Empty;

        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchParties vForm = new SearchForms.SchParties();
                vForm.IsVendor = false;
                vForm.IsCustomer = true;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtCustomerID.Text = vForm.MyID;
                    txtCustomerName.Text = vForm.MyName;
                    txt_ProductID.Focus();
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void GoToNextCont(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
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

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchProducts vForm = new SearchForms.SchProducts();
                vForm.IsSaleable = true;
                vForm.IsConsumable = false;
                vForm.ShowDialog();
                if(!string.IsNullOrEmpty(vForm.MyID))
                {
                txt_ProductID.Text = vForm.MyID;
                txt_ProductName.Text = vForm.MyName;
                txtUnit.Text = vForm.MyUnitName;
                txtUnit.Tag = vForm.MyUnitID.ToString();
                txt_Qty.Tag = vForm.MyMultiplier.ToString("0");
                txt_Price.Text = vForm.MySalePrice.ToString("0");
                txt_Qty.Focus();
                GetCurrentStock(Int64.Parse(vForm.MyID));
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ProductID.Text))
            {
                ClearBodyControls();
            }
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND Products.ProductID = " + txt_ProductID.Text;
                DAL.Searches obj = new DAL.Searches();
                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt = obj.getProducts(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txt_ProductID.Text = dt.Rows[0]["ProductID"].ToString(); // vForm.MyID;
                    txt_ProductName.Text = dt.Rows[0]["ProductName"].ToString();// vForm.MyName;
                    txtUnit.Text = dt.Rows[0]["UnitTitle"].ToString(); //vForm.MyUnitName;
                    txtUnit.Tag = dt.Rows[0]["UnitID"].ToString(); //vForm.MyUnitID.ToString();
                    txt_Qty.Tag = dt.Rows[0]["Units"].ToString(); //vForm.MyMultiplier.ToString("G29");
                    txt_Price.Text = decimal.Parse(dt.Rows[0]["SalePrice"].ToString()).ToString("G29"); //Math.Round(vForm.MyPurPrice, 2).ToString("G29");
                    txt_Qty.Focus();
                   GetCurrentStock(Int64.Parse(txt_ProductID.Text));
                }
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !txt_Price.Text.Contains('.'))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void txt_Disc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCashPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !txtSecurity.Text.Contains('.'))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            ClaculateTotalValue();
        }

        private void ClaculateDiscValue()
        {
            decimal vQty;
            decimal vPrice;
            decimal vDisc;

            decimal.TryParse(txt_Qty.Text, out vQty);
            decimal.TryParse(txt_Price.Text, out vPrice);
            decimal.TryParse(txtDiscPerc.Text, out vDisc);

            if (vDisc == 0)
            {
                txt_Disc.Text = "0";
                return;
            }

            txt_Disc.Text = (((vQty * vPrice) * vDisc) / 100).ToString("G29");
        }

        private void ClaculateDiscPerc()
        {
            decimal vQty;
            decimal vPrice;
            decimal vDisc;

            decimal.TryParse(txt_Qty.Text, out vQty);
            decimal.TryParse(txt_Price.Text, out vPrice);
            decimal.TryParse(txt_Disc.Text, out vDisc);

            if (vDisc == 0)
            {
                txtDiscPerc.Text = "0";
                return;
            }

            txtDiscPerc.Text = ((vDisc / (vQty * vPrice)) * 100).ToString("G29");
        }

        private void CalculateNetTotal(object sender, EventArgs e)
        {
            CalculateNetValue();
        }

        private void ClaculateTotalValue()
        {
            double vQty;
            double vPrice;
            double vDisc;

            double.TryParse(txt_Qty.Text, out vQty);
            double.TryParse(txt_Price.Text, out vPrice);
            double.TryParse(txt_Disc.Text, out vDisc);


            txt_TotalValue.Text = ((vQty * vPrice) - vDisc).ToString();
        }

        private void CalculateNetValue()
        {
            double vGross;
            double vCashPaid;
            double vSpecialDisc;

            double.TryParse(txt_Gross.Text, out vGross);
            double.TryParse(txtSecurity.Text, out vCashPaid);
            double.TryParse(txtSpecialDisc.Text, out vSpecialDisc);

            txt_NetValue.Text = (vGross - vSpecialDisc- vCashPaid).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TTLVal = 0;
                decimal vDiscount = 0;
                decimal vQty = 0;

                if (txt_ProductID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Valid Product", "Product Missing");
                    txt_ProductID.Focus();
                    return;
                }


                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        if (txt_ProductID.Text == dr.Cells["ProductID"].Value.ToString())
                        {
                            MessageBox.Show("Product Already Inserted!!!", "Invalid Entry");
                            txt_ProductID.Focus();
                            return;
                        }
                    }
                }

                decimal.TryParse(txt_TotalValue.Text, out TTLVal);
                decimal.TryParse(txt_Disc.Text, out vDiscount);
                decimal.TryParse(txt_Qty.Text, out vQty);

                if (vQty == 0)
                {
                    MessageBox.Show("Zero Quantity Product Can not be Inserted.", "Invalid Value");
                    txt_Qty.Focus();
                    return;
                }

                if (double.Parse(txt_Qty.Text) > double.Parse(txtStockQty.Text))                
                {
                    MessageBox.Show("Sufficient Stock Not Available For Product Entered.", "Invalid Value");
                    txt_Qty.Focus();
                    return;
                }


                Grid.Rows.Add(txt_ProductID.Text, txt_ProductName.Text, 
                    txtUnit.Tag, txtUnit.Text, txt_Qty.Tag, txt_Qty.Text, 
                    txtCostPrice.Text);
                

                ClearBodyControls();
                txt_ProductID.Focus();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }


        }

        private void btnProClear_Click(object sender, EventArgs e)
        {
            ClearBodyControls();
            txt_ProductID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Grid_Click(object sender, EventArgs e)
        {

            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetMode(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (vOpenMode == false) return;
                DialogResult dMsg = MessageBox.Show("Are you Sure To Delete!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dMsg == DialogResult.No) return;

                //DataTable dt = objDAL.getSaleData(" SaleID =" + txt_InvNo.Text);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    Msc.MinusToCurrentStock(Int64.Parse(dr["ProductID"].ToString()), decimal.Parse(dr["Qty"].ToString()), decimal.Parse(dr["TotalValue"].ToString()));
                //}

                objDAL.DeleteRecordBody(Convert.ToInt32(txtInvNo.Text));
                objDAL.DeleteRecord(Convert.ToInt32(txtInvNo.Text));

                MessageBox.Show("Record Deleted Successfully.", "Confirmation");
                SetMode(false);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
                {
                    MessageBox.Show("Please Select Customer", "Information Missing");
                    txtCustomerID.Focus();
                    return;
                }

                if (Grid.Rows.Count == 0)
                {
                    MessageBox.Show("Please Insert Products Information", "Detail Missing");
                    txt_ProductID.Focus();
                    return;
                }

                decimal vSecurity = 0;
                decimal.TryParse(txtSecurity.Text, out vSecurity);



                Objects.StockSamples BAL = new Objects.StockSamples();

                BAL.SampleID = Int64.Parse(txtInvNo.Text);
                BAL.IssueDate = dtEntryDate.Value;
                BAL.CustomerID = int.Parse(txtCustomerID.Text);                
                BAL.Remarks = txtRemarks.Text;
                BAL.UserID = vUserID;                                                

                if (vOpenMode)
                {
                    objDAL.UpdateRecord(BAL);                   
                    objDAL.DeleteRecordBody(Int64.Parse(txtInvNo.Text));
                }
                else
                {
                    
                    DataTable dt = objDAL.InsertRecord(BAL);
                    BAL.SampleID = Int64.Parse(dt.Rows[0]["SampleID"].ToString());
                }

                //Save Detail
                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        Objects.StockSampleBody objBody = new Objects.StockSampleBody();
                        objBody.SampleID = BAL.SampleID;
                        objBody.ProductID = Int32.Parse(dr.Cells["ProductID"].Value.ToString());
                        objBody.Qty = decimal.Parse(dr.Cells["Qty"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint);                        
                        objBody.Cost = decimal.Parse(dr.Cells["Cost"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint);

                        objDAL.InsertRecordBody(objBody);                        

                    }
                }

                MessageBox.Show("Record Saved Successfully.", "Task Completed");
                SetMode(false);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void OpenInvoice(Int64 vID)
        {
            try
            {
                btnClear_Click(null, null);

                DataTable dt = objDAL.getRecord(" AND StockSamples.SampleID=" + vID);
                if (dt.Rows.Count > 0)
                {
                    txtInvNo.Text = dt.Rows[0]["SampleID"].ToString();
                    dtEntryDate.Text = dt.Rows[0]["IssueDate"].ToString();
                    txtCustomerID.Text = dt.Rows[0]["CustomerID"].ToString();
                    txtCustomerName.Text = dt.Rows[0]["PartyName"].ToString();                    
                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();                    
                    

                    //Grid.DataSource = dt;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid.Rows.Add(dr["ProductID"].ToString(), dr["ProductName"].ToString(),
                            decimal.Parse(dr["UnitID"].ToString()).ToString("0"), 
                            dr["UnitTitle"].ToString(), dr["Units"].ToString(), 
                            decimal.Parse(dr["Qty"].ToString()).ToString("G29"),                             
                            decimal.Parse(dr["Cost"].ToString()).ToString("G29"));
                    }

                    SetMode(true);
                }
                else
                {
                    MessageBox.Show("Invalid Issue ID.", "Invalid Information");
                    SetMode(false);
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)) return;
            OpenInvoice(Int64.Parse(txtSearch.Text));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            SearchForms.SchStockSample vForm = new SearchForms.SchStockSample();
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenInvoice(Int64.Parse(vForm.MyID));
            }

        }

        private void GetCurrentStock(Int64 vProductID)
        {
            DAL.Misc cS = new DAL.Misc();
            cS.connectionstring = objDAL.connectionstring;

            DataTable dt = cS.getCurrentStock(vProductID);

            if (dt.Rows.Count > 0)
            {
                double vQty,vLQty;

                double vValue;
                double.TryParse(dt.Rows[0]["LessQty"].ToString(), out vLQty);
                double.TryParse(dt.Rows[0]["Qty"].ToString(),out vQty);
                double.TryParse(dt.Rows[0]["Value"].ToString(), out vValue);

                txtStockQty.Text = Math.Round(vQty, 2).ToString();
                if (vQty > 0)
                {
                    txtCostPrice.Text = (Math.Round(vValue / (vQty + vLQty), 2)).ToString();
                }
                else
                {
                    txtStockQty.Text = "0";
                    txtCostPrice.Text = "0";
                }
            }
            else
            {
                txtStockQty.Text = "0";
                txtCostPrice.Text = "0";
            }
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !txt_Qty.Text.Contains('.'))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    txt_ProductID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductID"].Value.ToString();
                    txt_ProductName.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductName"].Value.ToString();
                    txt_Qty.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Qty"].Value.ToString();                    
                    txtUnit.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Unit"].Value.ToString();
                    txtUnit.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["UnitID"].Value.ToString();
                    txt_Qty.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["Units"].Value.ToString();                    

                    Grid.Rows.Remove(Grid.CurrentRow);

                    GetCurrentStock(Int64.Parse(txt_ProductID.Text));

                    txt_ProductID.Focus();
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
                string vWhere = string.Empty;

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                vWhere = "AND Sale.SaleID=" + this.txtInvNo.Text;

                DAL.Reports Msc = new DAL.Reports();
                Msc.connectionstring = objDAL.connectionstring;


                DataTable dt = Msc.getSaleInvoices(vWhere);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }

                int vStyle = 0;

                if (chkLetterPad.Checked)
                {
                    vStyle = 2;
                }
                
                if (chkInUrdu.Checked)
                {
                    vStyle = 1;
                }

                

                vForm.SaleInvoicePrint(dt,vStyle);
                vForm.ShowDialog();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCustomerID.Text)) this.txtCustomerName.Text = string.Empty;
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND Parties.PartyID = " + txtCustomerID.Text;
                DAL.CustomerIssue obj = new DAL.CustomerIssue();

                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getParties(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txtCustomerID.Text = dt.Rows[0]["PartyID"].ToString(); // vForm.MyID;
                    txtCustomerName.Text = dt.Rows[0]["PartyName"].ToString();// vForm.MyName;

                }
            }
        }

        private void txtDiscPerc_TextChanged(object sender, EventArgs e)
        {
            decimal vDiscPer = 0;
            decimal.TryParse(txtDiscPerc.Text, out vDiscPer);

            if (vDiscPer > 100) txtDiscPerc.Text = "100";

            if (txtDiscPerc.Focused) ClaculateDiscValue();
        }

        private void txt_Disc_TextChanged(object sender, EventArgs e)
        {
            ClaculateDiscPerc();
            CalculateTotal(sender, e);
        }

        private void StockSample_KeyDown(object sender, KeyEventArgs e)
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
                btnOpen_Click(null, null);
            }
        }
    }
}
