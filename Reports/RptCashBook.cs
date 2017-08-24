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
    public partial class RptCashBook : Form
    {
        DAL.Reports objDAL = new DAL.Reports();

        public RptCashBook()
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
                
               

                if (optRange.Checked == true)
                {
                    vDateFrom = dt_From.Value; //dt_From.Value.Month.ToString() + "/" + dt_From.Value.Day.ToString() + "/" + dt_From.Value.Year.ToString();
                    vDateTo = dt_ToDate.Value; //dt_ToDate.Value.Month.ToString() + "/" + dt_ToDate.Value.Day.ToString() + "/" + dt_ToDate.Value.Year.ToString(); 
                }
                
                DataTable dt = objDAL.getCashBook(vDateFrom.ToShortDateString(), vDateTo.ToShortDateString());
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }
                vForm.ShowCashBook(vDateFrom, vDateTo, dt);
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
