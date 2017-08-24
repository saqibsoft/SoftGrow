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
    public partial class SchSale : Form
    {
        public SchSale()
        {
            InitializeComponent();
        }

        public string MyID = string.Empty;
        public bool vIsFromReturn;

        private void SetValue()
        {            
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    MyID = Grid.Rows[Grid.CurrentRow.Index].Cells["SaleID"].Value.ToString();
                }
                Close();
        }

        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchSale_Load(object sender, EventArgs e)
        {
            dt_From.Value = DateTime.Now.AddDays(-30);
            dt_ToDate.Value = DateTime.Now.Date;

            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                vWhere = " AND PartyName Like '%" + txtFilter.Text + "%'";
            }

            vWhere += string.Format(" And convert(datetime,Convert(varchar,Sale.EntryDate,1)) Between Convert(Datetime,(convert(varchar,convert(Datetime,'{0} 00:00:00',102),1)))and Convert(Datetime,(convert(varchar,convert(Datetime,'{1} 00:00:00',102),1)))",dt_From.Value.ToShortDateString(),dt_ToDate.Value.ToShortDateString());

            if (vIsFromReturn)            
            {
                vWhere += " AND SaleID NOT IN (Select SaleID From SaleReturn)";
            }

            try
            {
                DAL.Searches objDAL = new DAL.Searches();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getSale(vWhere);
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

        private void dt_From_ValueChanged(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
