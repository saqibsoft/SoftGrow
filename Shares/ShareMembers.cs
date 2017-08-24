using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace SoftGrow.Shares
{
    public partial class ShareMembers : Form
    {
        DAL.ShareMembers objDAL = new DAL.ShareMembers();
        MyMessages Message = new MyMessages();
        bool vOpenMode = false;

        public ShareMembers()
        {
            InitializeComponent();
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
                txtOccupation.Text = string.Empty;
                txtVillage.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtPropertyDetail.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtRemarks.Text = string.Empty;
                imgLogo.Image = null;
                                
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
                    vWhere = " AND MemberName Like '%" + txtFilter.Text + "%'";
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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["MemberID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND MemberID=" + txtID.Text);
                    dtRegisterDate.Value = Convert.ToDateTime(dt.Rows[0]["RegistrationDate"].ToString());
                    txtName.Text = dt.Rows[0]["MemberName"].ToString();
                    txtFatherName.Text = dt.Rows[0]["FatherName"].ToString();
                    txtCNIC.Text = dt.Rows[0]["CNINCNo"].ToString();
                    txtContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                    txtCity.Text = dt.Rows[0]["CityName"].ToString();
                    txtVillage.Text = dt.Rows[0]["VillageName"].ToString();
                    txtOccupation.Text = dt.Rows[0]["Occupation"].ToString();

                    txtPropertyDetail.Text = dt.Rows[0]["PropertDetail"].ToString();
                    txtAddress.Text = dt.Rows[0]["PostalAddress"].ToString();
                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();

                    txtID.Tag = dt.Rows[0]["AccountID"].ToString();

                    if (dt.Rows[0]["PartyPic"].ToString() != string.Empty)
                    {

                        Byte[] byteBLOBData = new Byte[0];

                        byteBLOBData = (Byte[])(dt.Rows[0]["MemberPic"]);

                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        stmBLOBData.Seek(0, SeekOrigin.Begin);

                        imgLogo.Image = Image.FromStream(stmBLOBData);
                    }
                    else
                    {
                        imgLogo.Image = null;
                    }
                    

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
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            opDialog.FileName = string.Empty;
            DialogResult result = opDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (File.Exists(opDialog.FileName))
                {
                    imgLogo.Load(opDialog.FileName);
                    imgLogo.Tag = opDialog.FileName;                    
                }
            }   
        }
        private void btnClearPic_Click(object sender, EventArgs e)
        {
            imgLogo.Image = null;
        }
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

                //Delete Account
                var AccDAL = new DAL.AccountChart();
                AccDAL.connectionstring = objDAL.connectionstring;
                AccDAL.DeleteRecord(txtID.Tag.ToString());

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
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Enter Party Name.");
                    txtName.Focus();
                    return;
                }


                Objects.ShareMembers obj = new Objects.ShareMembers();
                obj.MemberID = Int64.Parse(txtID.Text);
                obj.RegistrationDate = dtRegisterDate.Value;
                obj.MemberName = txtName.Text.Trim();
                obj.FatherName = txtFatherName.Text.Trim();
                obj.ContactNo = txtContactNo.Text.Trim();
                obj.CNINCNo = txtCNIC.Text.Trim();
                obj.Occupation = txtOccupation.Text.Trim();
                obj.VillageName = txtVillage.Text.Trim();
                obj.CityName = txtCity.Text.Trim();

                obj.PostalAddress = txtAddress.Text.Trim();
                obj.PropertDetail = txtPropertyDetail.Text.Trim();
                obj.Remarks = txtRemarks.Text.Trim();
                
                obj.AccountNo = txtID.Tag.ToString();

                
                if (imgLogo.Image != null)
                {

                    MemoryStream ms = new MemoryStream();
                    imgLogo.Image.Save(ms, imgLogo.Image.RawFormat);
                    byte[] arrayImage = ms.GetBuffer();


                    obj.MemberPic = arrayImage;
                }

                //Insert Account
                var AccDAL = new DAL.AccountChart();
                AccDAL.connectionstring = objDAL.connectionstring;

                if (!vOpenMode)
                {

                    

                    Objects.AccountChart objAcc = new Objects.AccountChart();
                    objAcc.AccountNo = AccDAL.getNextNo("ASSET").ToString();
                    objAcc.AccountTitle = obj.MemberName;
                    objAcc.AccountType = "ASSET";
                    objAcc.AccountSubType = "Member";
                    objAcc.IsParty = true;
                    objAcc.IsBank = false;
                    objAcc.OpeningDebit = 0;
                    objAcc.OpeningCredit = 0;

                    AccDAL.InsertRecord(objAcc);

                    //Insert 
                    //obj.MemberID = objDAL.getNextNo();
                    obj.AccountNo = objAcc.AccountNo;

                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate Account
                    Objects.AccountChart objAcc = new Objects.AccountChart();
                    objAcc.AccountNo = obj.AccountNo;
                    objAcc.AccountTitle = obj.MemberName;
                    objAcc.AccountType = "ASSET";
                    objAcc.AccountSubType = "Member";
                    objAcc.IsParty = true;
                    objAcc.IsBank = false;
                    objAcc.OpeningDebit = 0;
                    objAcc.OpeningCredit = 0;

                    AccDAL.UpdateRecord(objAcc);

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
