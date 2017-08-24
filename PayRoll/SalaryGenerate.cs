using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.PayRoll
{
    public partial class SalaryGenerate : Form
    {
        DAL.Salary objDAL = new DAL.Salary();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;
        int vUserID;
        public SalaryGenerate(int userid)
        {
            InitializeComponent();
            vUserID = userid;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            PopuldateDepartmentFilter();
            PopulateCombos();
            LoadGrid();
            ClearFields();
        }

        private void PopulateCombos()
        {
            try
            {
                DataTable dt = new DataTable();

                DAL.Departments obj = new DAL.Departments();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);

                cboDepartment.DataSource = dt;
                cboDepartment.ValueMember = "DepartmentID";
                cboDepartment.DisplayMember = "DepartmentTitle";


                DAL.Designation objD = new DAL.Designation();
                objD.connectionstring = objDAL.connectionstring;
                dt = objD.getRecord(string.Empty);

                DataRow dr = dt.NewRow();
                dr["DesignationID"] = 0;
                dr["DesignationTitle"] = "All";
                dt.Rows.Add(dr);
                cboDesignation.DataSource = dt;
                cboDesignation.ValueMember = "DesignationID";
                cboDesignation.DisplayMember = "DesignationTitle";

                cboDesignation.SelectedValue = 0;
                cboDesignation.SelectedText = "All";


                DAL.Shifts objS = new DAL.Shifts();
                objS.connectionstring = objDAL.connectionstring;
                dt = objS.getRecord(string.Empty);

                DataRow dr1 = dt.NewRow();
                dr1["ShiftID"] = 0;
                dr1["ShiftTitle"] = "All";
                dt.Rows.Add(dr1);                

                cboShift.DataSource = dt;
                cboShift.ValueMember = "ShiftID";
                cboShift.DisplayMember = "ShiftTitle";

                cboShift.SelectedValue = 0;
                cboShift.SelectedText = "All";


            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }

        private void PopuldateDepartmentFilter()
        {
            try
            {
                DataTable dt = new DataTable();

                DAL.Departments obj = new DAL.Departments();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);

                DataRow dr = dt.NewRow();
                dr["DepartmentID"] = 0;
                dr["DepartmentTitle"] = "All";
                dt.Rows.Add(dr);

                cboDepartmentFilter.DataSource = dt;
                cboDepartmentFilter.ValueMember = "DepartmentID";
                cboDepartmentFilter.DisplayMember = "DepartmentTitle";

                cboDepartmentFilter.SelectedValue = 0;
                cboDepartmentFilter.SelectedText = "All";                

            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }

        #region // General Methods
        private void MoveNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void ForAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !mytxt.Text.Contains('.'))
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        #endregion

        #region // Control Operations
        private void ClearFields()
        {
            try
            {
                txtID.Text = objDAL.getNextNo().ToString();                
                txtRemarks.Text = string.Empty;
                txtTotalSalary.Text = string.Empty;
                GridBody.Rows.Clear();

                vOpenMode = false;
                Grid.Enabled = false;
                dtFilterMonth.Enabled = false;
                dtFilterMonth.Value = DateTime.Today;
                cboDepartmentFilter.Enabled = false;
                txtRemarks.Focus();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void dtFilterMonth_ValueChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void dtSalaryMonth_ValueChanged(object sender, EventArgs e)
        {
            GridBody.Rows.Clear();
        }
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.Focused) GridBody.Rows.Clear();
        }
        private void cboDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesignation.Focused) GridBody.Rows.Clear();
        }
        private void cboShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShift.Focused) GridBody.Rows.Clear();
        }
        private void CalculateTotalSalary()
        {

            try
            {
                decimal vTotalSalary = 0;
                foreach (DataGridViewRow dr in GridBody.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        vTotalSalary += decimal.Parse(dr.Cells["NetSalary"].Value.ToString());
                    }
                }

                txtTotalSalary.Text = vTotalSalary.ToString("G29");
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }
        #endregion

        #region // Grid Operations
        private void LoadGrid()
        {
            try
            {
                //Grid.Rows.Clear();
                string vWhere = string.Empty;
                vWhere = string.Format(" AND Month(Salary.SalaryMonth)={0} AND Year(Salary.SalaryMonth)={1}", dtFilterMonth.Value.Month, dtFilterMonth.Value.Year);

                if (int.Parse(cboDepartmentFilter.SelectedValue.ToString()) > 0)
                {
                    vWhere += " AND Salary.DepartmentID=" + cboDepartmentFilter.SelectedValue;
                }

                DataTable dt = objDAL.getRecordMain(vWhere);
                Grid.AutoGenerateColumns = false;
                Grid.DataSource = dt;
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }
        private void Grid_DoubleClick(object sender, EventArgs e)
        {
           
        }
        private void Grid_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["SalaryID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND Salary.SalaryID=" + txtID.Text);

                    dtGenerate.Value = Convert.ToDateTime(dt.Rows[0]["GenerateDate"].ToString());
                    dtSalaryMonth.Value = Convert.ToDateTime(dt.Rows[0]["SalaryMonth"].ToString());
                    cboDepartment.SelectedValue = dt.Rows[0]["DepartmentID"].ToString();
                    cboDepartment.SelectedText = dt.Rows[0]["DepartmentTitle"].ToString();

                    if (!string.IsNullOrEmpty(dt.Rows[0]["DesignationID"].ToString()))
                    {
                        cboDesignation.SelectedValue = dt.Rows[0]["DesignationID"].ToString();
                        cboDesignation.SelectedText = dt.Rows[0]["DesignationTitle"].ToString();
                    }
                    else
                    {
                        cboDesignation.SelectedValue = 0;
                        cboDesignation.SelectedText = "All";
                    }

                    if (!string.IsNullOrEmpty(dt.Rows[0]["ShiftID"].ToString()))
                    {
                        cboShift.SelectedValue = dt.Rows[0]["ShiftID"].ToString();
                        cboShift.SelectedText = dt.Rows[0]["ShiftTitle"].ToString();
                    }
                    else
                    {
                        cboShift.SelectedValue = 0;
                        cboShift.SelectedText = "All";
                    }

                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();

                    txtTotalSalary.Text = decimal.Parse(dt.Rows[0]["TotalSalary"].ToString()).ToString("G29");

                    GridBody.Rows.Clear();

                    foreach (DataRow dr in dt.Rows)
                    {
                        GridBody.Rows.Add(
                            dr["EmployeeID"].ToString(),
                            dr["EmployeeName"].ToString(),
                            decimal.Parse(dr["Presents"].ToString()).ToString("G29"),
                            decimal.Parse(dr["Leaves"].ToString()).ToString("G29"),
                            decimal.Parse(dr["BasicSalary"].ToString()).ToString("G29"),
                            decimal.Parse(dr["Allowances"].ToString()).ToString("G29"),
                            decimal.Parse(dr["Bonus"].ToString()).ToString("G29"),
                            decimal.Parse(dr["Deduction"].ToString()).ToString("G29"),
                            decimal.Parse(dr["NetSalary"].ToString()).ToString("G29")
                            );
                    }

                    vOpenMode = true;
                }
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }
        private void GridBody_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = GridBody.Rows[e.RowIndex];
                decimal vBasic, vAllownce, vBonus, vDeduct;
                decimal.TryParse(row.Cells["BasicSalary"].Value.ToString(), out vBasic);
                decimal.TryParse(row.Cells["Allowances"].Value.ToString(), out vAllownce);
                decimal.TryParse(row.Cells["Bonus"].Value.ToString(), out vBonus);
                decimal.TryParse(row.Cells["Deduction"].Value.ToString(), out vDeduct);


                decimal result = (vBasic + vAllownce + vBonus) - vDeduct;


                row.Cells["NetSalary"].Value = result.ToString("G29");

                CalculateTotalSalary();
            }
        }
        #endregion

        #region // Buttons Click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int vDept, vDesig, vShift;

                int.TryParse(cboDepartment.SelectedValue.ToString(), out vDept);
                int.TryParse(cboDesignation.SelectedValue.ToString(), out vDesig);
                int.TryParse(cboShift.SelectedValue.ToString(), out vShift);

                string vWhere;

                vWhere = " AND Employees.DepartmentID=" + vDept;

                if (vDesig > 0)
                {
                    vWhere += " AND Employees.DesignationID=" + vDesig;
                }

                if (vShift > 0)
                {
                    vWhere += " AND Employees.ShiftID=" + vShift;
                }


                DataTable dt = objDAL.getEmployees(vWhere,dtSalaryMonth.Value.Month,dtSalaryMonth.Value.Year);

                GridBody.Rows.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    GridBody.Rows.Add(
                        dr["EmployeeID"].ToString(),
                        dr["EmployeeName"].ToString(),
                        decimal.Parse(dr["Presents"].ToString()).ToString("G29"),
                        decimal.Parse(dr["Leaves"].ToString()).ToString("G29"),
                        decimal.Parse(dr["BasicSalary"].ToString()).ToString("G29"),
                        0,
                        0,
                        0,
                        decimal.Parse(dr["BasicSalary"].ToString()).ToString("G29")
                        );
                }

                CalculateTotalSalary();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
            dtFilterMonth.Enabled = true;
            cboDepartmentFilter.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                if (!Message.ConfrmDelMsg()) return;

                objDAL.DeleteRecordBody(Int64.Parse(txtID.Text));
                objDAL.DeleteRecord(Int64.Parse(txtID.Text));
                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);
                LoadGrid();
                btnClear_Click(sender,e);

            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridBody.Rows.Count ==0)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Generate Salary First.");
                    btnGenerate.Focus();
                    return;
                }
                decimal vTotalSalary;

                decimal.TryParse(txtTotalSalary.Text, out vTotalSalary);

                int vDept, vDesig, vShift;

                int.TryParse(cboDepartment.SelectedValue.ToString(), out vDept);
                int.TryParse(cboDesignation.SelectedValue.ToString(), out vDesig);
                int.TryParse(cboShift.SelectedValue.ToString(), out vShift);

                Objects.Salary obj = new Objects.Salary();
                obj.SalaryID = Int64.Parse(txtID.Text);
                obj.GenerateDate = dtGenerate.Value;
                obj.SalaryMonth = dtSalaryMonth.Value;
                obj.DepartmentID = vDept;

                if (vDesig > 0) obj.DesignationID = vDesig;
                if (vShift > 0) obj.ShiftID = vShift;

                obj.TotalSalary = vTotalSalary;
                obj.Remarks = txtRemarks.Text.Trim();
                obj.UserID = vUserID;

                if (!vOpenMode)
                {
                    //Insert                     
                    DataTable dt = objDAL.InsertRecord(obj);
                    obj.SalaryID = Int64.Parse(dt.Rows[0]["SalaryID"].ToString());
                }
                else
                {
                    // UPdate 
                    objDAL.DeleteRecordBody(obj.SalaryID);
                    objDAL.UpdateRecord(obj);
                }


                //Save Detail
                foreach (DataGridViewRow dr in GridBody.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        Objects.SalaryBody objBody = new Objects.SalaryBody();
                        objBody.SalaryID = obj.SalaryID;
                        objBody.EmployeeID = Int64.Parse(dr.Cells["EmployeeID"].Value.ToString());
                        objBody.Presents = decimal.Parse(dr.Cells["Presents"].Value.ToString());
                        objBody.Leaves = decimal.Parse(dr.Cells["Leaves"].Value.ToString());

                        decimal vBasic, vAll, vBonus, vDeduct, vNet;

                        decimal.TryParse(dr.Cells["BasicSalary"].Value.ToString(), out vBasic);
                        decimal.TryParse(dr.Cells["Allowances"].Value.ToString(), out vAll);
                        decimal.TryParse(dr.Cells["Bonus"].Value.ToString(), out vBonus);
                        decimal.TryParse(dr.Cells["Deduction"].Value.ToString(), out vDeduct);
                        decimal.TryParse(dr.Cells["NetSalary"].Value.ToString(), out vNet);
                        
                        objBody.BasicSalary = vBasic;
                        objBody.Allowances = vAll;
                        objBody.Bonus = vBonus;
                        objBody.Deduction = vDeduct;
                        objBody.NetSalary = vNet;

                        objDAL.InsertRecordBody(objBody);

                    }
                }

                Message.ShowMessage(MyMessages.MessageType.SaveRecord);
                LoadGrid();
                btnClear_Click(sender, e);


            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }
        #endregion

        private void SalaryGenerate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                btnDelete_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                btnClose_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                //btnPrint_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                btnClear_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                btnSwitch_Click(null, null);
            }
        }

       

       

        

       













    }

}
