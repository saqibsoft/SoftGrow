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
    public partial class SchAccounts : Form
    {
        bool vIsParty=false;        
        bool vIsBank=false;
        bool vIsGeneral=false;        
        bool vIsJV=false;

        string tmpID,tmpName;
        

        public SchAccounts()
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


        public bool IsParty
        {
            set { vIsParty = value; }
        }

        public bool IsBank
        {
            set { vIsBank = value; }
        }
        

        public bool IsGeneral
        {
            set { vIsGeneral = value; }
        }

        public bool IsJV
        {
            set { vIsJV = value; }
        }
        

        DataTable dt;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
        private void SchParties_Load(object sender, EventArgs e)
        {            
            if (vIsBank == true) this.Text = "Select Bank Account";
            if (vIsParty == true) this.Text = "Select Party Account";

            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))            
            {
                vWhere = " AND AccountTitle Like '%" + txtFilter.Text + "%'";
            }
            
                        

                if (vIsBank)
                {
                    vWhere += " AND Isnull(IsBank,0)=1";
                }
                //else { vWhere += " AND Isnull(IsBank,0)=0"; }

                if (vIsParty)
                {
                    vWhere += " AND Isnull(IsParty,0)=1";
                }
                //else { vWhere += " AND Isnull(IsDonor,0)=0"; }

                if (vIsGeneral)
                {
                    vWhere += "  AND Isnull(IsBank,0)=0 AND Isnull(IsParty,0)=0";
                }
            
            try
            {
                DAL.AccountChart objDAL = new DAL.AccountChart();
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
                tmpID = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountNo"].Value.ToString();
            }
            else tmpID = "";

            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpName = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountTitle"].Value.ToString();
            }
            else tmpName = "";
            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SelectRecord();
        }
    }
}
