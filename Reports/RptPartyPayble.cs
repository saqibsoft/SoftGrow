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
    public partial class RptPartyPayble : Form
    {
        DAL.Reports objDAL = new DAL.Reports();

        public RptPartyPayble()
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
                DateTime vDateTo = DateTime.Today.Date; // DateTime.Today.Date.Month.ToString() + "/" + DateTime.Today.Date.Day.ToString() + "/" + DateTime.Today.Date.Year.ToString();

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();                               

                
                vDateTo = dt_Till.Value; //dt_ToDate.Value.Month.ToString() + "/" + dt_ToDate.Value.Day.ToString() + "/" + dt_ToDate.Value.Year.ToString(); 
                


                //DataTable dt = objDAL.getPartyLedger(vPartyID, dt_From.Value.Month.ToString() + "/" + dt_From.Value.Day.ToString() + "/" + dt_From.Value.Year.ToString(), dt_ToDate.Value.Month.ToString() + "/" + dt_ToDate.Value.Day.ToString() + "/" + dt_ToDate.Value.Year.ToString());
                DataTable dt = objDAL.getPartiesRecPay( vDateTo.ToShortDateString(), false);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }
                vForm.ShowRecPay(vDateTo, false, dt);
                vForm.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptPartyPayble_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            this.dt_Till.Value = DateTime.Now;
        }        
    }
}
