using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.SearchForms
{
    public partial class SchProducts : Form
    {
        public SchProducts()
        {
            InitializeComponent();
        }


        bool vIsSaleable;
        bool vIsConsumable;

        string tmpID, tmpName;
        decimal TempSalePrice;
        decimal TempPurchasePrice;
        int TempUnitID;


        
        public string MyID
        { get {
            return tmpID;                         
            } 
        }

        public string MyName
        {
            get
            {
                return tmpName;              
            }
        }

        public decimal MySalePrice
        {
            get
            {

                return TempSalePrice;
               
            }
        }

        public decimal MyPurPrice
        {
            get
            {
                return TempPurchasePrice;
            }
        }


        public int MyUnitID
        {
            get
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    return int.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["UnitID"].Value.ToString());
                }
                else return 0;
            }
        }

        public string MyUnitName
        {
            get
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    return Grid.Rows[Grid.CurrentRow.Index].Cells["UnitTitle"].Value.ToString();
                }
                else return "";
            }
        }

        public decimal MyMultiplier
        {
            get
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    return decimal.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["Units"].Value.ToString());
                }
                else return 0;
            }
        }

        public bool IsSaleable
        {
            set { vIsSaleable = value; }
        }

        public bool IsConsumable
        {
            set { vIsConsumable = value; }
        }



        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchProducts_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))            
            {
                vWhere = " AND Products.ProductName Like '%" + txtFilter.Text + "%'";
            }

            if (vIsSaleable)
            {
                vWhere += " AND Isnull(Products.IsRawMaterial,0)=0";
            }

            if (vIsConsumable)
            {
                vWhere += " AND Isnull(Products.IsRawMaterial,0)=1";
            }

            try
            {
                DAL.Searches objDAL = new DAL.Searches();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getProducts(vWhere);
                Grid.DataSource = dt;
                
            }
            catch (Exception exc)
            {
                
                MessageBox.Show(exc.Message.ToString());
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tmpID = string.Empty;
            tmpName = string.Empty;
            //PurchasePrice = 
            Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void SelectRecord()
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpID = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductID"].Value.ToString();
            }
            else tmpID = "";

            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpName = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductName"].Value.ToString();
            }
            else tmpName = "";

            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                TempPurchasePrice = decimal.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["PurchasePrice"].Value.ToString());
            }
            else TempPurchasePrice = 0;
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                TempSalePrice = decimal.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["SalePrice"].Value.ToString());
            }
            else TempSalePrice = 0;


            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) SelectRecord();
        }

    }
}
