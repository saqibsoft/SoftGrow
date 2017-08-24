using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftGrow.Definition
{
    public partial class AdminPanel : Form
    {
        public AdminPanel(int vUserid)
        {
            InitializeComponent();
            userid = vUserid;
        }

        DAL.Misc objDAL = new DAL.Misc();
        bool vImReady = false;
        int userid;

        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            LoadUsers();
            LoadProjects();
            cboStatus.SelectedIndex = 0;
            cboVoucherType.SelectedIndex = 0;
            vImReady = true;
            LoadGrid();

        }



        private void LoadUsers()
        {
            try
            {
                DAL.Users dalUser = new DAL.Users();
                dalUser.connectionstring = objDAL.connectionstring;


                DataTable dt = dalUser.getRecord(" AND Isnull(IsSuperAdmin,0)=0");

                DataRow dr = dt.NewRow();

                dr["UserID"] = "0";
                dr["UserName"] = "ALL";

                dt.Rows.Add(dr);

                if (dt.Rows.Count > 0)
                {
                    cboUsers.DisplayMember = "UserName";
                    cboUsers.ValueMember = "UserID";
                    cboUsers.DataSource = dt;                    
                }

                cboUsers.SelectedValue = 0;
                cboUsers.SelectedText = "ALL";


                //cboUsers.SelectedIndex = -1;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void LoadProjects()
        {
            try
            {
                //DAL.Projects dalPro = new DAL.Projects();
                //dalPro.connectionstring = objDAL.connectionstring;


                //DataTable dt = dalPro.getRecord(" ");

                //DataRow dr = dt.NewRow();
                //dr["ProjectID"] = 0;
                //dr["ProjectTitle"] = "ALL";

                //dt.Rows.Add(dr);

                //if (dt.Rows.Count > 0)
                //{
                //    cboProjects.DisplayMember = "ProjectTitle";
                //    cboProjects.ValueMember = "ProjectID";
                //    cboProjects.DataSource = dt;
                //}

                //cboProjects.SelectedValue = 0;
                //cboProjects.SelectedText = "ALL";

                //cboUsers.SelectedIndex = -1;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            if (!vImReady) return;

            try
            {
                string vWhere = string.Empty;
                int vid = 0;
                
                if(cboProjects.SelectedItem != null)
                vid = int.Parse(cboProjects.SelectedValue.ToString());

                if (vid > 0)
                {
                    vWhere += " AND ProjectID=" + vid;
                }

                if (cboUsers.SelectedItem != null)
                vid = int.Parse(cboUsers.SelectedValue.ToString());

                if (vid > 0)
                {
                    vWhere += " AND UserID=" + vid;
                }

                if (cboStatus.SelectedItem != null)
                {
                    if (cboStatus.Text == "Un Posted")
                    {
                        vWhere += " AND Selected=0";
                    }
                    else if (cboStatus.Text == "Posted")
                    {
                        vWhere += " AND Selected=1";
                    }
                }

                if (cboVoucherType.SelectedItem != null)
                {
                    if (cboVoucherType.Text != "ALL")
                    {
                        vWhere += " AND VoucherType='" + cboVoucherType.Text.Trim() + "'";
                    }                    
                }

                DataTable dt = objDAL.getVouchersForAdmin(vWhere);
                Grid.AutoGenerateColumns = false;
                Grid.DataSource = dt;
                
                                
                
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 6) return;
            try
            {
                string vVoucherType = Grid.Rows[Grid.CurrentRow.Index].Cells["VoucherType"].Value.ToString();
                Int64 vVoucherID = Int64.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["VoucherNo"].Value.ToString());
                int vStatus = (Grid.Rows[Grid.CurrentRow.Index].Cells["Selected"].Value.ToString() == "1") ? 0 : 1;

                if (vVoucherType == "CRV" || vVoucherType == "CPV" || vVoucherType == "JV")
                {
                    DAL.Vouchers objUpd = new DAL.Vouchers();
                    objUpd.connectionstring = objDAL.connectionstring;
                    objUpd.UpdateIsPosted(vVoucherID, vVoucherType, vStatus);
                }
                else if (vVoucherType == "BDV" || vVoucherType == "CDV")
                {
                    DAL.BankDeposits objUpd = new DAL.BankDeposits();
                    objUpd.connectionstring = objDAL.connectionstring;
                    objUpd.UpdateIsPosted(vVoucherID, vStatus);
                }
                else if (vVoucherType == "BCI")
                {
                    DAL.BankIssues objUpd = new DAL.BankIssues();
                    objUpd.connectionstring = objDAL.connectionstring;
                    objUpd.UpdateIsPosted(vVoucherID, vStatus);
                }
                
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

        private void cboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void cboVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            string vVoucherType = Grid.Rows[Grid.CurrentRow.Index].Cells["VoucherType"].Value.ToString();
            Int64 vVoucherID = Int64.Parse(Grid.Rows[Grid.CurrentRow.Index].Cells["VoucherNo"].Value.ToString());

            //if (vVoucherType == "CRV" || vVoucherType == "CPV" || vVoucherType == "JV")
            //{
            //    Finance.Vouchers vForm = new Finance.Vouchers(userid);                
            //    vForm.DirectLoad(vVoucherID, vVoucherType);
            //    vForm.ShowDialog();
                
            //}
            //else if (vVoucherType == "BDV")
            //{
            //    Finance.CashDeposit vForm = new Finance.CashDeposit(userid);
            //    vForm.DirectLoad(vVoucherID);
            //    vForm.ShowDialog();
            //}
            //else if (vVoucherType == "CDV")
            //{
            //    Finance.ChequeDeposit vForm = new Finance.ChequeDeposit(userid);
            //    vForm.DirectLoad(vVoucherID);
            //    vForm.ShowDialog();
            //}
            //else if (vVoucherType == "BCI")
            //{
            //    Finance.ChequeIssue vForm = new Finance.ChequeIssue(userid);
            //    vForm.DirectLoad(vVoucherID);
            //    vForm.ShowDialog();
            //}

        }
    }
}
