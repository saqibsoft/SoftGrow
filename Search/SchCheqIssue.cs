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
    public partial class SchCheqIssue : Form
    {
        string vMyID;        
        public SchCheqIssue()
        {
            InitializeComponent();
        }


        public string MyID
        {
            get
            {
                return vMyID;                
            }
        }
       
      
        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchVoucher_Load(object sender, EventArgs e)
        {            
            DisplayData();
        }
        
       
        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                vWhere = " AND ( BankIssues.BankAccountNo Like '" + txtFilter.Text + "%' AND BankIssues.ChequeNo Like '%" + txtFilter.Text + "%')";
            }
            
            

            try
            {
                DAL.Searches objDAL = new DAL.Searches();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getCheqIssues(vWhere);
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
            SelectRecord();
        }

        private void SelectRecord()
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                vMyID = Grid.Rows[Grid.CurrentRow.Index].Cells["IssueID"].Value.ToString();
            }
            else
            {
                vMyID = "";
            }
            Close();
        }

        private void cboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
          if(e.KeyCode==Keys.Enter)  SelectRecord();
        }
    }
}
