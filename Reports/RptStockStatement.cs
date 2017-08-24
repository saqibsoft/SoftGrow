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
    public partial class RptStockStatement : Form
    {
        DAL.Reports objDAL = new DAL.Reports();

        public RptStockStatement()
        {
            InitializeComponent();
        }

        private void GoToNextCont(object sender, KeyEventArgs e)
        {

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
                DateTime vDateFrom = Convert.ToDateTime("1/1/2000");
                DateTime vDateTo = DateTime.Today.Date;

                if (optRange.Checked == true)
                {
                    vDateFrom = dt_From.Value; 
                    vDateTo = dt_ToDate.Value; 
                }

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


                DataTable dt = objDAL.getStockStatement(vDateFrom.ToShortDateString(), vDateTo.ToShortDateString(), vWhere);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display","No Data");
                    return;
                }
                vForm.ShowStockStatement(dt);                
                vForm.ShowDialog();                
                
            }
            catch (Exception exc)
            {
                
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptCurrentStock_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;           
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }        

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ProductID.Text)) txt_ProductName.Text = string.Empty;
        }
    }
}
