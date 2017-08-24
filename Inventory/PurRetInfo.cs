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
    public partial class PurRetInfo : Form
    {
        bool vOpenMode;
        DAL.PurReturn objDAL = new DAL.PurReturn();
        DAL.Misc Msc = new DAL.Misc();

        private int vUserID;

        public PurRetInfo(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
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

        private void GoToNextCont(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtVendorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
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
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !txt_Disc.Text.Contains('.'))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void txtCashPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !txtCashPaid.Text.Contains('.'))
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

            double.TryParse(txt_Gross.Text, out vGross);
            double.TryParse(txtCashPaid.Text, out vCashPaid);

            txt_NetValue.Text = (vGross - vCashPaid).ToString();
        }

        private void SetMode(bool blnOpen)
        {
            try
            {
                if (blnOpen)
                {
                    vOpenMode = true;

                    //Buttons Setting
                    btnOpenPur.Enabled = false;
                    btnDelete.Enabled = true;
                    btnPrint.Enabled = true;

                }
                else
                {
                    vOpenMode = false;

                    txtReturnID.Text = objDAL.getNextNo().ToString(); // Get New Order No
                    txt_InvNo.Text = string.Empty;
                    txtVendorID.Text = string.Empty;
                    txtVendorName.Text = string.Empty;
                    txtPurchaseDate.Text = string.Empty;
                    txt_Search.Text = string.Empty;

                    ClearBodyControls();

                    Grid.Rows.Clear();

                    txt_Gross.Text = string.Empty;
                    txtCashPaid.Text = string.Empty;
                    txt_NetValue.Text = string.Empty;
                    txt_Narration.Text = string.Empty;

                    //Buttons Setting
                    btnOpenPur.Enabled = true;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;

                    dt_Entry.Focus();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void PurchaseInfo_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            Msc.connectionstring = objDAL.connectionstring;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            SetMode(false);
        }

        private void ClearBodyControls()
        {
            txt_ProductID.Text = string.Empty;
            txt_ProductName.Text = string.Empty;
            txt_Qty.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_Disc.Text = string.Empty;
            txt_TotalValue.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtUnit.Tag = string.Empty;
            txt_Qty.Tag = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TTLVal = 0;
                decimal vDiscount = 0;

                if (txt_ProductID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select or Insert Valid Product", "Product Missing");
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

                if (TTLVal == 0)
                {
                    MessageBox.Show("Zero Value Product Can not be Inserted.", "Invalid Value");
                    txt_Qty.Focus();
                    return;
                }



                Grid.Rows.Add(txt_ProductID.Text, txt_ProductName.Text, txtUnit.Tag, txtUnit.Text, txt_Qty.Tag, txt_Qty.Text, txt_Price.Text, vDiscount, txt_TotalValue.Text);

                txt_Gross.Text = (decimal.Parse((string.IsNullOrEmpty(txt_Gross.Text) ? "0" : txt_Gross.Text)) + TTLVal).ToString("G29");

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

                //DataTable dt = objDAL.getPurchaseData(" PurchaseID =" + txt_InvNo.Text);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    Msc.MinusToCurrentStock(Int64.Parse(dr["ProductID"].ToString()), decimal.Parse(dr["Qty"].ToString()), decimal.Parse(dr["TotalValue"].ToString()));
                //}

                objDAL.DeleteRecordBody(Convert.ToInt64(txtReturnID.Text));
                objDAL.DeleteRecord(Convert.ToInt64(txtReturnID.Text));

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

                if (string.IsNullOrEmpty(txt_InvNo.Text.Trim()))
                {
                    MessageBox.Show("Please Load a Purchase First!!!", "Information Missing");
                    btnOpenPur.Focus();
                    return;
                }

                bool vHasSelectedRows = false;

                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (Convert.ToBoolean(dr.Cells["Select"].Value) == true)
                    {
                        vHasSelectedRows = true;
                        break;
                    }
                }


                if (!vHasSelectedRows)
                {
                    MessageBox.Show("Please Select Products to Save..", "Detail Missing");
                    Grid.Focus();
                    return;
                }

                decimal vCashPaid = 0;
                decimal.TryParse(txtCashPaid.Text, out vCashPaid);

                Objects.PurReturn BAL = new Objects.PurReturn();
                BAL.PurReturnID = Int64.Parse(txtReturnID.Text);
                BAL.PurchaseID = Int64.Parse(txt_InvNo.Text);
                BAL.EntryDate = dt_Entry.Value;
                BAL.VendorID = int.Parse(txtVendorID.Text);
                BAL.GrossValue = decimal.Parse(txt_Gross.Text, System.Globalization.NumberStyles.AllowDecimalPoint);
                BAL.CashReceived = vCashPaid;
                BAL.Narration = txt_Narration.Text;
                BAL.UserID = vUserID;

                if (vOpenMode)
                {
                    objDAL.UpdateRecord(BAL);
                    objDAL.DeleteRecordBody(Int64.Parse(txtReturnID.Text));
                }
                else
                {
                    BAL.PurReturnID = objDAL.getNextNo();
                    objDAL.InsertRecord(BAL);
                }

                //Save Detail
                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null && Convert.ToBoolean(dr.Cells["Select"].Value) == true)
                    {
                        Objects.PurReturnBody objBody = new Objects.PurReturnBody();
                        objBody.PurReturnID = Int64.Parse(txtReturnID.Text);
                        objBody.ProductID = Int32.Parse(dr.Cells["ProductID"].Value.ToString());
                        objBody.Qty = decimal.Parse(dr.Cells["Qty"].Value.ToString());
                        objBody.Price = decimal.Parse(dr.Cells["Price"].Value.ToString());
                        objBody.Discount = decimal.Parse(dr.Cells["Disc"].Value.ToString());
                        objBody.TotalValue = decimal.Parse(dr.Cells["TotalValue"].Value.ToString());

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

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchParties vForm = new SearchForms.SchParties();
                vForm.IsVendor = true;
                vForm.IsCustomer = false;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtVendorID.Text = vForm.MyID;
                    txtVendorName.Text = vForm.MyName;
                    txt_ProductID.Focus();
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchProducts vForm = new SearchForms.SchProducts();
                vForm.IsSaleable = false;
                vForm.IsConsumable = false;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txt_ProductID.Text = vForm.MyID;
                    txt_ProductName.Text = vForm.MyName;
                    txtUnit.Text = vForm.MyUnitName;
                    txtUnit.Tag = vForm.MyUnitID.ToString();
                    txt_Qty.Tag = vForm.MyMultiplier.ToString("0");
                    txt_Price.Text = vForm.MyPurPrice.ToString("0");
                    txt_Qty.Focus();
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
        }

        private void OpenInvoice(Int64 vPurchaseID)
        {
            try
            {
                DataTable dt = objDAL.getPurchaseData(" AND Purchase.PurchaseID=" + vPurchaseID);
                if (dt.Rows.Count > 0)
                {
                    txt_InvNo.Text = dt.Rows[0]["PurchaseID"].ToString();
                    txtPurchaseDate.Text = Convert.ToDateTime(dt.Rows[0]["EntryDate"].ToString()).ToShortDateString();
                    txtVendorID.Text = dt.Rows[0]["VendorID"].ToString();
                    txtVendorName.Text = dt.Rows[0]["PartyName"].ToString();
                    txt_Gross.Text = decimal.Parse(dt.Rows[0]["GrossValue"].ToString()).ToString("G29");
                    txt_Narration.Text = dt.Rows[0]["Narration"].ToString();
                    txtCashPaid.Text = decimal.Parse(dt.Rows[0]["CashPaid"].ToString()).ToString("G29");

                    //Grid.DataSource = dt;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid.Rows.Add(true, dr["ProductID"].ToString(), dr["ProductName"].ToString(), decimal.Parse(dr["UnitID"].ToString()).ToString("0"), dr["UnitTitle"].ToString(), dr["Units"].ToString(), decimal.Parse(dr["Qty"].ToString()).ToString("G29"), decimal.Parse(dr["Price"].ToString()).ToString("G29"), decimal.Parse(dr["Discount"].ToString()).ToString("G29"), decimal.Parse(dr["TotalValue"].ToString()).ToString("G29"));
                    }

                    //SetMode(true);
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

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text)) return;
            OpenInvoiceReturn(Int64.Parse(txt_Search.Text));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            SearchForms.SchPurReturn vForm = new SearchForms.SchPurReturn();
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenInvoiceReturn(Int64.Parse(vForm.MyID));
            }

        }

        private void OpenInvoiceReturn(Int64 vPurRetID)
        {
            try
            {
                DataTable dt = objDAL.getRecord(vPurRetID);
                if (dt.Rows.Count > 0)
                {
                    txtReturnID.Text = dt.Rows[0]["PurReturnID"].ToString();
                    txt_InvNo.Text = dt.Rows[0]["PurchaseID"].ToString();
                    dt_Entry.Value = Convert.ToDateTime(dt.Rows[0]["EntryDate"].ToString());
                    txtPurchaseDate.Text = Convert.ToDateTime(dt.Rows[0]["PurchaseDate"].ToString()).ToShortDateString();
                    txtVendorID.Text = dt.Rows[0]["VendorID"].ToString();
                    txtVendorName.Text = dt.Rows[0]["PartyName"].ToString();
                    txt_Gross.Text = decimal.Parse(dt.Rows[0]["GrossValue"].ToString()).ToString("G29");
                    txt_Narration.Text = dt.Rows[0]["Narration"].ToString();
                    txtCashPaid.Text = decimal.Parse(dt.Rows[0]["CashReceived"].ToString()).ToString("G29");

                    //Grid.DataSource = dt;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid.Rows.Add(Convert.ToBoolean(dr["Selected"].ToString()), dr["ProductID"].ToString(), dr["ProductName"].ToString(), decimal.Parse(dr["UnitID"].ToString()).ToString("0"), dr["UnitTitle"].ToString(), dr["Units"].ToString(), decimal.Parse(dr["Qty"].ToString()).ToString("G29"), decimal.Parse(dr["Price"].ToString()).ToString("G29"), decimal.Parse(dr["Discount"].ToString()).ToString("G29"), decimal.Parse(dr["TotalValue"].ToString()).ToString("G29"));
                    }

                    SetMode(true);
                }
                else
                {
                    MessageBox.Show("Invalid Purchase Return ID.", "Invalid Information");
                    SetMode(false);
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            SearchForms.SchPurchase vForm = new SearchForms.SchPurchase();
            vForm.vIsFromReturn = true;
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenInvoice(Int64.Parse(vForm.MyID));
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
                    txt_Price.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Price"].Value.ToString();
                    txt_Disc.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Disc"].Value.ToString();
                    txt_TotalValue.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["TotalValue"].Value.ToString();
                    txtUnit.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Unit"].Value.ToString();
                    txtUnit.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["UnitID"].Value.ToString();
                    txt_Qty.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["Units"].Value.ToString();

                    txt_Gross.Text = (double.Parse(txt_Gross.Text) - double.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["TotalValue"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint)).ToString("G29");

                    Grid.Rows.Remove(Grid.CurrentRow);

                    txt_ProductID.Focus();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void Grid_Click(object sender, EventArgs e)
        { }

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVendorID.Text)) txtVendorName.Text = string.Empty;
        }

        private void Grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = Grid.Rows[e.RowIndex];
                decimal vQty, vPrice, vDisc, vGross;
                decimal.TryParse(row.Cells["Qty"].Value.ToString(), out vQty);
                decimal.TryParse(row.Cells["Price"].Value.ToString(), out vPrice);
                decimal.TryParse(row.Cells["Disc"].Value.ToString(), out vDisc);
                decimal.TryParse(txt_Gross.Text, out vGross);


                decimal result = (vQty * vPrice) - vDisc;

                //txt_Gross.Text = (vGross + result - decimal.Parse(row.Cells["TotalValue"].Value.ToString())).ToString("g");

                row.Cells["TotalValue"].Value = result.ToString("g");

                CalculateGross();

            }
        }

        private void CalculateGross()
        {
            decimal vGross = 0;
            foreach (DataGridViewRow dr in Grid.Rows)
            {
                if (Convert.ToBoolean(dr.Cells["Select"].Value) == true)
                {
                    vGross += decimal.Parse(dr.Cells["TotalValue"].Value.ToString());
                }
            }

            txt_Gross.Text = vGross.ToString("g");
        }

        private void PurRetInfo_KeyDown(object sender, KeyEventArgs e)
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
