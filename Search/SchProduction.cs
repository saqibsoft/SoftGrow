using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.SearchForms
{
    public partial class SchProduction : Form
    {
        public SchProduction()
        {
            InitializeComponent();
        }

        private string _MyID;

        public string MyID
        {
            get
            {

                return _MyID;
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    return Grid.Rows[Grid.CurrentRow.Index].Cells["ProductionID"].Value.ToString();
                }
                else return "";
            }
        }

        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchProduction_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                vWhere = " AND Narration Like '%" + txtFilter.Text + "%'";
            }

            try
            {
                DAL.Searches objDAL = new DAL.Searches();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getProduction(vWhere);
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
                _MyID = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductionID"].Value.ToString();
            }

            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SelectRecord();
        }
    }
}
