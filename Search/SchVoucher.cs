using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Search
{
    public partial class SchVoucher : Form
    {
        string vMyID,vMyType;
        string vRecordType = "All";


        public SchVoucher()
        {
            InitializeComponent();
        }

        public string RecordType
        {
            set { vRecordType = value; }
        }

        public string MyID
        {
            get
            {
                return vMyID;                
            }
        }

        public string MyType
        {
            get
            {
                return vMyType;                
            }
        }
      
        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;

        private void SchVoucher_Load(object sender, EventArgs e)
        {
            if (vRecordType != "All")
            {
                if (vRecordType == "CRV") this.cboVoucherType.SelectedIndex = 0;
                if (vRecordType == "CPV") this.cboVoucherType.SelectedIndex = 1;
                if (vRecordType == "JV") this.cboVoucherType.SelectedIndex = 2;
                this.cboVoucherType.Enabled = false;
            }

            DisplayData();
        }

        private string getVoucherType()
        {
            string vType = string.Empty;
            if (this.cboVoucherType.Text == "Cash Receiving")
            {
                vType = "CRV";
            }
            else if (this.cboVoucherType.Text == "Cash Payment")
            {
                vType = "CPV";
            }
            else
            {
                vType = "JV";
            }

            return vType;
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                vWhere = " AND VoucherHeader.VoucherID Like '" + txtFilter.Text + "%'";
            }

            if (!string.IsNullOrEmpty(cboVoucherType.Text))
            {
                vWhere += " AND VoucherHeader.VoucherType ='" + getVoucherType() + "'";
            }            

            try
            {
                DAL.Searches objDAL = new DAL.Searches();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getVouchers(vWhere);
                Grid.DataSource = dt;

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString());
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
                vMyID = Grid.Rows[Grid.CurrentRow.Index].Cells["VoucherNo"].Value.ToString();
                vMyType = Grid.Rows[Grid.CurrentRow.Index].Cells["VoucherType"].Value.ToString();
            }
            else
            {
                vMyID = "";
                vMyType = "";
            }




            Close();
        }

        private void cboVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SelectRecord();
        }
    }
}
