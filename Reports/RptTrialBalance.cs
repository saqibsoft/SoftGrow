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
    public partial class RptTrialBalance : Form
    {
        DAL.Reports objDAL = new DAL.Reports();

        public RptTrialBalance()
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
                DateTime vDateTo = DateTime.Today.Date; // DateTime.Today.Date.Month.ToString() + "/" + DateTime.Today.Date.Day.ToString() + "/" + DateTime.Today.Date.Year.ToString();

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();
                
               

                //if (optRange.Checked == true)
                //{
                //    vDateFrom = dt_From.Value; //dt_From.Value.Month.ToString() + "/" + dt_From.Value.Day.ToString() + "/" + dt_From.Value.Year.ToString();
                //    vDateTo = dt_ToDate.Value; //dt_ToDate.Value.Month.ToString() + "/" + dt_ToDate.Value.Day.ToString() + "/" + dt_ToDate.Value.Year.ToString(); 
                //}

                vDateTo = dt_ToDate.Value;

                DataTable dt = objDAL.getTrialBalance( vDateTo.ToShortDateString());

                
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }

                DAL.Misc dal = new DAL.Misc();
                dal.connectionstring = objDAL.connectionstring;

                decimal vNetSaleVal = dal.getNetSalesValue(vDateFrom.ToShortDateString(), vDateTo.ToShortDateString());
                decimal vNetPurVal = dal.getNetPurchaseValue(vDateFrom.ToShortDateString(), vDateTo.ToShortDateString());

                DataRow dr = dt.NewRow();
                dr["AccountType"] = "EXPENSE";
                dr["AccountNo"] = "300000";
                dr["AccountTitle"] = "Purchases";
                dr["Debit"] = vNetPurVal;
                dr["Credit"] = 0;

                dt.Rows.Add(dr);

                DataRow dr1 = dt.NewRow();
                dr1["AccountType"] = "REVENUE";
                dr1["AccountNo"] = "400000";
                dr1["AccountTitle"] = "Sales";
                dr1["Debit"] = 0;
                dr1["Credit"] = vNetSaleVal;

                dt.Rows.Add(dr1);

                vForm.ShowTrialBalance(vDateTo, dt);
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
