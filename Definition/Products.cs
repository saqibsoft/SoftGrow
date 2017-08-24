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
    public partial class Products : Form
    {
        DAL.Products objDAL = new DAL.Products();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;

        public Products()
        {
            InitializeComponent();
        }
        private void PartiesInfo_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            PopulateUnits();
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
        private void ForQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !mytxt.Text.Contains('.'))
            {
                e.Handled = true; //Do not reject the input
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
                txtName.Text = string.Empty;
                txtPurPrice.Text = "0";
                txtSalePrice.Text = "0";                
                this.txtOpQty.Text = "0";
                this.txtOpValue.Text = "0";
                chkRawMaterial.Checked = false;

                vOpenMode = false;
                Grid.Enabled = false;
                txtFilter.Text = string.Empty;
                txtFilter.Enabled = false;
                txtName.Focus();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void PopulateUnits()
        {
            try
            {
                DAL.UnitsInfo objUnit = new DAL.UnitsInfo();
                objUnit.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;


                DataTable dt = objUnit.getRecord(string.Empty);

                if (dt.Rows.Count > 0)
                {
                    cboUnit.DataSource = dt;
                    cboUnit.DisplayMember = "UnitTitle";
                    cboUnit.ValueMember = "UnitID";
                }
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
                if (!string.IsNullOrEmpty(txtFilter.Text))
                {
                    vWhere = " AND Products.ProductName Like '%" + txtFilter.Text + "%'";
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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND Products.ProductID=" + txtID.Text);

                    txtName.Text = dt.Rows[0]["ProductName"].ToString();
                    txtPurPrice.Text = decimal.Parse(dt.Rows[0]["CostPrice"].ToString()).ToString("G29");
                    txtSalePrice.Text = decimal.Parse(dt.Rows[0]["SalePrice"].ToString()).ToString("G29");

                    txtOpQty.Text = decimal.Parse(dt.Rows[0]["OpeningStock"].ToString()).ToString("G29");
                    txtOpValue.Text = decimal.Parse(dt.Rows[0]["OpeningStockValue"].ToString()).ToString("G29");

                    chkRawMaterial.Checked = Convert.ToBoolean(dt.Rows[0]["IsRawMaterial"].ToString());

                    cboUnit.SelectedValue = dt.Rows[0]["UnitID"].ToString();
                    cboUnit.SelectedText = dt.Rows[0]["UnitTitle"].ToString();

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
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Product Name.");
                    txtName.Focus();
                    return;
                }


                decimal vPurPrice = 0;
                decimal vSalePrice = 0;

                Objects.Products obj = new Objects.Products();
                obj.ProductID = Int64.Parse(txtID.Text);
                obj.ProductName = txtName.Text.Trim();
                obj.UnitID = int.Parse(cboUnit.SelectedValue.ToString());

                decimal.TryParse(this.txtPurPrice.Text, out vPurPrice);
                decimal.TryParse(this.txtSalePrice.Text, out vSalePrice);

                obj.CostPrice = vPurPrice;
                obj.SalePrice = vSalePrice;
                


                decimal vOpQty = 0;
                decimal vOpValue = 0;

                decimal.TryParse(this.txtOpQty.Text, out vOpQty);
                decimal.TryParse(this.txtOpValue.Text, out vOpValue);

                obj.OpeningStock = vOpQty;
                obj.OpeningStockValue = vOpValue;

                obj.IsRawMaterial = chkRawMaterial.Checked;

                if (!vOpenMode)
                {
                    
                    //Insert 
                    obj.ProductID = objDAL.getNextNo();                    
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate                     
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

        private void Products_KeyDown(object sender, KeyEventArgs e)
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

        private void cboUnit_Leave(object sender, EventArgs e)
        {
            //txtPurPrice.
        }

      

       

        

        

        
       
        

        
    }

}
