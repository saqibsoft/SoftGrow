using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Text.RegularExpressions;namespace SoftGrow.Tools
{
    public partial class ScriptRunner : Form
    {
        public ScriptRunner()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password Missing???");
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text.ToUpper() != "PANTHERSOFT")
            {
                MessageBox.Show("Incorrect Password!!!");
                txtPassword.Focus();
                return;
            }

            if (txtScript.Text == string.Empty)
            {
                MessageBox.Show("No Script found!!!");
                txtScript.Focus();
                return;
            }

            try
            {
                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DAL.Database obj = new DAL.Database(connectionstring);


                string script = txtScript.Text;

                // split script on GO command
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);
                
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        obj.ExecuteNonQueryOnly(commandString);                        
                    }
                }
                

                MessageBox.Show("Script Run Successfull.");
                txtScript.Text = string.Empty;
            }
            catch (Exception exc)
            {
                
                MessageBox.Show(exc.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScript.Text = string.Empty;
        }
    }
}
