using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Inventory
{
    public partial class SaleRecovery : Form
    {
        bool vOpenMode;
        DAL.Recovery objDAL = new DAL.Recovery();
        MyMessages Message = new MyMessages();
        DAL.Misc Msc = new DAL.Misc();

        private int vUserID;

        public SaleRecovery(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
        }

        private void SaleInfo_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            Msc.connectionstring = objDAL.connectionstring;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            PopulateSalesman();
            ClearFields();
        }

        private void PopulateSalesman()
        {
            try
            {
                DAL.Employees objSal = new DAL.Employees();
                objSal.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;


                DataTable dt = objSal.getRecord(" AND isnull(Employees.IsSalesman,0)=1");
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
        private void ForQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == '.' && !mytxt.Text.Contains('.'))
            {
                e.Handled = true; //Do not reject the input
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
                txtInvNo.Text = objDAL.getNextNo().ToString();
                txtTotal.Text = string.Empty;
                txtRemarks.Text = string.Empty;

                Grid.Rows.Clear();

                vOpenMode = false;

                dtRecoveryDate.Focus();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }
        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SearchForms.SchParties vForm = new SearchForms.SchParties();
                vForm.IsVendor = false;
                vForm.IsCustomer = true;
                vForm.ShowDialog();
                if (!string.IsNullOrEmpty(vForm.MyID))
                {
                    txtCustomerID.Text = vForm.MyID;
                    txtCustomerName.Text = vForm.MyName;
                    txtAmountRec.Focus();
                }
            }
            else
            {
                MoveNext_KeyDown(sender, e);
            }
        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCustomerID.Text))
            {
                ClearBodyControls();
            }
        }
        private void ClearBodyControls()
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtAmountRec.Text = string.Empty;
            txtCustomerID.Focus();

        }
        #endregion

        #region // Grid Operations
        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    txtCustomerID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["PartyID"].Value.ToString();
                    txtCustomerName.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["PartyName"].Value.ToString();                    
                    txtAmountRec.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["AmountRecoverd"].Value.ToString();


                    txtTotal.Text = (double.Parse(txtTotal.Text) - double.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["AmountRecoverd"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint)).ToString();

                    Grid.Rows.Remove(Grid.CurrentRow);
                    
                    txtCustomerID.Focus();
                }
            }
            catch (Exception exc)
            {

                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }

        }
        #endregion

        #region // Buttons Operations
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TTLVal = 0;
                decimal TTLRec = 0;      

                if (txtCustomerID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Valid Customer", "Customer Missing");
                    txtCustomerID.Focus();
                    return;
                }


                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        if (txtCustomerID.Text == dr.Cells["PartyID"].Value.ToString())
                        {
                            MessageBox.Show("Customer Already Inserted!!!", "Invalid Entry");
                            txtCustomerID.Focus();
                            return;
                        }
                    }
                }

                decimal.TryParse(txtTotal.Text, out TTLVal);
                decimal.TryParse(txtAmountRec.Text, out TTLRec);

                if (TTLRec == 0)
                {
                    MessageBox.Show("Zero amount Can not be Inserted.", "Invalid Value");
                    txtAmountRec.Focus();
                    return;
                }
                


                Grid.Rows.Add(txtCustomerID.Text, txtCustomerName.Text, txtAmountRec.Text);

                txtTotal.Text = (TTLVal + TTLRec).ToString("G29");

                ClearBodyControls();
                txtCustomerID.Focus();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }


        }
        private void btnProClear_Click(object sender, EventArgs e)
        {
            ClearBodyControls();            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                if (!Message.ConfrmDelMsg()) return;

                objDAL.DeleteRecordBody(Int64.Parse(txtInvNo.Text));
                objDAL.DeleteRecord(Int64.Parse(txtInvNo.Text));
                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);

                ClearFields();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                int vSalesmanID = 0;

                int.TryParse(cboSalesman.SelectedValue.ToString(), out vSalesmanID);

                if (vSalesmanID ==0)
                {
                    MessageBox.Show("Please Select Salesman", "Information Missing");
                    cboSalesman.Focus();
                    return;
                }

                if (Grid.Rows.Count == 0)
                {
                    MessageBox.Show("Please Insert Recovery Customers", "Detail Missing");
                    txtCustomerID.Focus();
                    return;
                }

                decimal vTotal = 0;
                decimal.TryParse(txtTotal.Text, out vTotal);

                Objects.Recovery BAL = new Objects.Recovery();

                BAL.RecoveryID = Int64.Parse(txtInvNo.Text);
                BAL.RecoveryDate = dtRecoveryDate.Value;
                BAL.SalesmanID = vSalesmanID;
                BAL.TotalRecovery = vTotal;
                BAL.Remarks = txtRemarks.Text;                                
                BAL.UserID = vUserID;                

                if (vOpenMode)
                {
                    objDAL.UpdateRecord(BAL);
                    objDAL.DeleteRecordBody(Int64.Parse(txtInvNo.Text));
                }
                else
                {
                    
                   DataTable dt = objDAL.InsertRecord(BAL);
                   BAL.RecoveryID =Int64.Parse(dt.Rows[0]["RecoveryID"].ToString());
                }

                //Save Detail
                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        Objects.RecoveryBody objBody = new Objects.RecoveryBody();
                        objBody.RecoveryID = BAL.RecoveryID;
                        objBody.CustomerID = Int64.Parse(dr.Cells["PartyID"].Value.ToString());
                        objBody.AmountRecoverd = decimal.Parse(dr.Cells["AmountRecoverd"].Value.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint);
                        objBody.Remarks = string.Empty;                        

                        objDAL.InsertRecordBody(objBody);

                    }
                }

                Message.ShowMessage(MyMessages.MessageType.SaveRecord);
                ClearFields();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }

        private void OpenInvoice(Int64 vID)
        {
            try
            {
                btnClear_Click(null, null);

                DataTable dt = objDAL.getRecord(" AND Recovery.RecoveryID=" + vID);
                if (dt.Rows.Count > 0)
                {
                    txtInvNo.Text = dt.Rows[0]["RecoveryID"].ToString();
                    dtRecoveryDate.Text = dt.Rows[0]["RecoveryDate"].ToString();
                    if (!string.IsNullOrEmpty(dt.Rows[0]["SalesmanID"].ToString()))
                    {
                        cboSalesman.SelectedValue = dt.Rows[0]["SalesmanID"].ToString();
                        cboSalesman.SelectedText = dt.Rows[0]["EmployeeName"].ToString();
                    }
                    else
                    {
                        cboSalesman.SelectedValue = 0;
                        cboSalesman.SelectedText = "-No Selection-";
                    }

                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
                    txtTotal.Text = decimal.Parse(dt.Rows[0]["TotalRecovery"].ToString()).ToString("G29");

                    

                    

                    //Grid.DataSource = dt;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid.Rows.Add(dr["CustomerID"].ToString(),
                            dr["PartyName"].ToString(), decimal.Parse(dr["AmountRecoverd"].ToString()).ToString("G29")
                            );
                    }

                    vOpenMode = true;
                    dtRecoveryDate.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Sale ID.", "Invalid Information");
                    ClearFields();
                }


            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text)) return;
            OpenInvoice(Int64.Parse(txt_Search.Text));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            SearchForms.SchRecovery vForm = new SearchForms.SchRecovery();
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenInvoice(Int64.Parse(vForm.MyID));
            }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (vOpenMode == false) return;
            //    string vWhere = string.Empty;

            //    Reports.RptReportViewer vForm = new Reports.RptReportViewer();

            //    vWhere = "AND Sale.SaleID=" + this.txtInvNo.Text;

            //    DAL.Reports Msc = new DAL.Reports();
            //    Msc.connectionstring = objDAL.connectionstring;


            //    DataTable dt = Msc.getSaleInvoices(vWhere);
            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("No Data To Display", "No Data");
            //        return;
            //    }

            //    int vStyle = 0;

            //    if (chkLetterPad.Checked)
            //    {
            //        vStyle = 2;
            //    }

            //    if (chkInUrdu.Checked)
            //    {
            //        vStyle = 1;
            //    }



            //    vForm.SaleInvoicePrint(dt, vStyle);
            //    vForm.ShowDialog();

            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "Error");
            //}
        }
        #endregion

        private void txtCustomerID_TextChanged_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtCustomerID.Text)) this.txtCustomerName.Text = string.Empty;

            else
            {
                string vWhere = string.Empty;
                vWhere = "AND Parties.PartyID = " + txtCustomerID.Text;
                DAL.CustomerIssue obj = new DAL.CustomerIssue();

                obj.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getParties(vWhere);

                if (dt.Rows.Count > 0)
                {
                    txtCustomerID.Text = dt.Rows[0]["PartyID"].ToString(); // vForm.MyID;
                    txtCustomerName.Text = dt.Rows[0]["PartyName"].ToString();// vForm.MyName;

                }
            }
        }



        
        

        
        

        

        

        
        
        

        

        

        

        

        
    }
}
