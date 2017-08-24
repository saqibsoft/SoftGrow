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
    public partial class BalanceTransfer : Form
    {
        public BalanceTransfer()
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

            if (txtPassword.Text.ToUpper() != "PANTHERSOFTGO")
            {
                MessageBox.Show("Incorrect Password!!!");
                txtPassword.Focus();
                return;
            }

            if (txtToDatabase.Text == string.Empty)
            {
                MessageBox.Show("Data Base Name Missing???");
                txtPassword.Focus();
                return;
            }

            try
            {
                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                

                DAL.Reports objDAL = new DAL.Reports();
                objDAL.connectionstring = connectionstring;

                 DataTable dt = objDAL.getTrialBalance( DateTime.Now.Date.ToShortDateString());

                
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Display", "No Data");
                    return;
                }

                DAL.Misc dal = new DAL.Misc();
                dal.connectionstring = objDAL.connectionstring;

                decimal vNetSaleVal = dal.getNetSalesValue("01/01/2000", DateTime.Now.Date.ToShortDateString());
                decimal vNetPurVal = dal.getNetPurchaseValue("01/01/2000", DateTime.Now.Date.ToShortDateString());

                decimal vTTLExp = 0, vTTLRev = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["AccountType"].ToString() == "EXPENSE")
                    {
                        vTTLExp += decimal.Parse(dr["Debit"].ToString());
                    }
                    if (dr["AccountType"].ToString() == "REVENUE")
                    {
                        vTTLRev += decimal.Parse(dr["Credit"].ToString());
                    }
                }

                decimal vOpStockVal = dal.getOpeningStockValue(string.Empty);

                DataTable dTemp = objDAL.getCurrentStock(string.Empty);

                decimal vCSValue = 0;

                foreach (DataRow dr in dTemp.Rows)
                {
                    decimal vCurrentStockVal = (decimal)dr["Value"];
                    decimal vNetQty = (decimal)dr["Qty"];
                    decimal vDeducted = (decimal)dr["LessQty"];

                    decimal vCSRate = vCurrentStockVal / (vNetQty + vDeducted);
                    vCSValue += (vNetQty * vCSRate);
                }

                decimal vAdjustment = 0;
                decimal.TryParse(txtBalAdjust.Text, out vAdjustment);

                decimal vPLS = (vNetSaleVal - (vNetPurVal + vOpStockVal - vCSValue)) - vTTLExp + vTTLRev + vAdjustment;

                

                connectionstring =string.Format("Data Source=(local);Initial Catalog={0};Trusted_Connection=YES;",txtToDatabase.Text);
                DAL.Database obj = new DAL.Database(connectionstring);

                obj.ExecuteNonQueryOnly("update AccountChart set OpeningCredit = 0 , OpeningDebit=0");

                foreach (DataRow drX in dt.Rows)
                {
                    if (drX["AccountType"].ToString() == "ASSET" || drX["AccountType"].ToString() == "LIABILITY")
                    {
                        string vQuery = string.Format(" Update AccountChart Set OpeningDebit={0}, OpeningCredit={1} Where AccountNo='{2}'"
                            , drX["Debit"].ToString(), drX["Credit"].ToString(), drX["AccountNo"].ToString());

                        obj.ExecuteNonQueryOnly(vQuery);
                    }
                    else if (drX["AccountType"].ToString() == "CAPITAL")
                    {
                        string vQuery = string.Format(" Update AccountChart Set OpeningDebit={0}, OpeningCredit={1} Where AccountNo='{2}'"
                            , drX["Debit"].ToString(), (decimal.Parse(drX["Credit"].ToString())+vPLS).ToString(), drX["AccountNo"].ToString());

                        obj.ExecuteNonQueryOnly(vQuery);
                    }
                }

                DataTable dt2 = objDAL.getCurrentStock(string.Empty);
                foreach (DataRow drX in dt2.Rows)
                {
                    string vQuery = string.Format(" Update Products Set OpeningStock={0}, OpeningStockValue={1} Where ProductID='{2}'"
                        , drX["Qty"].ToString(),
                      (decimal.Parse(drX["Qty"].ToString()) * (decimal.Parse(drX["Value"].ToString()) / (decimal.Parse(drX["Qty"].ToString()) + decimal.Parse(drX["LessQty"].ToString())))).ToString("G29"),
                        drX["ProductID"].ToString());

                    obj.ExecuteNonQueryOnly(vQuery);
                }


                MessageBox.Show("Balance Transfer Successfull.");
                txtToDatabase.Text = string.Empty;
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
            txtToDatabase.Text = string.Empty;
        }

        private void BalanceTransfer_Load(object sender, EventArgs e)
        {
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
        }
    }
}
