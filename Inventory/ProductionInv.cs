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
    public partial class ProductionInv : Form
    {
        bool vOpenMode;
        DAL.Production objDAL = new DAL.Production();
        DAL.Misc Msc = new DAL.Misc();

        private int vUserID;

        public ProductionInv(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductionInv_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            Msc.connectionstring = objDAL.connectionstring;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            SetMode(false);
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

                    txt_InvNo.Text = objDAL.getNextID().ToString(); // Get New Order No
                    txt_Narration.Text = string.Empty;
                    txt_Search.Text = string.Empty;

                    ClearBodyControls();
                    ClearBodyControls1();

                    Grid.Rows.Clear();
                    Grid1.Rows.Clear();                    

                    //Buttons Setting
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

        private void GoToNextCont(object sender, KeyEventArgs e)
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

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchProducts vForm = new SearchForms.SchProducts();
                vForm.IsSaleable = false;
                vForm.IsConsumable = true;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txt_ProductID.Text = vForm.MyID;
                    txt_ProductName.Text = vForm.MyName;
                    txtUnit.Text = vForm.MyUnitName;
                    txtUnit.Tag = vForm.MyUnitID.ToString();
                    txt_Qty.Tag = vForm.MyMultiplier.ToString("0");
                    //txt_Price.Text = vForm.MyPurPrice.ToString("0");
                    txt_Qty.Focus();
                    GetCurrentStock(Int64.Parse(vForm.MyID));
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void txtProduct1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchProducts vForm = new SearchForms.SchProducts();
                vForm.IsSaleable = true;
                vForm.IsConsumable = false;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txt_ProductID1.Text = vForm.MyID;
                    txt_ProductName1.Text = vForm.MyName;
                    txtUnit1.Text = vForm.MyUnitName;
                    txtUnit1.Tag = vForm.MyUnitID.ToString();
                    txt_Qty1.Tag = vForm.MyMultiplier.ToString("0");
                    //txt_Price1.Text = vForm.MyPurPrice.ToString("0");
                    txt_Qty1.Focus();
                    GetCurrentStock1(Int64.Parse(vForm.MyID));
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

        private void txt_ProductID1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ProductID1.Text))
            {
                ClearBodyControls1();
            }
        }

        private void ClearBodyControls()
        {
            txt_ProductID.Text = string.Empty;
            txt_ProductName.Text = string.Empty;
            txt_Qty.Text = string.Empty;
            txtStockQty.Text = string.Empty;
            txt_Cost.Text = string.Empty;         
            txt_TotalValue.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtUnit.Tag = string.Empty;
            txt_Qty.Tag = string.Empty;
        }

        private void ClearBodyControls1()
        {
            txt_ProductID1.Text = string.Empty;
            txt_ProductName1.Text = string.Empty;
            txt_Qty1.Text = string.Empty;
            txtStockQty1.Text = string.Empty;
            txt_Cost1.Text = string.Empty;
            txt_TotalValue1.Text = string.Empty;
            txtUnit1.Text = string.Empty;
            txtUnit1.Tag = string.Empty;
            txt_Qty1.Tag = string.Empty;
        }

        private void ClaculateTotalValue(object sender,EventArgs e)
        {
            double vQty;
            double vPrice;            

            double.TryParse(txt_Qty.Text, out vQty);
            double.TryParse(txt_Cost.Text, out vPrice);            


            txt_TotalValue.Text = ((vQty * vPrice)).ToString();
        }

        private void ClaculateTotalValue1(object sender, EventArgs e)
        {
            double vQty;
            double vPrice;

            double.TryParse(txt_Qty1.Text, out vQty);
            double.TryParse(txt_Cost1.Text, out vPrice);

            txt_TotalValue1.Text = ((vQty * vPrice)).ToString();
        }

        private void btnProClear_Click(object sender, EventArgs e)
        {
            ClearBodyControls();
            txt_ProductID.Focus();
        }

        private void btnProClear1_Click(object sender, EventArgs e)
        {
            ClearBodyControls1();
            txt_ProductID1.Focus();
        }

        private void GetCurrentStock(Int64 vProductID)
        {
            DAL.Misc cS = new DAL.Misc();
            cS.connectionstring = objDAL.connectionstring;

            DataTable dt = cS.getCurrentStock(vProductID);

            if (dt.Rows.Count > 0)
            {
                decimal vQty, vLQty;
                decimal vValue;

                decimal.TryParse(dt.Rows[0]["LessQty"].ToString(), out vLQty);
                decimal.TryParse(dt.Rows[0]["Qty"].ToString(), out vQty);
                decimal.TryParse(dt.Rows[0]["Value"].ToString(), out vValue);

                txtStockQty.Text = Math.Round(vQty,2).ToString();
                if (vQty > 0)
                {
                    txt_Cost.Text = (Math.Round(vValue / (vQty+ vLQty), 2)).ToString();
                }
                else txt_Cost.Text = "0";
            }
            else
            {
                txtStockQty.Text = string.Empty;
                txt_Cost.Text = string.Empty;
            }
        }

        private void GetCurrentStock1(Int64 vProductID)
        {
            DAL.Misc cS = new DAL.Misc();
            cS.connectionstring = objDAL.connectionstring;

            DataTable dt = cS.getCurrentStock(vProductID);

            if (dt.Rows.Count > 0)
            {
                decimal vQty, vLQty; ;
                decimal vValue;
                decimal.TryParse(dt.Rows[0]["LessQty"].ToString(), out vLQty);
                decimal.TryParse(dt.Rows[0]["Qty"].ToString(), out vQty);
                decimal.TryParse(dt.Rows[0]["Value"].ToString(), out vValue);

                txtStockQty1.Text = Math.Round(vQty,2).ToString();
                if (vQty > 0)
                {
                    txt_Cost1.Text = (Math.Round(vValue / (vQty+vLQty), 2)).ToString();
                }
                else txt_Cost1.Text = "0";
            }
            else
            {
                txtStockQty1.Text = string.Empty;
                txt_Cost1.Text = string.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TTLVal = 0;         

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

                //if (TTLVal == 0)
                //{
                //    MessageBox.Show("Zero Value Product Can not be Inserted.", "Invalid Value");
                //    txt_Qty.Focus();
                //    return;
                //}

                if (double.Parse(txt_Qty.Text) > double.Parse(txtStockQty.Text))
                {
                    MessageBox.Show("Sufficient Stock Not Available For Product Entered.", "Invalid Value");
                    txt_Qty.Focus();
                    return;
                }


                Grid.Rows.Add(txt_ProductID.Text, txt_ProductName.Text, txtUnit.Tag, txtUnit.Text, txt_Qty.Tag,txt_Cost.Text, txt_Qty.Text,  txt_TotalValue.Text);                

                ClearBodyControls();
                txt_ProductID.Focus();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }


        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TTLVal = 0;

                if (txt_ProductID1.Text == string.Empty)
                {
                    MessageBox.Show("Please Select or Insert Valid Product", "Product Missing");
                    txt_ProductID1.Focus();
                    return;
                }


                foreach (DataGridViewRow dr in Grid1.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        if (txt_ProductID1.Text == dr.Cells["ProductID1"].Value.ToString())
                        {
                            MessageBox.Show("Product Already Inserted!!!", "Invalid Entry");
                            txt_ProductID1.Focus();
                            return;
                        }
                    }
                }

                decimal.TryParse(txt_TotalValue1.Text, out TTLVal);

                //if (TTLVal == 0)
                //{
                //    MessageBox.Show("Zero Value Product Can not be Inserted.", "Invalid Value");
                //    txt_Qty1.Focus();
                //    return;
                //}

                //if (double.Parse(txt_Qty1.Text) > double.Parse(txtStockQty1.Text))
                //{
                //    MessageBox.Show("Sufficient Stock Not Available For Product Entered.", "Invalid Value");
                //    txt_Qty1.Focus();
                //    return;
                //}


                Grid1.Rows.Add(txt_ProductID1.Text, txt_ProductName1.Text, txtUnit1.Tag, txtUnit1.Text, txt_Qty1.Tag,txt_Cost1.Text, txt_Qty1.Text, txt_TotalValue1.Text);

                ClearBodyControls1();
                txt_ProductID1.Focus();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
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
                    txt_Cost.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["Cost"].Value.ToString();                    
                    txt_TotalValue.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["TotalValue"].Value.ToString();
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

        private void Grid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid1.Rows.Count > 0 && Grid1.CurrentRow.Index != -1)
                {
                    txt_ProductID1.Text = Grid1.Rows[Grid1.CurrentRow.Index].Cells["ProductID1"].Value.ToString();
                    txt_ProductName1.Text = Grid1.Rows[Grid1.CurrentRow.Index].Cells["ProductName1"].Value.ToString();
                    txt_Qty1.Text = Grid1.Rows[Grid1.CurrentRow.Index].Cells["Qty1"].Value.ToString();
                    txt_Cost1.Text = Grid1.Rows[Grid1.CurrentRow.Index].Cells["Cost1"].Value.ToString();
                    txt_TotalValue1.Text = Grid1.Rows[Grid1.CurrentRow.Index].Cells["TotalValue1"].Value.ToString();
                    txtUnit1.Text = Grid1.Rows[Grid1.CurrentRow.Index].Cells["UnitTitle1"].Value.ToString();
                    txtUnit1.Tag = Grid1.Rows[Grid1.CurrentRow.Index].Cells["UnitID1"].Value.ToString();
                    txt_Qty1.Tag = Grid1.Rows[Grid1.CurrentRow.Index].Cells["Units1"].Value.ToString();

                    Grid1.Rows.Remove(Grid1.CurrentRow);
                    GetCurrentStock1(Int64.Parse(txt_ProductID1.Text));

                    txt_ProductID1.Focus();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }

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

                objDAL.DeleteConsumption(Convert.ToInt32(txt_InvNo.Text));
                objDAL.DeleteProductionBody(Convert.ToInt32(txt_InvNo.Text));
                objDAL.DeleteRecord(Convert.ToInt32(txt_InvNo.Text));

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

                if (Grid.Rows.Count == 0)
                {
                    MessageBox.Show("Please Insert Consumed Products Information", "Detail Missing");
                    txt_ProductID.Focus();
                    return;
                }

                if (Grid1.Rows.Count == 0)
                {
                    MessageBox.Show("Please Insert Produced Products Information", "Detail Missing");
                    txt_ProductID1.Focus();
                    return;
                }

                Objects.Production BAL = new Objects.Production();

                BAL.ProductionID = int.Parse(txt_InvNo.Text);
                BAL.EntryDate = dt_Entry.Value;                                
                BAL.Narration = txt_Narration.Text;
                BAL.UserID = vUserID;

                if (vOpenMode)
                {
                    objDAL.UpdateRecord(BAL);
                    objDAL.DeleteConsumption(Int32.Parse(txt_InvNo.Text));
                    objDAL.DeleteProductionBody(Int32.Parse(txt_InvNo.Text));
                }
                else
                {
                    objDAL.InsertRecord(BAL);
                }

                

                //Save Detail Consumption
                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        decimal tempValue = 0;
                        Objects.Consumption objBody = new Objects.Consumption();
                        objBody.ProductionID = int.Parse(txt_InvNo.Text);
                        objBody.ProductID = Int32.Parse(dr.Cells["ProductID"].Value.ToString());
                        objBody.ProducedProductID = Int32.Parse(dr.Cells["ProductID"].Value.ToString());

                        decimal.TryParse(dr.Cells["Qty"].Value.ToString(), out tempValue);
                        objBody.Qty = tempValue;
                        decimal.TryParse(dr.Cells["Cost"].Value.ToString(),out tempValue);
                        objBody.Cost = tempValue;                                      
                        
                        objDAL.InsertConsumption(objBody);

                    }
                }

                //Save Detail ProductionBody
                foreach (DataGridViewRow dr in Grid1.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        decimal tempValue = 0;
                        Objects.ProductionBody objBody = new Objects.ProductionBody();
                        objBody.ProductionID = int.Parse(txt_InvNo.Text);
                        objBody.ProductID = Int32.Parse(dr.Cells["ProductID1"].Value.ToString());
                        decimal.TryParse(dr.Cells["Qty1"].Value.ToString(),out tempValue);
                        objBody.Qty = tempValue;
                        decimal.TryParse(dr.Cells["Cost1"].Value.ToString(),out tempValue);
                        objBody.Cost = tempValue;
                        objBody.Remarks = string.Empty;
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

        private void OpenInvoice(Int64 vProductionID)
        {
            try
            {
                DataTable dt = objDAL.getProductionData(" AND Production.ProductionID=" + vProductionID);
                if (dt.Rows.Count > 0)
                {
                    txt_InvNo.Text = dt.Rows[0]["ProductionID"].ToString();
                    dt_Entry.Text = dt.Rows[0]["EntryDate"].ToString();                    
                    txt_Narration.Text = dt.Rows[0]["Narration"].ToString();                    

                    //Populate Production Body
                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid1.Rows.Add(dr["ProductID"].ToString(), dr["ProductName"].ToString(), decimal.Parse(dr["UnitID"].ToString()).ToString("0"), dr["UnitTitle"].ToString(), dr["Units"].ToString(), decimal.Parse(dr["Cost"].ToString()).ToString("G29"), decimal.Parse(dr["Qty"].ToString()).ToString("G29"), decimal.Parse(dr["TotalValue"].ToString()).ToString("G29"));
                    }

                    //Populate Consumption Body
                    DataTable dt1 = objDAL.getConsumptionData(vProductionID);
                    foreach (DataRow dr in dt1.Rows)
                    {
                        Grid.Rows.Add(dr["ProductID"].ToString(), dr["ProductName"].ToString(), decimal.Parse(dr["UnitID"].ToString()).ToString("0"), dr["UnitTitle"].ToString(), dr["Units"].ToString(), decimal.Parse(dr["Cost"].ToString()).ToString("G29"), decimal.Parse(dr["Qty"].ToString()).ToString("G29"), decimal.Parse(dr["TotalValue"].ToString()).ToString("G29"));
                    }

                    SetMode(true);
                }
                else
                {
                    MessageBox.Show("Invalid Production ID.", "Invalid Information");
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
            OpenInvoice(Int64.Parse(txt_Search.Text));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            SearchForms.SchProduction vForm = new SearchForms.SchProduction();
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenInvoice(Int64.Parse(vForm.MyID));
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void ProductionInv_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_ProductID1_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_ProductID1.Text != string.Empty)
            {
                string vWhere = string.Empty;
                //vForm.IsSaleable = true;
                //vForm.IsConsumable = false;

                bool IsSaleable = true;
                bool IsConsumable = false;
                //vWhere = "AND ";

                if (IsSaleable)
                {
                    vWhere += " AND Isnull(Products.IsRawMaterial,0)=0 ";
                }

                if (IsConsumable)
                {
                    vWhere += " AND Isnull(Products.IsRawMaterial,0)=1 ";
                }
                vWhere += "AND Products.ProductID = " + txt_ProductID1.Text;
                DAL.Searches obj = new DAL.Searches();
                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt = obj.getProducts(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txt_ProductID1.Text = dt.Rows[0]["ProductID"].ToString(); // vForm.MyID;
                    txt_ProductName1.Text = dt.Rows[0]["ProductName"].ToString();// vForm.MyName;
                    txtUnit1.Text = dt.Rows[0]["UnitTitle"].ToString(); //vForm.MyUnitName;
                    txtUnit1.Tag = dt.Rows[0]["UnitID"].ToString(); //vForm.MyUnitID.ToString();
                    txt_Qty1.Tag = dt.Rows[0]["Units"].ToString(); //vForm.MyMultiplier.ToString("G29");

                    //txt_Qty1.Focus();
                    GetCurrentStock1(Int64.Parse(txt_ProductID1.Text));
                }
            }
            else
            {
                ClearBodyControls1();
            }
        }

        private void txt_ProductID_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_ProductID.Text != string.Empty)
            {
                string vWhere = string.Empty;
                bool IsSaleable = false;
                bool IsConsumable = true;
                //vWhere = "AND ";

                if (IsSaleable)
                {
                    vWhere += " AND Isnull(Products.IsRawMaterial,0)=0";
                }

                if (IsConsumable)
                {
                    vWhere += " AND Isnull(Products.IsRawMaterial,0)=1";
                }

                vWhere += "AND Products.ProductID = " + txt_ProductID.Text;
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

                    //txt_Qty.Focus();
                    GetCurrentStock(Int64.Parse(txt_ProductID.Text));
                }
            }
            else
            {
                ClearBodyControls();
            }
        }
    }
}
