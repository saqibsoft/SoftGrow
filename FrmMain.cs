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
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        public int vUserID;
        private string vUserName;
        private bool vIsAdmin;

        public int UserID
        {
            get { return vUserID; }
            set { vUserID = value; }
        }

        public bool IsAdmin
        {
            get { return vIsAdmin; }
            set { vIsAdmin = value; }
        }

        public string UserName
        {
            get { return vUserName; }
            set { vUserName = value; }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private bool vIsFormOpen()
        {
            bool vOpen;
            if (Application.OpenForms.Count > 12)
            {
                vOpen = true;
            }
            else
            {
                vOpen = false;
            }
            return vOpen;
        }

        #region // Definition Forms
        private void mniCompany_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.CompanyInfo();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniParties_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.PartiesInfo();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }        
        private void mniUnits_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.UnitsInfo();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniProducts_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.Products();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniBankAccounts_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.BankAccounts();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniAccountsReg_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.GenAccountChart();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniUserProj_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.Users();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniUserProjTasks_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.UserTasks();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniAdminPanel_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.AdminPanel(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        #endregion

        #region // Inventory
        private void mniPurchase_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.PurchaseInfo(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniPurchaseRet_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.PurRetInfo(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniProduction_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.ProductionInv(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniSale_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.SaleInvoice(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniSaleRet_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.SaleRetInvoice(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniSalesmanRecovery_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.SaleRecovery(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniStockIssueToCustomer_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.CustomerIssue(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniStockRetCustomer_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.CustomerReturn(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniSampleIssuance_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.StockSample(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniWastage_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Inventory.StockWastage(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        #endregion

        #region // Finance Forms
        private void mniAccountVoucher_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Finance.Vouchers(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniDebitVoucher_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Finance.CPVoucher(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniCreditVoucher_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Finance.CRVoucher(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniJournalVoucher_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Finance.JVouchers(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniCashDeposit_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Finance.CashDeposit(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniChequeDeposit_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Finance.ChequeDeposit(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniChequeIssue_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Finance.ChequeIssue(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        #endregion

        #region // Payroll
        private void mniDepartments_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new PayRoll.Departments();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniDesignation_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new PayRoll.Designation();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniShift_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new PayRoll.Shifts();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniEmployees_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Definition.Salesman(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniHolidays_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new PayRoll.Holidays(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniAttendance_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new PayRoll.DailyAttendance(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniLeaves_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new PayRoll.EmployeeLeaves(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniSalaryGenerate_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new PayRoll.SalaryGenerate(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        #endregion

        #region // Members Forms
        private void mniScheme_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Shares.ShareScheme(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniMembers_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Shares.ShareMembers();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniSharesIssue_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Shares.SharesSale(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniProfitDistribute_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Shares.ProfitDistribute(vUserID);
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        #endregion

        #region // Rports
        private void mnrAccountList_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptAccountsList();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartiesList_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartiesList();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrProductList_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptProductList();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPurRegister_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPurRegistercs();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrSaleRegister_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptSaleRegister();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartyWisePurchase_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartyWisePur();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartyWiseSales_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartyWiseSale();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartyProdcutWiseSale_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartyProductWiseSale();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrCustomerAging_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptCsutomerAging();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrRecoveryAging_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptCustomerAgingRec();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrSalesmanSale_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptSalesmanSale();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrRecovery_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptRecovery();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartySaleSummary_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartySaleSummary();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrCurrentStock_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptCurrentStock();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrCashBook_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptCashBook();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartyLedger_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartyLedger();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrGenAccLedger_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptAccountLedger();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrTrialBalance_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptTrialBalance();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPLStatement_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptProfitAndLoss();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrStockStatement_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptStockStatement();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrCustWiseStockIssue_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartyStockIssue();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrProductWiseWaste_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptProductWiseWaste();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrCustWiseSampleIssue_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartySampleIssue();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartyReceivables_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartyReceivable();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrPartyPayables_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptPartyPayble();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mnrExpenseSheet_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Reports.RptExpenseSheet();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        #endregion

        #region // Tools
        private void mniBackUp_Click(object sender, EventArgs e)
        {
            DAL.Misc Msc = new DAL.Misc();
            Msc.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;


            try
            {
                Msc.TakeDBBackup();
                new Speak().SayIt("Database backup successfully.");
                MessageBox.Show("Database backup successfully.", "Completed");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void mniRestoreDB_Click(object sender, EventArgs e)
        {
            //if (vIsFormOpen() == true) return;
            //Form vForm = new DefinitionForms.RestoreDB();
            //vForm.MdiParent = this;
            //vForm.StartPosition = FormStartPosition.CenterScreen;
            //vForm.Show();
        }
        private void mniSettings_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Tools.Configuration();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniScriptRunner_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Tools.ScriptRunner();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        private void mniBalTransfer_Click(object sender, EventArgs e)
        {
            if (vIsFormOpen() == true) return;
            Form vForm = new Tools.BalanceTransfer();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }
        #endregion

        

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            int w = resolution.Width;
            int h = resolution.Height;

            lblUserName.Text = " " + vUserName;

            if (!IsAdmin) SetToolStripItems(menuStrip.Items);
            mniAccountVoucher.Visible = false;
            //mnuShares.Visible = false;
            //mniProduction.Visible = false;
            //if (w <= 800)
            //{
            //    this.BackgroundImage = imageList1.Images[2];
            //}
            //else if (w <= 1080)
            //{
            //    this.BackgroundImage = imageList1.Images[0];
            //}
            //else this.BackgroundImage = imageList1.Images[2];
        }


        private void SetUserTasks()
        {
            try
            {
                DAL.UserTasks objDAL = new DAL.UserTasks();
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;

                DataTable dt = objDAL.getRecord(vUserID);

                menuStrip.Items.OfType<ToolStripItem>().ToList().ForEach(item =>
                {
                    
                    
                    if (item.Name != "mnuRegistration" && item.Name != "mnuFinance" && item.Name != "mnuReports" && item.Name != "mnuTools" && item.Name != "mnuHelp")
                    {
                        var isAllow = dt.Select(" Selected=1 AND TaskKey='" + item.Name + "'");

                        if (isAllow.Length > 0)
                        {
                            item.Visible = true;
                        }
                        else
                        {
                            item.Visible = false;
                        }

                    }
                });

            }
            catch (Exception exc)
            {

                throw;
            }
        }



        private void SetToolStripItems(ToolStripItemCollection dropDownItems)
        {
            try
            {

                foreach (object obj in dropDownItems)
                //for each object.
                {
                    ToolStripMenuItem subMenu = obj as ToolStripMenuItem;
                    //Try cast to ToolStripMenuItem as it could be toolstrip separator as well.

                    if (subMenu != null)
                    //if we get the desired object type.
                    {
                        if (subMenu.HasDropDownItems) // if subMenu has children
                        {
                            SetToolStripItems(subMenu.DropDownItems); // Call recursive Method.
                        }
                        else // Do the desired operations here.
                        {
                            if (subMenu.Name != null)
                            {

                                if (subMenu.Name != "exitToolStripMenuItem")
                                {
                                    DAL.UserTasks objDAL = new DAL.UserTasks();
                                    objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;

                                    DataTable dt = objDAL.getRecord(vUserID);

                                    var isAllow = dt.Select(" Selected=1 AND TaskKey='" + subMenu.Name + "'");

                                    if (isAllow.Length > 0)
                                    {
                                        subMenu.Visible = true;
                                    }
                                    else
                                    {
                                        subMenu.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SetToolStripItems",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {

        }

        private void mniAboutUs_Click(object sender, EventArgs e)
        {
            Form vForm = new AboutUs();
            vForm.MdiParent = this;
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnuReports_Click(object sender, EventArgs e)
        {

        }

       

       

        
        

        

       

        

       

        

        

      
      
       

       

       

       

       
      

       
        

        

        

        

       

        

       

     

        

       

        

        

       

       

        

        

       

        
       

       

        

        

        

        

       

        

        

        

        

        

        

        
        

        

        

        

        

        

        

        

        

        

       

       

        

       

        

        

        
       

        

        




    }
}
