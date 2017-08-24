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
    public partial class DailyAttendance : Form
    {
        DAL.DailyAttendance objDAL = new DAL.DailyAttendance();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;
        int vUserID;
        public DailyAttendance(int userid)
        {
            InitializeComponent();
            vUserID = userid;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            LoadGrid();
            ClearFields();
        }

        #region // General Methods
        private void MoveNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void ForQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' ||  e.KeyChar == '\b') //The  character represents a backspace
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
                txtEmployeeID.Text = string.Empty;
                txtRemarks.Text = string.Empty;                

                vOpenMode = false;
                Grid.Enabled = false;
                dtFilterMonth.Enabled = false;
                dtFilterMonth.Value = DateTime.Today;
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
        private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

                try
                {
                    SearchForms.SchEmployee vForm = new SearchForms.SchEmployee();
                    vForm.ShowDialog();
                    if (!string.IsNullOrEmpty(vForm.MyID))
                    {
                        txtEmployeeID.Text = vForm.MyID;
                        txtEmployeeName.Text = vForm.MyName;

                        DAL.Employees obj = new DAL.Employees();
                        obj.connectionstring = objDAL.connectionstring;
                        DataTable dt = obj.getRecord(" AND Employees.EmployeeID=" + txtEmployeeID.Text);
                        if (dt.Rows.Count > 0)
                        {
                            txtDepartment.Text = dt.Rows[0]["DepartmentTitle"].ToString();
                            txtDesignation.Text = dt.Rows[0]["DesignationTitle"].ToString();
                            txtShift.Text = dt.Rows[0]["ShiftTitle"].ToString();
                        }
                        dtDateTime.Focus();
                    }
                }
                catch (Exception exc)
                {
                    Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
                }
            }
            else
            {
                MoveNext_KeyDown(sender, e);
            }
        }
        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                txtEmployeeName.Text = string.Empty;
                txtDepartment.Text = string.Empty;
                txtDesignation.Text = string.Empty;
                txtShift.Text = string.Empty;
            }

        }
        private void dtFilterMonth_ValueChanged(object sender, EventArgs e)
        {
            if(dtFilterMonth.Checked) LoadGrid();
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
                    vWhere = " AND Employees.EmployeeName Like '%" + txtFilter.Text + "%'";
                }
                if (dtFilterMonth.Checked)
                {
                    vWhere += string.Format(" AND (convert(datetime,Convert(varchar,DailyAttendance.AttendaceDateTime,1)) = Convert(Datetime,(convert(varchar,convert(Datetime,'{0} 00:00:00',102),1))))", dtFilterMonth.Value.ToShortDateString());
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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["AttendanceID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND DailyAttendance.AttendanceID=" + txtID.Text);

                    txtEmployeeID.Text = dt.Rows[0]["EmployeeID"].ToString();
                    txtEmployeeName.Text = dt.Rows[0]["EmployeeName"].ToString();
                    dtDateTime.Value = Convert.ToDateTime(dt.Rows[0]["AttendaceDateTime"].ToString());
                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();

                    DAL.Employees obj = new DAL.Employees();
                    obj.connectionstring = objDAL.connectionstring;
                    DataTable dt1 = obj.getRecord(" AND Employees.EmployeeID=" + txtEmployeeID.Text);
                    if (dt1.Rows.Count > 0)
                    {
                        txtDepartment.Text = dt1.Rows[0]["DepartmentTitle"].ToString();
                        txtDesignation.Text = dt1.Rows[0]["DesignationTitle"].ToString();
                        txtShift.Text = dt1.Rows[0]["ShiftTitle"].ToString();
                    }

                    dt1.Dispose();

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
            dtFilterMonth.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                if (!Message.ConfrmDelMsg()) return;
                                                
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
                if (txtEmployeeName.Text.Trim() == string.Empty)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Select an Employee first.");
                    txtEmployeeID.Focus();
                    return;
                }


                DataTable dt = new DataTable();

                if (!vOpenMode)
                {
                    dt = objDAL.getRecord(string.Format(" AND (convert(datetime,Convert(varchar,DailyAttendance.AttendaceDateTime,1)) = Convert(Datetime,(convert(varchar,convert(Datetime,'{0} 00:00:00',102),1)))) and Employees.EmployeeID={1}", dtDateTime.Value.ToShortDateString(), txtEmployeeID.Text));
                    if (dt.Rows.Count > 0)
                    {

                        Message.ShowMessage(MyMessages.MessageType.General, "Attendance Already Entered.");
                        return;
                    }
                }
                else
                {
                    dt = objDAL.getRecord(string.Format(" AND (convert(datetime,Convert(varchar,DailyAttendance.AttendaceDateTime,1)) = Convert(Datetime,(convert(varchar,convert(Datetime,'{0} 00:00:00',102),1)))) AND Employees.EmployeeID={1} AND DailyAttendance.AttendanceID<>{2}", dtDateTime.Value.ToShortDateString(),txtEmployeeID.Text,txtID.Text));
                    if (dt.Rows.Count > 0)
                    {
                        Message.ShowMessage(MyMessages.MessageType.General, "Attendance Already Entered.");
                        return;
                    }
                }


                Objects.DailyAttendance obj = new Objects.DailyAttendance();
                obj.AttendanceID = Int64.Parse(txtID.Text);
                obj.EmployeeID = Int64.Parse(txtEmployeeID.Text);
                obj.EntryDate = DateTime.Now;
                obj.AttendaceDateTime = dtDateTime.Value;
                obj.Remarks = txtRemarks.Text.Trim();
                obj.UserID = vUserID;

                if (!vOpenMode)
                {
                    //Insert                     
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate 
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

        private void DailyAttendance_KeyDown(object sender, KeyEventArgs e)
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
