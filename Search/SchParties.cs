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
    public partial class SchParties : Form
    {
        bool vIsVendor;
        bool vIsCustomer;
        bool vWithAccounts;
        bool vIsJV;

        string tmpID,tmpName,tmpAccount;
        

        public SchParties()
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

        public string MyAccount
        {
            get
            {
                return tmpAccount;
            }
        }


        public bool IsVendor
        {
            set { vIsVendor = value; }
        }

        public bool IsCustomer
        {
            set { vIsCustomer = value; }
        }

        public bool withAccounts
        {
            set { vWithAccounts = value; }
        }

        public bool IsJV
        {
            set { vIsJV = value; }
        }


        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchParties_Load(object sender, EventArgs e)
        {
            if (vWithAccounts == true) this.Text = "Search Account";
            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))            
            {
                vWhere = " AND PartyName Like '%" + txtFilter.Text + "%'";
            }

            if (vIsVendor)
            {
                vWhere += " AND Isnull(IsSupplier,0)=1";
            }

            if (vIsCustomer)
            {
                vWhere += " AND Isnull(IsCustomer,0)=1";
            }

            try
            {
                DAL.Searches objDAL = new DAL.Searches();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getParties(vWhere, vWithAccounts, vIsJV);
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
                tmpID = Grid.Rows[Grid.CurrentRow.Index].Cells["PartyID"].Value.ToString();
                tmpName = Grid.Rows[Grid.CurrentRow.Index].Cells["PartyName"].Value.ToString();
                tmpAccount = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountID"].Value.ToString();
            }
            else
            { 
              tmpID = "";
              tmpName = "";
              tmpAccount = string.Empty;
            }

             
            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) SelectRecord();
        }

    }
}
