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
    public partial class frmEquipments : Form
    {
        SqlConnection con;
        DataGridViewCellCollection cells;
        public frmEquipments()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmEquipments_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            this.Hide();
            frmUsers.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEquipment frmAddEquipment = new frmAddEquipment();
            frmAddEquipment.MdiParent = this.MdiParent;
            this.Hide();
            frmAddEquipment.WindowState = FormWindowState.Maximized;
            frmAddEquipment.Show();
        }

        private void gvEquipments_SelectionChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("SELECTION =====>");
        }

        private void gvEquipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cells = gvEquipments.SelectedRows[0].Cells;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void loadData()
        {
            string qry = "SELECT * FROM tblEquipment";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvEquipments.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEquipment frmAddEquipment = new frmAddEquipment();
            frmAddEquipment.WindowState = FormWindowState.Maximized;
            frmAddEquipment.MdiParent = this.MdiParent;
            frmAddEquipment.loadData(cells);
            frmAddEquipment.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string equipmentId = cells["EquipmentId"].Value.ToString();
                string qry = "DELETE FROM tblEquipment Where EquipmentId=@ID";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", equipmentId);
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
