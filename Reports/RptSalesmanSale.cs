﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Reports
{
    public partial class RptSalesmanSale : Form
    {
        DAL.Reports objDAL = new DAL.Reports();
        public RptSalesmanSale()
        {
            InitializeComponent();
        }

        private void optAllDates_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchParties vForm = new SearchForms.SchParties();
                vForm.IsVendor = false;
                vForm.IsCustomer = true;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtVendorID.Text = vForm.MyID;
                    txtVendorName.Text = vForm.MyName;
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void GoToNextCont(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
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

        private void PopulateSalesman()
        {
            try
            {
                DAL.Employees objSal = new DAL.Employees();
                objSal.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;


                DataTable dt = objSal.getRecord(string.Empty);
                DataRow dr = dt.NewRow();
                dr["EmployeeID"] = 0;
                dr["EmployeeName"] = "-No Selection-";

                dt.Rows.Add(dr);
                if (dt.Rows.Count > 0)
                {
                    cboSalesman.DataSource = dt;
                    cboSalesman.DisplayMember = "EmployeeName";
                    cboSalesman.ValueMember = "EmployeeID";
                }

                cboSalesman.SelectedValue = 0;
                cboSalesman.SelectedText = "-No Selection-";

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void txtVendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchProducts vForm = new SearchForms.SchProducts();
                vForm.IsSaleable = false;
                vForm.IsConsumable = false;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txt_ProductID.Text = vForm.MyID;
                    txt_ProductName.Text = vForm.MyName;
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckIsNumeric(e.KeyChar) == 0) e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string vWhere = string.Empty;
                string criteria = string.Empty;

                Reports.RptReportViewer vForm = new Reports.RptReportViewer();

                if (!chkReturn.Checked)
                {
                    if (!string.IsNullOrEmpty(this.txtVendorID.Text))
                    {
                        vWhere += " AND Sale.CustomerID=" + this.txtVendorID.Text;
                    }

                    if (Int32.Parse(cboSalesman.SelectedValue.ToString()) > 0)
                    {
                        vWhere += " AND Sale.SalesmanID=" + cboSalesman.SelectedValue.ToString();
                        //criteria += " Salesman: " + cboSalesman.SelectedText;
                    }

                    //if (!string.IsNullOrEmpty(this.txt_ProductID.Text))
                    //{
                    //    vWhere += " AND SaleBody.ProductID=" + this.txt_ProductID.Text;
                    //}

                    if (optCash.Checked)                    
                    {
                        vWhere += " AND (ISNULL(Sale.CashReceived, 0) = Sale.GrossValue - ISNULL(Sale.SpecialDisc, 0) )";
                        criteria += " CASH Sale ";
                    }
                    else if (optCredit.Checked)
                    {
                        vWhere += " AND (ISNULL(Sale.CashReceived, 0) <> Sale.GrossValue - ISNULL(Sale.SpecialDisc, 0) )";
                        criteria += " CREDIT Sale ";
                    }

                    if (optRange.Checked == true)
                    {
                        vWhere += " AND convert(datetime,Convert(varchar,Sale.EntryDate,1)) Between Convert(Datetime,(convert(varchar,convert(Datetime,'" + this.dt_From.Text + " 00:00:00',102),1))) AND Convert(Datetime,(convert(varchar,convert(Datetime,'" + this.dt_ToDate.Text + " 00:00:00',102),1)))";
                        criteria += "From: " + dt_From.Value.ToString("dd-MMM-yyyy") + " To: " + dt_ToDate.Value.ToString("dd-MMM-yyyy");
                    }
                    else
                    {
                        criteria += " Till Date: " + dt_ToDate.Value.ToString("dd-MMM-yyyy");
                    }


                    DataTable dt = objDAL.getPrtyWiseSale(vWhere);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Data To Display", "No Data");
                        return;
                    }
                    vForm.SalesmanSale(criteria, dt, chkLetterPad.Checked,chkShowSummary.Checked);
                    vForm.ShowDialog();
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.txtVendorID.Text))
                    {
                        vWhere = " AND SaleReturn.CustomerID=" + this.txtVendorID.Text;
                    }

                    if (Int32.Parse(cboSalesman.SelectedValue.ToString()) > 0)
                    {
                        vWhere += " AND SaleReturn.SaleID IN (Select SaleID From Sale Where SalesmanID=" + cboSalesman.SelectedValue.ToString() + ")";
                        criteria += " Salesman: " + cboSalesman.SelectedText;
                    }

                    //if (!string.IsNullOrEmpty(this.txt_ProductID.Text))
                    //{
                    //    vWhere += " AND SaleRetBody.ProductID=" + this.txt_ProductID.Text;
                    //}

                    if (optRange.Checked == true)
                    {
                        vWhere += " AND convert(datetime,Convert(varchar,SaleReturn.EntryDate,1)) Between Convert(Datetime,(convert(varchar,convert(Datetime,'" + this.dt_From.Text + " 00:00:00',102),1))) AND Convert(Datetime,(convert(varchar,convert(Datetime,'" + this.dt_ToDate.Text + " 00:00:00',102),1)))";
                        criteria = "From: " + dt_From.Value.ToString("dd-MMM-yyyy") + " To: " + dt_ToDate.Value.ToString("dd-MMM-yyyy");
                    }
                    else
                    {
                        criteria = " Till Date: " + dt_ToDate.Value.ToString("dd-MMM-yyyy");
                    }


                    DataTable dt = objDAL.getPrtyWiseSaleRet(vWhere);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Data To Display", "No Data");
                        return;
                    }
                    vForm.PartyWiseSaleRet(criteria, dt, chkLetterPad.Checked);
                    vForm.ShowDialog();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void RptSaleRegister_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            PopulateSalesman();
        }

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVendorID.Text)) txtVendorName.Text = string.Empty;
        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ProductID.Text)) txt_ProductName.Text = string.Empty;
        }
    }
}