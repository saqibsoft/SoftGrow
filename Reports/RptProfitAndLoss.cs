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
    public partial class RptProfitAndLoss : Form
    {
        DAL.Reports objDAL = new DAL.Reports();

        public RptProfitAndLoss()
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
                

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {                
                DateTime vDateFrom = Convert.ToDateTime("1/1/2000");
                DateTime vDateTo = DateTime.Today.Date;
                string vNarration = "";

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();



                if (optRange.Checked == true)
                {
                    vDateFrom = dt_From.Value;
                    vDateTo = dt_ToDate.Value;
                    vNarration = "From " + dt_From.Value.ToShortDateString() + " To " + dt_ToDate.Value.ToShortDateString();
                }
                else
                    vNarration = "For the Period Ended " + dt_ToDate.Value.ToString("dd-MMM-yyyy");
                
                DataTable dt = objDAL.getProfitAndLoss(vDateFrom.ToShortDateString(), vDateTo.ToShortDateString());
                //if (dt.Rows.Count == 0)
                //{
                //    MessageBox.Show("No Data To Display", "No Data");
                //    return;
                //}

                DAL.Misc dal = new DAL.Misc();
                dal.connectionstring = objDAL.connectionstring;

                decimal vNetSaleVal = dal.getNetSalesValue(vDateFrom.ToShortDateString(), vDateTo.ToShortDateString());
                decimal vNetPurVal = dal.getNetPurchaseValue(vDateFrom.ToShortDateString(), vDateTo.ToShortDateString());
                decimal vOpStockVal = dal.getOpeningStockValue(string.Empty);

                DataTable dTemp = objDAL.getCurrentStock(string.Empty);

                decimal vCSValue = 0;

                foreach (DataRow dr in dTemp.Rows)
                {
                    decimal vCurrentStockVal =(decimal)dr["Value"];
                    decimal vNetQty =  (decimal)dr["Qty"];
                    decimal vDeducted =  (decimal)dr["LessQty"];

                    decimal vCSRate = vCurrentStockVal / (vNetQty + vDeducted);
                    vCSValue += (vNetQty * vCSRate);
                }

                //decimal vCurrentStockVal = dTemp.AsEnumerable()
                // .Sum(dr => (decimal)dr["Value"]);
                //decimal vNetQty = dTemp.AsEnumerable()
                // .Sum(dr => (decimal)dr["Qty"]);
                //decimal vDeducted = dTemp.AsEnumerable()
                // .Sum(dr => (decimal)dr["LessQty"]);



                vForm.ShowProfitAndLoss(vNarration, vNetSaleVal, vOpStockVal, vNetPurVal, vCSValue, dt);
                vForm.ShowDialog();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptCashBook_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            this.dt_From.Value = DateTime.Today.AddMonths(-12);
            this.dt_ToDate.Value = DateTime.Now;
        }        
    }
}
