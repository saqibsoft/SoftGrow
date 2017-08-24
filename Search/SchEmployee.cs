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
    public partial class SchEmployee : Form
    {
       
        string tmpID,tmpName;


        public SchEmployee()
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
            PopulateCombos();
            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))            
            {
                vWhere = " AND Employees.EmployeeName Like '%" + txtFilter.Text + "%'";
            }

            if (int.Parse(cboDepartment.SelectedValue.ToString()) > 0)
            {
                vWhere += " AND Employees.DepartmentID=" + cboDepartment.SelectedValue;
            }
            
            try
            {
                DAL.Employees objDAL = new DAL.Employees();
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

        private void PopulateCombos()
        {
            try
            {
                DataTable dt = new DataTable();

                DAL.Departments obj = new DAL.Departments();
                obj.connectionstring = connectionString;
                dt = obj.getRecord(string.Empty);

                DataRow dr = dt.NewRow();
                dr["DepartmentID"] = "0";
                dr["DepartmentTitle"] = "ALL";

                dt.Rows.Add(dr);

                cboDepartment.DataSource = dt;
                cboDepartment.ValueMember = "DepartmentID";
                cboDepartment.DisplayMember = "DepartmentTitle";

                cboDepartment.SelectedValue = "0";
                cboDepartment.SelectedText = "ALL";


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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
                tmpID = Grid.Rows[Grid.CurrentRow.Index].Cells["EmployeeID"].Value.ToString();
            }
            else tmpID = "";

            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpName = Grid.Rows[Grid.CurrentRow.Index].Cells["EmployeeName"].Value.ToString();
            }
            else tmpName = "";
            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) SelectRecord();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDepartment.Focused) DisplayData();
        }

    }
}
