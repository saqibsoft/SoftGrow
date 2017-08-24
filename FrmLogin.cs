using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DAL.Users objDAL = new DAL.Users();        

        private void Form1_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            Omni.MyGlobal omni = new Omni.MyGlobal();
            omni.MyConString = objDAL.connectionstring;
            omni.Authentication();



            label1.Parent = this;
            label1.BackColor = Color.Transparent;

            label2.Parent = this;
            label2.BackColor = Color.Transparent;

            
            

            //if (DateTime.Now.Month != 10)
            //{
            //    MessageBox.Show("Please Contact Software vendor for further Assistance....", "License Expired");
            //    btnClose_Click(null, null);
            //}
        }

        private void btnLogin_Click(object sender, EventArgs e)
        
        {
            try
            {
                 string vMessage=string.Empty;

                if (txtUserName.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Enter User Name First.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtUserName.Focus();
                    return;
                }

                if (txtPassword.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Enter Password First.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtUserName.Focus();
                    return;
                }

                DataTable dt = objDAL.getRecord(string.Format(@" AND UserName='{0}' AND Password='{1}'",this.txtUserName.Text,this.txtPassword.Text));

                if (dt.Rows.Count == 0)
                {
                    vMessage = "Incorrect User Name and Password.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Invalid Information");
                    txtUserName.Focus();
                    return;
                }
                else
                {
                    FrmMain vForm = new FrmMain();
                    vForm.UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                    vForm.UserName = dt.Rows[0]["UserName"].ToString();
                    vForm.IsAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"].ToString());
                    vMessage = "Welcome " + vForm.UserName;
                    new Speak().SayIt(vMessage);

                    vForm.Show();
                    this.Hide();
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GoToNextCont(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
