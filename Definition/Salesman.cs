using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Definition
{
    public partial class Salesman : Form
    {
        DAL.Employees objDAL = new DAL.Employees();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;
        int vUserID;

        public Salesman(int useid)
        {
            InitializeComponent();
            vUserID = useid;
        }
        private void PartiesInfo_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
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

                cboDesignation.DataSource = dt;
                cboDesignation.ValueMember = "DesignationID";
                cboDesignation.DisplayMember = "DesignationTitle";


                DAL.Shifts objS = new DAL.Shifts();
                objS.connectionstring = objDAL.connectionstring;
                dt = objS.getRecord(string.Empty);

                cboShift.DataSource = dt;
                cboShift.ValueMember = "ShiftID";
                cboShift.DisplayMember = "ShiftTitle";


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

        }
        #endregion

        #region // Control Operations
        private void ClearFields()
        {
            try
            {
                txtID.Text = objDAL.getNextNo().ToString();
                txtID.Tag = string.Empty;
                txtName.Text = string.Empty;
                txtFatherName.Text = string.Empty;
                txtCNIC.Text = string.Empty;
                txtContactNo.Text = string.Empty;
                dtJoiningDate.Value = DateTime.Now.Date;
                txtAddress.Text = string.Empty;
                chkInActive.Checked = chkSalesman.Checked = false;
                txtBasicSalary.Text = string.Empty;

                vOpenMode = false;
                Grid.Enabled = false;
                txtFilter.Text = string.Empty;
                txtFilter.Enabled = false;
                txtName.Focus();
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
        #endregion

        #region // Grid Operations
        private void LoadGrid()
        {
            try
            {
                //Grid.Rows.Clear();
                string vWhere = string.Empty;
                if (!string.IsNullOrEmpty(txtFilter.Text))
                {
                    vWhere = " AND EmployeeName Like '%" + txtFilter.Text + "%'";
                }

                DataTable dt = objDAL.getRecord(vWhere);
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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["EmployeeID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND Employees.EmployeeID=" + txtID.Text);

                    txtID.Tag  = dt.Rows[0]["AccountNo"].ToString();
                    txtName.Text = dt.Rows[0]["EmployeeName"].ToString();
                    txtFatherName.Text = dt.Rows[0]["FatherName"].ToString();
                    txtCNIC.Text = dt.Rows[0]["CNIC"].ToString();
                    txtContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                    dtJoiningDate.Value = Convert.ToDateTime( dt.Rows[0]["JoiningDate"].ToString());

                    if (!string.IsNullOrEmpty(dt.Rows[0]["BasicSalary"].ToString()))
                    {
                        txtBasicSalary.Text = decimal.Parse(dt.Rows[0]["BasicSalary"].ToString()).ToString("G29");
                    }
                    else txtBasicSalary.Text = string.Empty;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["IsSalesman"].ToString()))
                    {
                        chkSalesman.Checked = Convert.ToBoolean(dt.Rows[0]["IsSalesman"].ToString());
                    }
                    else chkSalesman.Checked = false;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["InActive"].ToString()))
                    {
                        chkInActive.Checked = Convert.ToBoolean(dt.Rows[0]["InActive"].ToString());
                    }
                    else chkInActive.Checked = false;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["DepartmentID"].ToString()))
                    {
                        cboDepartment.SelectedValue = dt.Rows[0]["DepartmentID"].ToString();
                        cboDepartment.SelectedText = dt.Rows[0]["DepartmentTitle"].ToString();
                    }
                    else
                        cboDepartment.SelectedIndex = -1;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["DesignationID"].ToString()))
                    {
                        cboDesignation.SelectedValue = dt.Rows[0]["DesignationID"].ToString();
                        cboDesignation.SelectedText = dt.Rows[0]["DesignationTitle"].ToString();
                    }
                    else
                        cboDesignation.SelectedIndex = -1;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["ShiftID"].ToString()))
                    {
                        cboShift.SelectedValue = dt.Rows[0]["ShiftID"].ToString();
                        cboShift.SelectedText = dt.Rows[0]["ShiftTitle"].ToString();
                    }
                    else
                        cboShift.SelectedIndex = -1;

                    txtAddress.Text = dt.Rows[0]["Address"].ToString();                    

                   

                    vOpenMode = true;
                }
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);                
            }
        }
        #endregion

        #region // Buttons Click
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
            txtFilter.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                if (!Message.ConfrmDelMsg()) return;                               
                
                objDAL.DeleteRecord(Int64.Parse(txtID.Text));

                if (!string.IsNullOrEmpty(txtID.Tag.ToString()))
                {
                    DAL.AccountChart obj = new DAL.AccountChart();
                    obj.connectionstring = objDAL.connectionstring;
                    obj.DeleteRecord(txtID.Tag.ToString());
                }

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
                if (txtName.Text.Trim() == string.Empty)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Name.");
                    txtName.Focus();
                    return;
                }

                int vDeptID,vDesgID,vShiftID;

                if (cboDepartment.SelectedIndex != -1)
                {
                    int.TryParse(cboDepartment.SelectedValue.ToString(), out vDeptID);
                }
                else
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Select Department.");
                    cboDepartment.Focus();
                    return;
                }

                if (cboDesignation.SelectedIndex != -1)
                {
                    int.TryParse(cboDesignation.SelectedValue.ToString(), out vDesgID);
                }
                else
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Select Designation.");
                    cboDesignation.Focus();
                    return;
                }

                if (cboShift.SelectedIndex != -1)
                {
                    int.TryParse(cboShift.SelectedValue.ToString(), out vShiftID);
                }
                else
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Select Shift.");
                    cboShift.Focus();
                    return;
                }


                decimal vBasicSalary=0;
                decimal.TryParse(txtBasicSalary.Text, out vBasicSalary);


                Objects.Employees obj = new Objects.Employees();
                obj.EmployeeID = Int32.Parse(txtID.Text);
                obj.EmployeeName = txtName.Text.Trim();
                obj.FatherName = txtFatherName.Text.Trim();
                obj.CNIC = txtCNIC.Text.Trim();
                obj.ContactNo = txtContactNo.Text.Trim();
                obj.DepartmentID = vDeptID;
                obj.DesignationID = vDesgID;
                obj.ShiftID = vShiftID;
                obj.JoiningDate = dtJoiningDate.Value;
                obj.BasicSalary = vBasicSalary;
                obj.Address = txtAddress.Text.Trim();
                obj.AccountNo = txtID.Tag.ToString();
                obj.InActive = chkInActive.Checked;
                obj.IsSalesman = chkSalesman.Checked;
                obj.UserID = vUserID;


                //Insert Account
                var AccDAL = new DAL.AccountChart();
                AccDAL.connectionstring = objDAL.connectionstring;
                Objects.AccountChart objAcc = new Objects.AccountChart();
                objAcc.AccountNo = obj.AccountNo;
                objAcc.AccountTitle = obj.EmployeeName;
                objAcc.AccountType = "LIABILITY";
                objAcc.AccountSubType = "Employee";
                objAcc.IsParty = false;
                objAcc.IsBank = false;
                objAcc.OpeningDebit = 0;
                objAcc.OpeningCredit = 0;


                if (!vOpenMode)
                {




                    objAcc.AccountNo = AccDAL.getNextNo("LIABILITY").ToString();
                    AccDAL.InsertRecord(objAcc);                    

                    //Insert Party
                    obj.EmployeeID = objDAL.getNextNo();
                    obj.AccountNo = objAcc.AccountNo;

                    objDAL.InsertRecord(obj);
                }
                else
                {
                    if (!string.IsNullOrEmpty(objAcc.AccountNo))
                    {
                        // UPdate  Account                                        
                        AccDAL.UpdateRecord(objAcc);
                    }
                    else
                    {
                        objAcc.AccountNo = AccDAL.getNextNo("LIABILITY").ToString();
                        AccDAL.InsertRecord(objAcc);
                        obj.AccountNo = objAcc.AccountNo;
                    }

                    objDAL.UpdateRecord(obj);
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

        

        

        

        
       
        

        
    }

}
