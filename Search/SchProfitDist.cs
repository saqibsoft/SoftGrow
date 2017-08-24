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
    public partial class SchProfitDist : Form
    {
        public SchProfitDist()
        {
            InitializeComponent();
        }

        public string MyID = string.Empty;
        public bool vIsFromReturn;

        private void SetValue()
        {            
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    MyID = Grid.Rows[Grid.CurrentRow.Index].Cells["DistributionID"].Value.ToString();
                }
                Close();
        }

        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchSale_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                vWhere = " AND SchemeTitle Like '%" + txtFilter.Text + "%'";
            }

            

            try
            {
                DAL.ProfitDistribution objDAL = new DAL.ProfitDistribution();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getRecordSearch(vWhere);
                Grid.AutoGenerateColumns = false;
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
            SetValue();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SetValue();
        }
    }
}
