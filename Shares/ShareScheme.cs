using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Shares
{
    public partial class ShareScheme : Form
    {
        DAL.ShareScheme objDAL = new DAL.ShareScheme();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;
        private int vUserID;

        public ShareScheme(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
        }
        private void PartiesInfo_Load(object sender, EventArgs e)
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
        private void ForNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
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
                txtName.Text = string.Empty;
                txtTotalShare.Text = "0";
                txtPerSharePrice.Text = "0";
                txtRemarks.Text = string.Empty;

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
                    vWhere = " AND SchemeTitle Like '%" + txtFilter.Text + "%'";
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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["SchemeID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND SchemeID=" + txtID.Text);
                    txtName.Text = dt.Rows[0]["SchemeTitle"].ToString();
                    dtEntryDate.Value = Convert.ToDateTime(dt.Rows[0]["EntryDate"].ToString());
                    txtTotalShare.Text = dt.Rows[0]["TotalShares"].ToString();

                    decimal vPerShare = 0;
                    decimal.TryParse(dt.Rows[0]["PerShareValue"].ToString(), out vPerShare);

                    txtPerSharePrice.Text = vPerShare.ToString("G29");

                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
                   

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
                if (txtName.Text.Trim() == string.Empty)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Unit Title.");
                    txtName.Focus();
                    return;
                }

                int vShares = 0;
                int.TryParse(txtTotalShare.Text, out vShares);

                decimal vPerShare = 0;
                decimal.TryParse(txtPerSharePrice.Text, out vPerShare);

                if (vShares == 0)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Total Number of Shares.");
                    txtTotalShare.Focus();
                    return;
                }


                Objects.ShareScheme obj = new Objects.ShareScheme();
                obj.SchemeID = int.Parse(txtID.Text);
                obj.SchemeTitle = txtName.Text.Trim();
                obj.EntryDate = dtEntryDate.Value;
                obj.TotalShares = vShares;
                obj.PerShareValue = vPerShare;
                obj.Remarks = txtRemarks.Text;
                obj.UserID = vUserID;

                if (!vOpenMode)
                {                                        
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

        

        

        

        
       
        

        
    }

}
