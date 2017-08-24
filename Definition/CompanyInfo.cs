using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;




namespace SoftGrow.Definition
{
    public partial class CompanyInfo : Form
    {
        DAL.CompanyInfo objDAL = new DAL.CompanyInfo();
        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {            
            objDAL.connectionstring =System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            LoadRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage = string.Empty;
                if (txtName.Text.Trim()  == string.Empty)
                {
                    vMessage = "Please Insert Company Name!";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtName.Focus();
                    return;
                }

                Objects.CompanyInfo obj = new Objects.CompanyInfo();
                obj.CompanyName = txtName.Text.Trim();
                obj.Phone = txtPhone.Text.Trim();
                obj.Web = txtWeb.Text.Trim();
                obj.Address = txtAddress.Text.Trim();

                

                if (imgLogo.Image != null)
                {

                    MemoryStream ms = new MemoryStream();
                     imgLogo.Image.Save(ms, imgLogo.Image.RawFormat);
                    byte[] arrayImage = ms.GetBuffer();
                    

                    obj.Logo = arrayImage;
                }

                objDAL.DeleteRecord();
                objDAL.InsertRecord(obj);

                //ms.Close(); // Closes the Memory Stream

                vMessage = "Record Saved Successfully.";
                new Speak().SayIt(vMessage);
                MessageBox.Show(vMessage, "Task Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void LoadRecord()
        {
            try
            {
                DataTable dt = objDAL.getRecord();

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtName.Text = dr["CompanyName"].ToString();
                    txtPhone.Text = dr["Phone"].ToString();
                    txtWeb.Text = dr["Web"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    if (dr["ComapnyLogo"].ToString() != string.Empty)
                    {
                        //byte[] arrayImage = Encoding.ASCII.GetBytes(dr["ComapnyLogo"].ToString()); //Convert.FromBase64String(dr["ComapnyLogo"].ToString()); 
                        //MemoryStream ms = new MemoryStream(arrayImage);                        
                        //Image vPic =  Image.FromStream(ms);
                        //imgLogo.Image = vPic;

                        //MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["ComapnyLogo"]);
                        //imgLogo.Image = new Bitmap(ms);


                        Byte[] byteBLOBData = new Byte[0];

                        byteBLOBData = (Byte[])(dr["ComapnyLogo"]);

                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        stmBLOBData.Seek(0, SeekOrigin.Begin);

                        imgLogo.Image = Image.FromStream(stmBLOBData);
                    }
                }
            }
            catch ( Exception exc)
            {
                
                 MessageBox.Show(exc.Message.ToString(), "Error");
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            opDialog.ShowDialog();
            imgLogo.Load(opDialog.FileName);
            imgLogo.Tag = opDialog.FileName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            imgLogo.Image = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
