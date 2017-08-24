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
    public partial class RptAccountsList : Form
    {
        DAL.Reports objDAL = new DAL.Reports();
        public RptAccountsList()
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
                string vWhere = string.Empty;
                string vReportTitle = string.Empty;

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();


                DataTable dt = new DataTable();

                if (optBankAcc.Checked)
                {
                    dt = objDAL.getBankAccList(vWhere);
                    vReportTitle = "BANK ACCOUNT LIST";
                }
                else if (optGeneral.Checked)
                {
                    dt = objDAL.getAccountsList(vWhere);
                    vReportTitle = "GEN ACCOUNT LIST";
                }



                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }

                vForm.ShowReport(vReportTitle, dt);
                vForm.ShowDialog();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptPartyList_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;            
        }
        
    }

    
}
