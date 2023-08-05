using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGymRecordKeepingSystem
{
    public partial class frmUsers : Form
    {
        DataGridViewCellCollection cells;
        SqlConnection con;
        public frmUsers()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void LoadDummyData()
        {
            gvMembers.Rows.Add(1, "Faraz", "Jahangir", "0321-212121", "42001-3423232", "jahangirfaraz98@gmail.com");
            gvMembers.Rows.Add(2, "Ashar", "Khalid", "0321-212121", "42001-3423232");
            gvMembers.Rows.Add(3, "M", "Rehan", "0321-212121", "42001-3423232");
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            loadData();
            // gvMembers.CurrentCell.Selected = false;
            gvMembers.RowHeadersVisible = false;
            gvMembers.CurrentCell = null;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAdmission frmAdmission = new frmAdmission();
            frmAdmission.MdiParent = this.MdiParent;
            this.Hide();
            frmAdmission.WindowState = FormWindowState.Maximized;
            frmAdmission.Show();
        }

        private void gvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = gvMembers.SelectedRows[0];
            cells = selectedRow.Cells;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAdmission frmAdmission = new frmAdmission();
            frmAdmission.loadUserData(cells);
            frmAdmission.MdiParent = this.MdiParent;
            this.Hide();
            frmAdmission.WindowState = FormWindowState.Maximized;
            frmAdmission.Show();
        }

        private void loadData()
        {
            string qry = "Select " +
                "[tblUser].UserId, " +
                "[tblUser].FirstName, " +
                "[tblUser].LastName, " +
                "[tblUser].NIC, " +
                "[tblUser].ContactNo, " +
                "[tblUser].Email, " +
                "[tblUser].CreatedAt AS 'JoinDate/Time', " +
                "[tblRole].Role, " +
                "[tblRole].RoleId " +
                "FROM tblUser " +
                "INNER JOIN tblRole ON [tblUser].Role = [tblRole].RoleId " +
                "Where [tblUser].Role = '3' AND IsActive='1'";
            // string qry = "Select * From tblUser Where Role='3'";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dtUsers = new DataTable();
            da.Fill(dtUsers);
            dtUsers = Helpers.setDateTimeInDataTableToCurrent(dtUsers, "JoinDate/Time");
            gvMembers.DataSource = dtUsers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = cells["UserId"].Value.ToString();
                string qry = "UPDATE tblUser SET IsActive='0' WHERE UserId=@ID";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", userId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                loadData();
                btnDelete.Enabled = false;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
            
        }
    }
}
