using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;


namespace SoftGrow.Reports
{
    public partial class RptReportViewer : Form
    {
        DAL.Reports objDAL = new DAL.Reports();        
        
        public RptReportViewer()
        {
            InitializeComponent();
        }


        public void ShowReport(string vReportTitle,DataTable dt)
        {
            DataTable dt1;

            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;

            try
            {
                dt1 = objDAL.getCompanyInfo();
                
                if (vReportTitle == "BANK ACCOUNT LIST")
                {
                    CrpBankAccList Rpt = new CrpBankAccList();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
                }                
                else if (vReportTitle == "GEN ACCOUNT LIST")
                {
                    CrpGenAccList Rpt = new CrpGenAccList();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
                }                
                else if (vReportTitle == "PARTIES LIST")
                {
                    CrpPartiesList Rpt = new CrpPartiesList();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
                }                                                                
                else if (vReportTitle == "CURRENT STOCK")
                {
                    CrpCurrentStock Rpt = new CrpCurrentStock();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
                }
                else if (vReportTitle == "JOURNAL VOUCHER")
                {
                    CrpAccountVoucher Rpt = new CrpAccountVoucher();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = vReportTitle;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["PrintVoucherType"].ToString()))
                    {
                        Rpt.SetParameterValue("VoucherTitle", dt.Rows[0]["PrintVoucherType"].ToString());
                    }
                    else
                        Rpt.SetParameterValue("VoucherTitle", vReportTitle);

                    this.CRViewer.ReportSource = Rpt;
                }
                else if (vReportTitle == "BANK DEPOSIT VOUCHER" || vReportTitle == "BANK PAYMENT VOUCHER")
                {
                    CrpAccountVoucher Rpt = new CrpAccountVoucher();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = vReportTitle;
                    Rpt.SetParameterValue("VoucherTitle", vReportTitle);
                    this.CRViewer.ReportSource = Rpt;
                }
                else if (vReportTitle == "CASH RECEIVING VOUCHER")
                {
                    CrpAccountVoucher Rpt = new CrpAccountVoucher();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = vReportTitle;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["PrintVoucherType"].ToString()))
                    {
                        Rpt.SetParameterValue("VoucherTitle", dt.Rows[0]["PrintVoucherType"].ToString());
                    }
                    else
                        Rpt.SetParameterValue("VoucherTitle", vReportTitle);

