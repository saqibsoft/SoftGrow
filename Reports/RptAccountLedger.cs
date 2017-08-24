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
    public partial class RptAccountLedger : Form
    {
        DAL.Reports objDAL = new DAL.Reports();

        public RptAccountLedger()
        {
            InitializeComponent();
        }
        

        private void txtParty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchAccounts vForm = new Search.SchAccounts();
                vForm.IsGeneral = false;
                vForm.IsBank = false;
                vForm.IsParty = false;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtVendorID.Text = vForm.MyID;
                    txtVendorName.Text = vForm.MyName;
                }
            }
            else
            {
                GoToNextCont(sender, e);
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


        private void txtParty_KeyPress(object sender, KeyPressEventArgs e)
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
                string vPartyID = string.Empty;
                DateTime vDateFrom = Convert.ToDateTime("1/1/2000");
                DateTime vDateTo = DateTime.Today.Date; // DateTime.Today.Date.Month.ToString() + "/" + DateTime.Today.Date.Day.ToString() + "/" + DateTime.Today.Date.Year.ToString();

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                if (string.IsNullOrEmpty(this.txtVendorID.Text))
                {
                    MessageBox.Show("Must Select a Party First!!!", "Missing Information");
                    return;
                }

                if (!string.IsNullOrEmpty(this.txtVendorID.Text))
                {
                    vPartyID = this.txtVendorID.Text;
                }

               

                if (optRange.Checked == true)
                {
                    vDateFrom = dt_From.Value; //dt_From.Value.Month.ToString() + "/" + dt_From.Value.Day.ToString() + "/" + dt_From.Value.Year.ToString();
                    vDateTo = dt_ToDate.Value; //dt_ToDate.Value.Month.ToString() + "/" + dt_ToDate.Value.Day.ToString() + "/" + dt_ToDate.Value.Year.ToString(); 
                }


                //DataTable dt = objDAL.getPartyLedger(vPartyID, dt_From.Value.Month.ToString() + "/" + dt_From.Value.Day.ToString() + "/" + dt_From.Value.Year.ToString(), dt_ToDate.Value.Month.ToString() + "/" + dt_ToDate.Value.Day.ToString() + "/" + dt_ToDate.Value.Year.ToString());
                DataTable dt = objDAL.getPartyLedger(vPartyID, vDateFrom.ToShortDateString(), vDateTo.ToShortDateString());
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }
                vForm.ShowLedger(vPartyID, string.Empty, vDateFrom, vDateTo, dt,chkLetterPad.Checked);
                vForm.ShowDialog();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptPartyLedger_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;

            dt_From.Enabled = false;
            dt_ToDate.Enabled = false;

        }

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtVendorID.Text)) txtVendorName.Text = string.Empty;
            else
            {
                string vWhere = string.Empty;
                vWhere = " AND AccountChart.AccountNo = " + txtVendorID.Text;
                DAL.AccountChart obj = new DAL.AccountChart();

                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getRecord(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txtVendorID.Text = dt.Rows[0]["AccountNo"].ToString(); // vForm.MyID;
                    txtVendorName.Text = dt.Rows[0]["AccountTitle"].ToString();// vForm.MyName;

                }
            }
        }

        private void optAllDates_CheckedChanged(object sender, EventArgs e)
        {
            dt_From.Enabled = false;
            dt_ToDate.Enabled = false;
        }

        private void optRange_CheckedChanged(object sender, EventArgs e)
        {
            dt_From.Enabled = true;
            dt_ToDate.Enabled = true;
        }
    }
}
