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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        DAL.Users objDAL = new DAL.Users();
        bool vOpenMode = false;

        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            LoadGrid();
            ClearFields();
        }

        #region // General Methods
        private void MoveNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        #region // Control Operations

        private void ClearFields()
        {
            try
            {
                txtID.Text = objDAL.getNextID().ToString();
                txtName.Text = string.Empty;
                txtPass.Text = string.Empty;
                chkActive.Checked = true;
                chkAdmin.Checked = false;
                
                vOpenMode = false;
                Grid.Enabled = false;
                txtName.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        #endregion

        #region // Grid Operations

        private void LoadGrid()
        {
            try
            {
                //Grid.Rows.Clear();
                string vWhere = " AND Isnull(IsSuperAdmin,0)=0";
                DataTable dt = objDAL.getRecord(vWhere);

                Grid.AutoGenerateColumns = false;

                Grid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["ID"].Value.ToString();

                    DataTable dt = objDAL.getRecord(" AND UserID=" + txtID.Text);

                    txtName.Text = dt.Rows[0]["UserName"].ToString();
                    txtPass.Text = dt.Rows[0]["Password"].ToString();
                    chkActive.Checked = Convert.ToBoolean(dt.Rows[0]["IsActive"].ToString());
                    chkAdmin.Checked = Convert.ToBoolean(dt.Rows[0]["IsAdmin"].ToString());

                    dt.Dispose();

                    vOpenMode = true;
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        #endregion

        #region // Buttons Click

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string vMessage = string.Empty;

                if (txtName.Text.Trim() == string.Empty)
                {
                    vMessage = "Please Enter User Name.";
                    new Speak().SayIt(vMessage);
                    MessageBox.Show(vMessage, "Information Missing");
                    txtName.Focus();
                    return;
                }


                Objects.Users obj = new Objects.Users();
                obj.UserID = int.Parse(txtID.Text);
                obj.UserName = txtName.Text.Trim();
                obj.Password = txtPass.Text.Trim();
                obj.IsActive = chkActive.Checked;
                obj.IsAdmin = chkAdmin.Checked;


                if (!vOpenMode)
                {

                    //Insert Activity
                    obj.UserID = int.Parse(objDAL.getNextID().ToString());
                    objDAL.InsertRecord(obj);
                }
                else objDAL.UpdateRecord(obj);

                vMessage = "Record Saved Successfully.";
                new Speak().SayIt(vMessage);
                MessageBox.Show(vMessage, "Confirmation");
                LoadGrid();
                btnClear_Click(sender, e);

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
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

                vMessage = "Are you Sure To Delete";
                new Speak().SayIt(vMessage);
                DialogResult dMsg = MessageBox.Show("Are you Sure To Delete!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dMsg == DialogResult.No) return;

                //Delete Activity
                objDAL.DeleteRecord(int.Parse(txtID.Text));



                vMessage = "Record Deleted Successfully";
                new Speak().SayIt(vMessage);
                MessageBox.Show(vMessage, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                btnClear_Click(sender, e);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                btnDelete_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                btnClose_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                //btnPrint_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                btnClear_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                btnSwitch_Click(null, null);
            }
        }

    }
}