                    this.CRViewer.ReportSource = Rpt;
                }
                else if (vReportTitle == "CASH PAYMENT VOUCHER")
                {
                    CrpAccountVoucher Rpt = new CrpAccountVoucher();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = vReportTitle;
                    if (!string.IsNullOrEmpty(dt.Rows[0]["PrintVoucherType"].ToString()))
                    {
                        Rpt.SetParameterValue("VoucherTitle", dt.Rows[0]["PrintVoucherType"].ToString());
                    }
                    else
                        Rpt.SetParameterValue("VoucherTitle", vReportTitle);
                    this.CRViewer.ReportSource = Rpt;
                }

                this.Text = vReportTitle;
                this.CRViewer.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void SaleInvoicePrint(DataTable dt, int vStyle)
    {
        try
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            DataTable dt1 = objDAL.getCompanyInfo();

            if (vStyle == 0)
            {
                //CrpSaleInvoice Rpt = new CrpSaleInvoice();
                CrpSaleInvoiceQE Rpt = new CrpSaleInvoiceQE();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                this.CRViewer.ReportSource = Rpt;
            }
            else if (vStyle == 1)
            {
                CrpSaleInvoiceU Rpt = new CrpSaleInvoiceU();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                this.CRViewer.ReportSource = Rpt;
            }
            else if (vStyle == 2)
            {
                CrpSaleInvoiceLH Rpt = new CrpSaleInvoiceLH();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                this.CRViewer.ReportSource = Rpt;
            }
            

        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message, "Error");
        }
    }

        public void ShareSalesPrint(DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();


                    CrpShareSale Rpt = new CrpShareSale();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ProductList(DataTable dt,int vStyle)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();

                if (vStyle == 0)
                {
                    CrpProductList Rpt = new CrpProductList();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
                }
                else if (vStyle == 1)
                {
                    CrpProductListP Rpt = new CrpProductListP();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
                }
                else if (vStyle == 2)
                {
                    CrpProductListS Rpt = new CrpProductListS();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    this.CRViewer.ReportSource = Rpt;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PurchaseRegister(string criteria, DataTable dt)
        {
            try
            {
                    objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                    DataTable  dt1 = objDAL.getCompanyInfo();
                    CrpPurRegister Rpt = new CrpPurRegister();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "PURCHASE REGISTER";
                    Rpt.SetParameterValue("criteria", criteria);

                    this.CRViewer.ReportSource = Rpt;
             
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PurchaseRetRegister(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpPurRegister Rpt = new CrpPurRegister();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "PURCHASE RETURN REGISTER";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void SaleRegister(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpSaleRegister Rpt = new CrpSaleRegister();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "SALE REGISTER";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void SaleRetRegister(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpSaleRegister Rpt = new CrpSaleRegister();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "SALE RETURN REGISTER";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyWisePurchase(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpPartyWisePurchase Rpt = new CrpPartyWisePurchase();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "PARTY WISE PURCHASE";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyWisePurRet(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpPartyWisePurR Rpt = new CrpPartyWisePurR();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "PARTY WISE PURCHASE RETURN";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyWiseSale(string criteria, DataTable dt,bool vLetterHead=false)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                if (vLetterHead)
                {
                    CrpPartyWiseSaleLH Rpt = new CrpPartyWiseSaleLH();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "PARTY WISE SALE";
                    Rpt.SetParameterValue("criteria", criteria);
                    this.CRViewer.ReportSource = Rpt;
                }
                else
                {
                    CrpPartyWiseSale Rpt = new CrpPartyWiseSale();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "PARTY WISE SALE";
                    Rpt.SetParameterValue("criteria", criteria);
                    this.CRViewer.ReportSource = Rpt;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void SalesmanSale(string criteria, DataTable dt, bool vLetterHead = false, bool vSummary = false)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                if (vLetterHead)
                {
                    CrpPartyWiseSaleLH Rpt = new CrpPartyWiseSaleLH();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "PARTY WISE SALE";
                    Rpt.SetParameterValue("criteria", criteria);
                    this.CRViewer.ReportSource = Rpt;
                }
                else
                {
                    if (!vSummary)
                    {
                        CrpSalesmanSale Rpt = new CrpSalesmanSale();
                        Rpt.Database.Tables[0].SetDataSource(dt);
                        Rpt.Database.Tables[1].SetDataSource(dt1);
                        Rpt.SummaryInfo.ReportTitle = "SALESMAN SALE";
                        Rpt.SetParameterValue("criteria", criteria);
                        this.CRViewer.ReportSource = Rpt;
                    }
                    else{
                        CrpSalesmanSaleSummary Rpt = new CrpSalesmanSaleSummary();
                        Rpt.Database.Tables[0].SetDataSource(dt);
                        Rpt.Database.Tables[1].SetDataSource(dt1);
                        Rpt.SummaryInfo.ReportTitle = "SALESMAN SALE SUMMARY";
                        Rpt.SetParameterValue("criteria", criteria);
                        this.CRViewer.ReportSource = Rpt;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void SalesmanRecovery(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpRecoveryList Rpt = new CrpRecoveryList();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "SALESMAN RECOVERY";
                    Rpt.SetParameterValue("criteria", criteria);
                    this.CRViewer.ReportSource = Rpt;
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyWiseSaleRet(string criteria, DataTable dt,bool vLetterHead=false)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                if (vLetterHead)
                {
                    CrpPartyWiseSaleRLH Rpt = new CrpPartyWiseSaleRLH();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "PARTY WISE SALE RETURN";
                    Rpt.SetParameterValue("criteria", criteria);
                    this.CRViewer.ReportSource = Rpt;
                }
                else
                {
                    CrpPartyWiseSaleR Rpt = new CrpPartyWiseSaleR();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "PARTY WISE SALE RETURN";
                    Rpt.SetParameterValue("criteria", criteria);
                    this.CRViewer.ReportSource = Rpt;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowLedger(string vPartyID, string vRange, DateTime vFromDate, DateTime vToDate, DataTable dt,bool LetterHead=false)
        {
            try
            {
                DataTable dt1, dt2;
                string vPartyName = string.Empty;
                string vPartyAddress = string.Empty;

                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();

                dt2 = objDAL.getPartiesList(" AND Parties.PartyID=" + vPartyID);

                if (dt2.Rows.Count > 0)
                {
                    vPartyName = dt2.Rows[0]["PartyName"].ToString();
                    vPartyAddress = dt2.Rows[0]["Address"].ToString();
                    vPartyAddress += "(" + dt2.Rows[0]["ContactNo"].ToString() + ")";

                }
                else
                {
                    dt2 = objDAL.getAccountsList(" AND AccountNo='" + vPartyID + "'");
                    vPartyName = dt2.Rows[0]["AccountTitle"].ToString();
                    vPartyAddress = dt2.Rows[0]["AccountType"].ToString();
                }

                if (LetterHead)
                {
                    CrpPartyLedgerLH Rpt = new CrpPartyLedgerLH();

                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);

                    Rpt.SetParameterValue("PartyID", vPartyID);
                    Rpt.SetParameterValue("PartyName", vPartyName);
                    Rpt.SetParameterValue("PartyAddress", vPartyAddress);
                    Rpt.SetParameterValue("DateRange", vRange);
                    Rpt.SetParameterValue("FromDate", vFromDate);
                    Rpt.SetParameterValue("ToDate", vToDate);


                    this.CRViewer.ReportSource = Rpt;
                }
                else
                {
                    CrpPartyLedger Rpt = new CrpPartyLedger();

                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);

                    Rpt.SetParameterValue("PartyID", vPartyID);
                    Rpt.SetParameterValue("PartyName", vPartyName);
                    Rpt.SetParameterValue("PartyAddress", vPartyAddress);
                    Rpt.SetParameterValue("DateRange", vRange);
                    Rpt.SetParameterValue("FromDate", vFromDate);
                    Rpt.SetParameterValue("ToDate", vToDate);


                    this.CRViewer.ReportSource = Rpt;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowPartyLedger(string vPartyID, string vRange, DateTime vFromDate, DateTime vToDate, DataTable dt, bool LetterHead=false)
        {
            try
            {
                DataTable dt1, dt2;
                string vPartyName = string.Empty;
                string vPartyAddress = string.Empty;

                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();

                dt2 = objDAL.getPartiesList(" AND Parties.AccountID='" + vPartyID + "'");

                if (dt2.Rows.Count > 0)
                {
                    vPartyName = dt2.Rows[0]["PartyName"].ToString();
                    vPartyAddress = dt2.Rows[0]["Address"].ToString();
                    if(!string.IsNullOrEmpty(dt2.Rows[0]["ContactNo"].ToString()))
                    vPartyAddress += "(" + dt2.Rows[0]["ContactNo"].ToString() + ")";

                }
                else
                {
                    dt2 = objDAL.getAccountsList(" AND AccountNo='" + vPartyID + "'");
                    vPartyName = dt2.Rows[0]["AccountTitle"].ToString();
                    vPartyAddress = dt2.Rows[0]["AccountType"].ToString();
                }

                if (LetterHead)
                {
                    CrpPartyLedger2LH Rpt = new CrpPartyLedger2LH();


                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);

                    Rpt.SetParameterValue("PartyID", vPartyID);
                    Rpt.SetParameterValue("PartyName", vPartyName);
                    Rpt.SetParameterValue("PartyAddress", vPartyAddress);
                    Rpt.SetParameterValue("DateRange", vRange);
                    Rpt.SetParameterValue("FromDate", vFromDate);
                    Rpt.SetParameterValue("ToDate", vToDate);
                    this.CRViewer.ReportSource = Rpt;
                }
                else
                {
                    CrpPartyLedger2 Rpt = new CrpPartyLedger2();
                    

                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);

                    Rpt.SetParameterValue("PartyID", vPartyID);
                    Rpt.SetParameterValue("PartyName", vPartyName);
                    Rpt.SetParameterValue("PartyAddress", vPartyAddress);
                    Rpt.SetParameterValue("DateRange", vRange);
                    Rpt.SetParameterValue("FromDate", vFromDate);
                    Rpt.SetParameterValue("ToDate", vToDate);
                    this.CRViewer.ReportSource = Rpt;
                }

                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowRecPay(DateTime vToDate, bool vRec, DataTable dt)
        {
            try
            {
                DataTable dt1, dt2;                

                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();

                if (vRec == true)
                {
                    CrpPartyReceivables Rpt = new CrpPartyReceivables();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SetParameterValue("ToDate", vToDate);
                    this.CRViewer.ReportSource = Rpt;
                }
                else
                {
                    CrpPartyPayables Rpt = new CrpPartyPayables();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SetParameterValue("ToDate", vToDate);
                    this.CRViewer.ReportSource = Rpt;
                }

                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowCashBook(DateTime vFromDate, DateTime vToDate, DataTable dt)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();


                CrpCashBook Rpt = new CrpCashBook();

                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SetParameterValue("FromDate", vFromDate);
                Rpt.SetParameterValue("ToDate", vToDate);

                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowTrialBalance(DateTime vToDate, DataTable dt)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();


                CrpTrialBalance Rpt = new CrpTrialBalance();

                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SetParameterValue("atDate", vToDate);

                this.CRViewer.ReportSource = Rpt;
                this.CRViewer.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowProfitAndLoss(string vNarration,decimal vNetSales,decimal vOpStockVal,decimal vNetPurchases,decimal vCurrentStockVal, DataTable dt)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();


                CrpProfitAndLoss Rpt = new CrpProfitAndLoss();

                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);

                Rpt.SetParameterValue("PeriodNarration", vNarration);
                Rpt.SetParameterValue("NetSales", vNetSales);
                Rpt.SetParameterValue("OpStockVal", vOpStockVal);
                Rpt.SetParameterValue("NetPurchases", vNetPurchases);
                Rpt.SetParameterValue("CurrentStockVal", vCurrentStockVal);

                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowExenseSheet(string vNarration, DataTable dt)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();


                CrpExpenseSheet Rpt = new CrpExpenseSheet();

                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);

                Rpt.SetParameterValue("PeriodNarration", vNarration);
                Rpt.SetParameterValue("NetSales", 0);
                Rpt.SetParameterValue("OpStockVal", 0);
                Rpt.SetParameterValue("NetPurchases", 0);
                Rpt.SetParameterValue("CurrentStockVal", 0);

                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowOrgAccLedger(DateTime vFromDate, DateTime vToDate, DataTable dt, string vCriteria,string vAccNo, string vAccTitle)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();


                //CrpOrgAccLedger Rpt= new CrpOrgAccLedger();

                //Rpt.Database.Tables[0].SetDataSource(dt);
                //Rpt.Database.Tables[1].SetDataSource(dt1);
                //Rpt.SetParameterValue("prmAccountID", vAccNo);
                //Rpt.SetParameterValue("prmAccountTitle", vAccTitle);
                //Rpt.SetParameterValue("FromDate", vFromDate);
                //Rpt.SetParameterValue("ToDate", vToDate);
                //Rpt.SetParameterValue("prmCriteria", vCriteria);

                //this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowOrgAccBalances(DataTable dt)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();


                //CrpOrgAccBalances Rpt = new CrpOrgAccBalances();

                //Rpt.Database.Tables[0].SetDataSource(dt);
                //Rpt.Database.Tables[1].SetDataSource(dt1);                

                //this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowGenAccLedger(DateTime vFromDate, DateTime vToDate, DataTable dt, string vCriteria, string vAccNo, string vAccTitle)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();


                //CrpGenAccLedger Rpt = new CrpGenAccLedger();

                //Rpt.Database.Tables[0].SetDataSource(dt);
                //Rpt.Database.Tables[1].SetDataSource(dt1);
                //Rpt.SetParameterValue("prmAccountID", vAccNo);
                //Rpt.SetParameterValue("prmAccountTitle", vAccTitle);
                //Rpt.SetParameterValue("FromDate", vFromDate);
                //Rpt.SetParameterValue("ToDate", vToDate);
                //Rpt.SetParameterValue("prmCriteria", vCriteria);

                //this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowExpVariance(DateTime vFromDate, DateTime vToDate, DataTable dt, string vCriteria,bool hideBudget=false)
        {
            try
            {
                DataTable dt1;
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                dt1 = objDAL.getCompanyInfo();

                //if (hideBudget == false)
                //{
                //    CrpExpVariance Rpt = new CrpExpVariance();

                //    Rpt.Database.Tables[0].SetDataSource(dt);
                //    Rpt.Database.Tables[1].SetDataSource(dt1);
                //    Rpt.SetParameterValue("FromDate", vFromDate);
                //    Rpt.SetParameterValue("ToDate", vToDate);
                //    Rpt.SetParameterValue("Criteria", vCriteria);
                //    this.CRViewer.ReportSource = Rpt;
                //}
                //else
                //{
                //    CrpExpVariance2 Rpt = new CrpExpVariance2();

                //    Rpt.Database.Tables[0].SetDataSource(dt);
                //    Rpt.Database.Tables[1].SetDataSource(dt1);
                //    Rpt.SetParameterValue("FromDate", vFromDate);
                //    Rpt.SetParameterValue("ToDate", vToDate);
                //    Rpt.SetParameterValue("Criteria", vCriteria);
                //    this.CRViewer.ReportSource = Rpt;
                //}
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ShowStockStatement(DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();


                //CrpStockStatement Rpt = new CrpStockStatement();
                CrpStockStatementQty Rpt = new CrpStockStatementQty();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyProductWiseSale(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpPartyProductWiseSale Rpt = new CrpPartyProductWiseSale();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "PARTY/PRODUCT WISE SALE";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartySaleSummary(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpPartySaleSummary Rpt = new CrpPartySaleSummary();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "PARTY SALE SUMMARY";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyAging(DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpLastSaleReport Rpt = new CrpLastSaleReport();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "CUSTOMER's AGING";                
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyAgingRec(DataTable dt,string vCriteria)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();
                CrpLastRecovery Rpt = new CrpLastRecovery();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SetParameterValue("criteria", vCriteria);
                Rpt.SummaryInfo.ReportTitle = "CUSTOMER's AGING";
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyStockIssue(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();

                CrpPartyStockIssue Rpt = new CrpPartyStockIssue();
                    Rpt.Database.Tables[0].SetDataSource(dt);
                    Rpt.Database.Tables[1].SetDataSource(dt1);
                    Rpt.SummaryInfo.ReportTitle = "CUSTOMER WISE STOCK ISSUE";
                    Rpt.SetParameterValue("criteria", criteria);
                    this.CRViewer.ReportSource = Rpt;                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyStockReturn(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();

                CrpPartyStockRet Rpt = new CrpPartyStockRet();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "CUSTOMER WISE STOCK RETURN";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void ProductWiseWaste(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();

                CrpProductWiseWaste Rpt = new CrpProductWiseWaste();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "PRODUCT WISE WASTE";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void PartyStockSample(string criteria, DataTable dt)
        {
            try
            {
                objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt1 = objDAL.getCompanyInfo();

                CrpPartyStockSample Rpt = new CrpPartyStockSample();
                Rpt.Database.Tables[0].SetDataSource(dt);
                Rpt.Database.Tables[1].SetDataSource(dt1);
                Rpt.SummaryInfo.ReportTitle = "CUSTOMER WISE SAMPLE ISSUE";
                Rpt.SetParameterValue("criteria", criteria);
                this.CRViewer.ReportSource = Rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptReportViewer_Load(object sender, EventArgs e)
        {
            
        }

    }
}
