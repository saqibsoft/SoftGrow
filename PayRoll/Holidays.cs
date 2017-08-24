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
    public partial class Holidays : Form
    {
        DAL.Holidays objDAL = new DAL.Holidays();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;
        int vUserID;
        public Holidays(int userid)
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
                txtReason.Text = string.Empty;                

                vOpenMode = false;
                Grid.Enabled = false;
                dtFilterMonth.Enabled = false;
                dtFilterMonth.Value = DateTime.Today;
                txtReason.Focus();
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
                vWhere =string.Format(" AND Month(HolidayDate)={0} AND Year(HolidayDate)={1}",dtFilterMonth.Value.Month,dtFilterMonth.Value.Year);

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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["HolidayID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND HolidayID=" + txtID.Text);
                    dtHolidayDate.Value = Convert.ToDateTime(dt.Rows[0]["HolidayDate"].ToString());
                    txtReason.Text = dt.Rows[0]["Reason"].ToString();                                                           
                   

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
                                                
                objDAL.DeleteRecord(int.Parse(txtID.Text));
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
                //if (txtReason.Text.Trim() == string.Empty)
                //{
                //    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Name.");
                //    txtReason.Focus();
                //    return;
                //}


                DataTable dt = new DataTable();

                if (!vOpenMode)
                {
                    dt = objDAL.getRecord(string.Format(" AND (convert(datetime,Convert(varchar,HolidayDate,1)) = Convert(Datetime,(convert(varchar,convert(Datetime,'{0} 00:00:00',102),1))))", dtHolidayDate.Value.ToShortDateString()));
                    if (dt.Rows.Count > 0)
                    {

                        Message.ShowMessage(MyMessages.MessageType.General, "Holiday Already Entered.");
                        return;
                    }
                }
                else
                {
                    dt = objDAL.getRecord(string.Format(" AND (convert(datetime,Convert(varchar,HolidayDate,1)) = Convert(Datetime,(convert(varchar,convert(Datetime,'{0} 00:00:00',102),1)))) AND HolidayID<>{1}", dtHolidayDate.Value.ToShortDateString(),txtID.Text));
                    if (dt.Rows.Count > 0)
                    {

                        Message.ShowMessage(MyMessages.MessageType.General, "Holiday Already Entered.");
                        return;
                    }
                }


                Objects.Holidays obj = new Objects.Holidays();
                obj.HolidayID = Int64.Parse(txtID.Text);
                obj.HolidayDate = dtHolidayDate.Value;
                obj.Reason = txtReason.Text.Trim();
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

        private void dtFilterMonth_ValueChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void Holidays_KeyDown(object sender, KeyEventArgs e)
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
