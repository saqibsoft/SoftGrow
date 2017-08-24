using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftGrow.Tools
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        DAL.Settings objDAL = new DAL.Settings();

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

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
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
        private int CheckIsNumeric(int vKey)
        {
            int rKey = vKey;
            if ((vKey > 57 || vKey < 48) && vKey != 8)
            {
                rKey = 0;
            }
            return rKey;
        }        
        #endregion

        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            LoadSettings();            
        }

        private void LoadSettings()
        {
            try
            {
                //txtCashAccTitle.Text = objDAL.GetSettingValue(DAL.Settings.ProSettings.CashAccTitle);
                //txtOpDebit.Text  = objDAL.GetSettingValue(DAL.Settings.ProSettings.OpCashDebit);
                //txtOpCredit.Text = objDAL.GetSettingValue(DAL.Settings.ProSettings.OpCashCredit);
                //chkAutoPost.Checked = Convert.ToBoolean(objDAL.GetSettingValue(DAL.Settings.ProSettings.IsAutoPost));
                //chkVoiceMsg.Checked = Convert.ToBoolean(objDAL.GetSettingValue(DAL.Settings.ProSettings.MsgSounds));
                //chkMinToSysTry.Checked = Convert.ToBoolean(objDAL.GetSettingValue(DAL.Settings.ProSettings.MinToTry));
                txtAccountNo.Text = objDAL.GetSettingValue(DAL.Settings.ProSettings.SalaryExpAcc);
                txtAccIssue.Text = objDAL.GetSettingValue(DAL.Settings.ProSettings.SampleIssuance);
                txtAccWaste.Text = objDAL.GetSettingValue(DAL.Settings.ProSettings.ProductWastage);

                if (!string.IsNullOrEmpty(txtAccountNo.Text))
                {
                    DAL.AccountChart obj = new DAL.AccountChart();
                    obj.connectionstring = objDAL.connectionstring;
                    DataTable dt = obj.getRecord(" AND ACCOUNTNO='" + txtAccountNo.Text + "'");
                    txtAccountName.Text = dt.Rows[0]["AccountTitle"].ToString();

                    DataTable dt1 = obj.getRecord(" AND ACCOUNTNO='" + txtAccIssue.Text + "'");
                    if(dt1.Rows.Count > 0)
                    {
                    txtAccNameIssue.Text = dt1.Rows[0]["AccountTitle"].ToString();
                    }
                    DataTable dt2 = obj.getRecord(" AND ACCOUNTNO='" + txtAccWaste.Text + "'");
                    if (dt2.Rows.Count > 0)
                    {
                        txtAccNameWaste.Text = dt2.Rows[0]["AccountTitle"].ToString();
                    }
                    dt.Dispose();
                }
                else
                    txtAccountName.Text = string.Empty;


                //cboUsers.SelectedIndex = -1;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage=string.Empty;

                //if (txtCashAccTitle.Text.Trim() == string.Empty)
                //{
                //    vMessage = "Please Enter Cash Account Title.";
                //    new Speak().SayIt(vMessage);
                //    MessageBox.Show(vMessage, "Information Missing");
                //    txtCashAccTitle.Focus();
                //    return;
                //}

                //objDAL.SetSettingValue(DAL.Settings.ProSettings.CashAccTitle,txtCashAccTitle.Text);

                //Int64 vTemp = 0;

                //Int64.TryParse(this.txtOpDebit.Text, out vTemp);
                //objDAL.SetSettingValue(DAL.Settings.ProSettings.OpCashDebit, vTemp.ToString());

                //Int64.TryParse(this.txtOpCredit.Text, out vTemp);
                //objDAL.SetSettingValue(DAL.Settings.ProSettings.OpCashCredit, vTemp.ToString());

                //if (chkAutoPost.Checked)
                //{
                //    objDAL.SetSettingValue(DAL.Settings.ProSettings.IsAutoPost, "true");
                //}
                //else objDAL.SetSettingValue(DAL.Settings.ProSettings.IsAutoPost, "false");

                //if (chkVoiceMsg.Checked)
                //{
                //    objDAL.SetSettingValue(DAL.Settings.ProSettings.MsgSounds, "true");
                //}
                //else objDAL.SetSettingValue(DAL.Settings.ProSettings.MsgSounds, "false");

                //if (chkMinToSysTry.Checked)
                //{
                //    objDAL.SetSettingValue(DAL.Settings.ProSettings.MinToTry, "true");
                //}
                //else objDAL.SetSettingValue(DAL.Settings.ProSettings.MinToTry, "false");                                

                if(!string.IsNullOrEmpty(txtAccountName.Text))
                {
                    objDAL.SetSettingValue(DAL.Settings.ProSettings.SalaryExpAcc, txtAccountNo.Text);
                }
                else
                {
                    objDAL.SetSettingValue(DAL.Settings.ProSettings.SalaryExpAcc, string.Empty);
                }
                ///////////////////-----------------
                if (!string.IsNullOrEmpty(txtAccNameIssue.Text))
                {
                    objDAL.SetSettingValue(DAL.Settings.ProSettings.SampleIssuance, txtAccIssue.Text);
                }
                else
                {
                    objDAL.SetSettingValue(DAL.Settings.ProSettings.SampleIssuance, string.Empty);
                }
                //-////////////////////////--------------------------------------------------------
                if (!string.IsNullOrEmpty(txtAccNameWaste.Text))
                {
                    objDAL.SetSettingValue(DAL.Settings.ProSettings.ProductWastage, txtAccWaste.Text);
                }
                else
                {
                    objDAL.SetSettingValue(DAL.Settings.ProSettings.ProductWastage, string.Empty);
                }

                vMessage = "Settings Saved Successfully.";
                new Speak().SayIt(vMessage);
                MessageBox.Show(vMessage, "Confirmation");
                txtCashAccTitle.Focus();

            }
            catch (Exception exc)
            {                
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNo.Text))
            {
                txtAccountName.Text = string.Empty;
            }
        }
        private void txtAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchAccounts vForm = new Search.SchAccounts();

                //if (getVoucherType() == "JV") vForm.IsJV = true;

                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtAccountNo.Text = vForm.MyID;
                    txtAccountName.Text = vForm.MyName;                    
                }
            }            
        }
        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchAccounts vForm = new Search.SchAccounts();

                //if (getVoucherType() == "JV") vForm.IsJV = true;

                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtAccIssue.Text = vForm.MyID;
                    txtAccNameIssue.Text = vForm.MyName;
                }
            }    
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.SchAccounts vForm = new Search.SchAccounts();

                //if (getVoucherType() == "JV") vForm.IsJV = true;

                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtAccWaste.Text = vForm.MyID;
                    txtAccNameWaste.Text = vForm.MyName;
                }
            }    
        }

        private void txtAccIssue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccIssue.Text))
            {
                txtAccNameIssue.Text = string.Empty;
            }
        }

        private void txtAccWaste_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccWaste.Text))
            {
                txtAccNameWaste.Text = string.Empty;
            }
        }
    }
}
