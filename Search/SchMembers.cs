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
    public partial class SchMembers : Form
    {        

        string tmpID,tmpName;


        public SchMembers()
        {
            InitializeComponent();
        }

        public string MyID
        {
            get
            {
                return tmpID;
            }
        }

        public string MyName
        {
            get
            {
                return tmpName;                
            }
        }


        


        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchParties_Load(object sender, EventArgs e)
        {            
            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))            
            {
                vWhere = " AND MemberName Like '%" + txtFilter.Text + "%'";
            }
            

            try
            {
                DAL.ShareMembers objDAL = new DAL.ShareMembers();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getRecord(vWhere);
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
            tmpID=string.Empty;
            tmpName=string.Empty;
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
                tmpID = Grid.Rows[Grid.CurrentRow.Index].Cells["MemberID"].Value.ToString();
            }
            else tmpID = "";

            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpName = Grid.Rows[Grid.CurrentRow.Index].Cells["MemberName"].Value.ToString();
            }
            else tmpName = "";
            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) SelectRecord();
        }

    }
}
