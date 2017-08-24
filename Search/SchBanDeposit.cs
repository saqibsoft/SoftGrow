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
    public partial class SchBanDeposit : Form
    {
        string vMyID;
        bool vIsChequeDep = false;
        public SchBanDeposit()
        {
            InitializeComponent();
        }



        public bool IsChequeDeposit
        {
            set { vIsChequeDep = value; }
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
                vWhere = " AND ( BankDeposits.AccountNo Like '" + txtFilter.Text + "%' AND BankDeposits.BankAccountNo Like '" + txtFilter.Text + "%')";
            }
            

            if (vIsChequeDep)
            {
                vWhere += " AND Isnull(BankDeposits.IsCheque,0) =1";
            }
            else
            {
                vWhere += " AND Isnull(BankDeposits.IsCheque,0) =0";
            }

            try
            {
                DAL.Searches objDAL = new DAL.Searches();
                objDAL.connectionstring = connectionString;
                dt = objDAL.getDeposits(vWhere);
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
                vMyID = Grid.Rows[Grid.CurrentRow.Index].Cells["DepositID"].Value.ToString();
            }
            else
            {
                vMyID = "";
            }




            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SelectRecord();
        }
        
    }
}
