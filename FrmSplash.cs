using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.IO;
using System.Net.NetworkInformation;
using System.Management;

namespace SoftGrow
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        public static string Decrypt(string input)
        {
            string encryptedText = input;

            encryptedText = encryptedText.Replace("*1*2*", "+");

            return (Encryption.Decrypt(encryptedText));
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                // Wait 100 milliseconds.
                //Thread.Sleep(30);
                // Report progress.
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            PGStatus.Value = e.ProgressPercentage;
            // Set the text.
            //this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            Form vForm = new FrmMain();            
            vForm.Show();
            this.Hide();
            
        }
        DAL.Reports objDAL = new DAL.Reports();
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            try
            {
               
               
                //Cursor.Current = Cursors.WaitCursor;
                //// Start the BackgroundWorker.
                //backgroundWorker1.RunWorkerAsync();
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                Omni.MyGlobal omni = new Omni.MyGlobal();
                omni.MyConString = objDAL.connectionstring;
                omni.Authentication();
                string vWhere = " AND PartyID=0";
                Reports.RptReportViewer cForm = new Reports.RptReportViewer();
                DataTable dt = objDAL.getPartiesList(vWhere);
                //if (dt.Rows.Count == 0)
                //{
                //    MessageBox.Show("No Data To Display", "No Data");
                //    return;
                //}
                cForm.ShowReport("PARTIES LIST", dt);


                //if (File.Exists("Regd.txt"))
                //{
                //    //Get Mac Address
                //    //string mac = "";

                //    //// Win32_CPU will work too
                //    //var search = new ManagementObjectSearcher("SELECT * FROM Win32_baseboard");
                //    //var mobos = search.Get();

                //    //foreach (var m in mobos)
                //    //{
                //    //    mac += m["SerialNumber"]; // ProcessorID if you use Win32_CPU
                //    //}

                //    ////Get Reg Code
                //    //StreamReader sr = new StreamReader("Regd.txt");
                //    //string vTemp = sr.ReadToEnd();

                //    //string vCode = Decrypt(vTemp);
                //    //string vVersion = vCode.Substring(0, 3);
                //    //vCode = vCode.Substring(3, vCode.Length - 7);
                   
                  

                //    //if (mac != vCode)
                //    //{
                //    //    MessageBox.Show("Product Not Registered. Contact\r\n\n Panthersoft (panthersoft@ymail.com) For Assistance!", "Registration Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    //    Close();
                //    //}
                //    //else
                //    //{
                //    //    //Cursor.Current = Cursors.WaitCursor;
                //    //    // Start the BackgroundWorker.
                //    //    //backgroundWorker1.RunWorkerAsync();
                //    //    timer1.Enabled = true;
                //    //}

                //    timer1.Enabled = true;
                //}
                //else
                //{
                //    MessageBox.Show("Registration File Not Found.", "Registration Missing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    Close();
                //}
                timer1.Enabled = true;
            }
            catch (Exception exc)
            {
                
                MessageBox.Show("Error:" + exc.Message);
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            FrmLogin vForm = new FrmLogin();
            vForm.Show();

            timer1.Enabled = false;
            this.Hide();
        }
    }
}
