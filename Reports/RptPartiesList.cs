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
    public partial class RptPartiesList : Form
    {
        DAL.Reports objDAL = new DAL.Reports(); 
        public RptPartiesList()
        {
            InitializeComponent();
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchParties vForm = new SearchForms.SchParties();
                vForm.IsVendor = false;
                vForm.IsCustomer = false;
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


        private void txtVendor_KeyPress(object sender, KeyPressEventArgs e)
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
                string vWhere = string.Empty;

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                if (!string.IsNullOrEmpty(this.txtVendorID.Text))
                {
                    vWhere = " AND PartyID=" + this.txtVendorID.Text;
                }

                if (chkSupplier.Checked == true)
                {
                    vWhere += " AND Isnull(IsSupplier)=1";
                }

                if (chkCustomer.Checked == true)
                {
                    vWhere += " AND Isnull(IsCustomer)=1";
                }

                DataTable dt = objDAL.getPartiesList(vWhere);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }
                vForm.ShowReport("PARTIES LIST", dt);
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

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVendorID.Text)) txtVendorName.Text = string.Empty;
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND Parties.PartyID = " + txtVendorID.Text;
                DAL.CustomerIssue obj = new DAL.CustomerIssue();

                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getParties(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txtVendorID.Text = dt.Rows[0]["PartyID"].ToString(); // vForm.MyID;
                    txtVendorName.Text = dt.Rows[0]["PartyName"].ToString();// vForm.MyName;

                }
            }
        }
    }

    
}
