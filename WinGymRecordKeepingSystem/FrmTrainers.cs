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
    public partial class frmTrainers : Form
    {
        SqlConnection con;
        public frmTrainers()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddTrainer frmAddTrainer = new frmAddTrainer();
            frmAddTrainer.MdiParent = this.MdiParent;
            this.Hide();
            frmAddTrainer.WindowState = FormWindowState.Maximized;
            frmAddTrainer.Show();
        }

        private void frmTrainers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                string qry = "Select " +
                    "[tblUser].UserId, " +
                    "[tblUser].FirstName, " +
                    "[tblUser].LastName, " +
                    "[tblUser].Email, " +
                    "[tblUser].ContactNo, " +
                    "[tblUser].NIC, " +
                    "[tblUser].CreatedAt, " +
                    "[tblRole].Role, " +
                    "[tblRole].RoleId " +
                "FROM tblUser " +
                "INNER JOIN tblRole ON [tblUser].Role = [tblRole].RoleId " +
                "Where [tblUser].Role = '2' AND IsActive='1'";
               
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvTrainers.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
