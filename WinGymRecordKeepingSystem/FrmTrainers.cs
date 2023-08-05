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
        DataGridViewCellCollection cells;
        string trainerId;
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
                    "[tblUser].CreatedAt AS 'JoinDate/Time', " +
                    "[tblRole].Role, " +
                    "[tblRole].RoleId " +
                "FROM tblUser " +
                "INNER JOIN tblRole ON [tblUser].Role = [tblRole].RoleId " +
                "Where [tblUser].Role = '2' AND IsActive='1'";
               
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

               foreach (DataRow row in dt.Rows)
                {
                    DateTimeOffset dateTime = (DateTimeOffset)row["JoinDate/Time"];
                    row["JoinDate/Time"] = Helpers.convertDateTimeToLocal(dateTime);
                }

                gvTrainers.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvTrainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cells = gvTrainers.SelectedRows[0].Cells;
            trainerId = cells["UserId"].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddTrainer frmAddTrainer = new frmAddTrainer();
            frmAddTrainer.loadData(cells);
            frmAddTrainer.MdiParent = this.MdiParent;
            frmAddTrainer.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "UPDATE tblUser " +
                    "SET IsActive=0" +
                    "WHERE UserId=@ID";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", trainerId);
                con.Open();
                cmd.ExecuteNonQuery();
                loadData();
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                con.Close();
            }
        }
    }
}
