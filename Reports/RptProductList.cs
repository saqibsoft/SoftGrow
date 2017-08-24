using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Reports
{
    public partial class RptProductList : Form
    {
        DAL.Reports objDAL = new DAL.Reports();  
        public RptProductList()
        {
            InitializeComponent();
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
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string vWhere=string.Empty;

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                if (!string.IsNullOrEmpty(this.txt_ProductID.Text))
                {
                    vWhere = " AND Products.ProductID=" + this.txt_ProductID.Text;
                }

                if (chkConsumable.Checked == true)
                {
                    vWhere += " AND Isnull(Products.IsRawMaterial,0)=1";
                }

                if (chkSaleable.Checked == true)
                {
                    vWhere += " AND Isnull(Products.IsRawMaterial,0)=0";
                }

                DataTable dt= objDAL.getProductList(vWhere);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display","No Data");
                    return;
                }

                int vStyle=0;

                if (optBothPrices.Checked)
                {
                    vStyle = 0;
                }
                else if (optPurOnly.Checked)
                {
                    vStyle = 1;
                }
                else if (optSaleOnly.Checked)
                {
                    vStyle = 2;
                }

                vForm.ProductList(dt, vStyle);                
                vForm.ShowDialog();                                
            }
            catch (Exception exc)
            {
                
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptProductList_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ProductID.Text)) txt_ProductName.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_ProductID.Text))
            {
                txt_ProductName.Text = string.Empty;
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
                  
                }
            }
        }
    }
}
