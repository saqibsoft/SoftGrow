using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow.Shares
{
    public partial class ProfitDistribute : Form
    {
        bool vOpenMode;
        DAL.ProfitDistribution objDAL = new DAL.ProfitDistribution();
        MyMessages Message = new MyMessages();        
        private int vUserID;

        public ProfitDistribute(int UserID)
        {
            InitializeComponent();
            vUserID = UserID;
        }

        #region // General Methods
        private void GoToNextCont(object sender, KeyEventArgs e)
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
        private void ForNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mytxt = sender as Control;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
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
                txtDistID.Text = objDAL.getNextNo().ToString();
                dt_Entry.Value = DateTime.Now.Date;
                txtNetProfit.Text = string.Empty;
                Grid.Rows.Clear();
                txtRemarks.Text = string.Empty;
                txtTotalAmount.Text = string.Empty;
                

                vOpenMode = false;
                btnPrint.Enabled = false;
                txtNetProfit.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void LoadSchemes()
        {
            try
            {
                DAL.ShareScheme obj = new DAL.ShareScheme();
                obj.connectionstring = objDAL.connectionstring;
                DataTable dt = obj.getRecord("");

                cboScheme.DisplayMember = "SchemeTitle";
                cboScheme.ValueMember = "SchemeID";
                cboScheme.DataSource = dt;

            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
        }
        #endregion

        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;            
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            LoadSchemes();
            ClearFields();
        }

        #region // Grid Operation
        private void Grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                
                    //DataGridViewRow row = Grid.Rows[e.RowIndex];
                     
                //decimal vQty, vPrice,vDisc,vGross ;
                //decimal.TryParse(row.Cells["Qty"].Value.ToString(), out vQty);
                //decimal.TryParse(row.Cells["Price"].Value.ToString(), out vPrice);
                //decimal.TryParse(row.Cells["Disc"].Value.ToString(), out vDisc);
                //decimal.TryParse(txtTotalAmount.Text,out vGross);


                //decimal result = (vQty * vPrice)- vDisc;

                ////txt_Gross.Text = (vGross + result - decimal.Parse(row.Cells["TotalValue"].Value.ToString())).ToString("g");

                //row.Cells["TotalValue"].Value = result.ToString("g");

                //CalculateGross();

            }
        }

        private void CalculateGross()
        {
            decimal vGross = 0;
            foreach (DataGridViewRow dr in Grid.Rows)
            {
                if (Convert.ToBoolean(dr.Cells["Select"].Value) == true)
                {
                    vGross += decimal.Parse(dr.Cells["TotalValue"].Value.ToString());
                }
            }

            txtTotalAmount.Text = vGross.ToString("g");
        }
        #endregion

        #region // Buttons Click
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                Grid.Rows.Clear();

                DataTable dt = objDAL.GetSchemeMembers(int.Parse(cboScheme.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    decimal vTotalShares = decimal.Parse(dt.Rows[0]["TotalShares"].ToString());
                    txtTotalShares.Text = dt.Rows[0]["TotalShares"].ToString();
                    foreach (DataRow dr in dt.Rows)
                    {
                        decimal vBought = decimal.Parse(dr["BoughtShares"].ToString());

                        decimal vRate = vBought/vTotalShares;
                        
                        Grid.Rows.Add(true,
                            dr["MemberID"].ToString(),
                            dr["MemberName"].ToString(),
                            decimal.Parse(dr["BoughtShares"].ToString()).ToString("g"),
                            vRate.ToString("G29"),
                            0
                            );
                    }
                }

                dt.Dispose();
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }

        }
        private void btnDistribute_Click(object sender, EventArgs e)
        {
            try
            {
                decimal vNetProf,vTotalAmount = 0;
                decimal.TryParse(txtNetProfit.Text, out vNetProf);

                if (vNetProf == 0)
                {
                    Message.ShowMessage(MyMessages.MessageType.MissingInfo, "Please Provide Net Profit First.");
                    txtNetProfit.Focus();
                    return;
                }

                for (int i = 0; i < Grid.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(Grid.Rows[i].Cells["Select"].Value) == true)
                    {
                        decimal vRate = decimal.Parse(Grid.Rows[i].Cells["Rate"].Value.ToString());
                        decimal vAmount = (vRate * vNetProf) / 100;
                        Grid.Rows[i].Cells["Amount"].Value = (vAmount).ToString("G29");
                        vTotalAmount += vAmount;
                    }
                    else
                    {
                        Grid.Rows[i].Cells["Amount"].Value = 0;
                    }
                }

                txtTotalAmount.Text = vTotalAmount.ToString("G29");
            }
            catch (Exception exc)
            {
                Message.ShowMessage(MyMessages.MessageType.Error, exc.Message);
            }
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

                string vMessage = string.Empty;

                if (!Message.ConfrmDelMsg()) return;

                //Delete Activity
                objDAL.DeleteRecordBody(int.Parse(txtDistID.Text));
                objDAL.DeleteRecord(int.Parse(txtDistID.Text));

                Message.ShowMessage(MyMessages.MessageType.DeleteRecord);
                btnClear_Click(sender, e);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal vTotalAmount,vNetProfit = 0;
                decimal.TryParse(txtTotalAmount.Text, out vTotalAmount);
                decimal.TryParse(txtNetProfit.Text, out vNetProfit);

                bool vHasSelectedRows = false;

                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (Convert.ToBoolean(dr.Cells["Select"].Value) == true)
                    {
                        vHasSelectedRows = true;
                        break;
                    }
                }


                if (!vHasSelectedRows)
                {
                    MessageBox.Show("Please Select a Member to Save..", "Detail Missing");
                    Grid.Focus();
                    return;
                }

                Objects.ProfitDistribution BAL = new Objects.ProfitDistribution();
                BAL.DistributionID = int.Parse(txtDistID.Text);                
                BAL.DistributionDate = dt_Entry.Value;
                BAL.SchemeID = int.Parse(cboScheme.SelectedValue.ToString());
                BAL.NetProfit = decimal.Parse(txtNetProfit.Text);                
                BAL.Remarks = txtRemarks.Text;
                BAL.UserID = vUserID;

                if (vOpenMode)
                {
                    objDAL.UpdateRecord(BAL);
                    objDAL.DeleteRecordBody(int.Parse(txtDistID.Text));
                }
                else
                {   
                    DataTable dt = objDAL.InsertRecord(BAL);
                    BAL.DistributionID = int.Parse(dt.Rows[0]["DistributionID"].ToString());
                }

                //Save Detail
                foreach (DataGridViewRow dr in Grid.Rows)
                {
                    if (dr.Cells[0].Value != null && Convert.ToBoolean(dr.Cells["Select"].Value) == true)
                    {
                        Objects.ProfitDistDetail objBody = new Objects.ProfitDistDetail();
                        objBody.DistributionID = BAL.DistributionID;
                        objBody.MemberID = Int64.Parse(dr.Cells["MemberID"].Value.ToString());
                        objBody.ProfitRate = decimal.Parse(dr.Cells["Rate"].Value.ToString());
                        objBody.ProfitAmount = decimal.Parse(dr.Cells["Amount"].Value.ToString());                        

                        objDAL.InsertRecordBody(objBody);

                    }
                }

                Message.ShowMessage(MyMessages.MessageType.SaveRecord);
                ClearFields();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Search.SchProfitDist vForm = new Search.SchProfitDist();
            vForm.ShowDialog();

            if (!string.IsNullOrEmpty(vForm.MyID))
            {
                OpenRecord(int.Parse(vForm.MyID));
            }

        }
        #endregion






        private void OpenRecord(int vID)
        {
            try
            {
                DataTable dt = objDAL.getRecord(" AND ProfitDistribution.DistributionID=" + vID);
                if (dt.Rows.Count > 0)
                {
                    txtDistID.Text = dt.Rows[0]["DistributionID"].ToString();
                    dt_Entry.Value = Convert.ToDateTime(dt.Rows[0]["DistributionDate"].ToString());
                    cboScheme.SelectedValue = dt.Rows[0]["SchemeID"].ToString();
                    cboScheme.SelectedText = dt.Rows[0]["SchemeTitle"].ToString();
                    txtNetProfit.Text = decimal.Parse(dt.Rows[0]["NetProfit"].ToString()).ToString("G29");
                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();

                    decimal vTotalAmount = 0;

                    //Grid.DataSource = dt;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Grid.Rows.Add(true,
                            dr["MemberID"].ToString(),
                            dr["MemberName"].ToString(),
                            decimal.Parse(dr["BoughtShares"].ToString()).ToString("g"),
                            decimal.Parse(dr["ProfitRate"].ToString()).ToString("G29"),
                            decimal.Parse(dr["ProfitAmount"].ToString()).ToString("G29")
                            );

                        vTotalAmount += decimal.Parse(dr["ProfitAmount"].ToString());
                    }

                    txtTotalAmount.Text = vTotalAmount.ToString("G29");

                    vOpenMode = true;
                }
                else
                {
                    MessageBox.Show("Invalid ID.", "Invalid Information");
                    ClearFields();
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        


            



        

        

        
            }
}
