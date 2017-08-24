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
    public partial class UserTasks : Form
    {
        public UserTasks()
        {
            InitializeComponent();
        }

        DAL.UserTasks objDAL = new DAL.UserTasks();
        bool vOpenMode = false;

        private void Form_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
            lblTitle.Parent = this.pictureBox1;
            lblTitle.BackColor = Color.Transparent;
            LoadUsers();            
        }

        private void LoadUsers()
        {
            try
            {
                DAL.Users dalUser = new DAL.Users();
                dalUser.connectionstring = objDAL.connectionstring;


                DataTable dt = dalUser.getRecord(" AND Isnull(IsAdmin,0)=0");

                if (dt.Rows.Count > 0)
                {
                    cboUsers.DisplayMember = "UserName";
                    cboUsers.ValueMember = "UserID";
                    cboUsers.DataSource = dt;                    
                }

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
            try
            {

                int userid = 0;                
                userid = int.Parse(cboUsers.SelectedValue.ToString());
                DataTable dt = objDAL.getRecord(userid);
                Grid.DataSource = dt;
                                
                
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                Objects.UserTasks obj = new Objects.UserTasks();
                obj.UserID = Int16.Parse(cboUsers.SelectedValue.ToString());
                obj.TaskKey = Grid.Rows[Grid.CurrentRow.Index].Cells["TaskKey"].Value.ToString();

                // if (Grid.Rows[Grid.CurrentRow.Index].Cells["Selected"].Value.ToString() != string.Empty)
                //{
                if (Grid.Rows[Grid.CurrentRow.Index].Cells["Selected"].Value.ToString() == "1")
                { objDAL.DeleteRecord(obj.UserID,obj.TaskKey); }
                else objDAL.InsertRecord(obj); ;
                //}
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

        private void UserTasks_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.Control && e.KeyCode == Keys.E)
            {
                btnClose_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                //btnPrint_Click(null, null);
            }
            
        }
    }
}
