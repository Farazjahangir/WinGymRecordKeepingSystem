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
    public partial class frmNutrition : Form
    {
        SqlConnection con;
        DataGridViewCellCollection cells;
        public frmNutrition()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmNutrition_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                string qry = "Select " +
                   "[tblNutrition].NutritionId, " +
                   "[tblNutrition].Name, " +
                   "[tblNutrition].CreatedAt AS AddedOn, " +
                   "[tblNutritionCompany].NutritionCompanyId, " +
                   "[tblNutritionCompany].NutritionCompany, " +
                   "[tblNutritionType].NutritionTypeId, " +
                   "[tblNutritionType].NutritionType, " +
                   "[tblUser].UserId AS AddedByUserId, " +
                   "[tblUser].FirstName AS AddedBy " +
               "FROM tblNutrition " +
               "INNER JOIN tblNutritionCompany ON [tblNutrition].NutritionCompany = [tblNutritionCompany].NutritionCompanyId " +
               "INNER JOIN tblNutritionType ON [tblNutrition].NutritionType = [tblNutritionType].NutritionTypeId " +
               "INNER JOIN tblUser ON [tblNutrition].AddedBy = [tblUser].UserId " +
               "WHERE [tblNutrition].isActive = '1'";

                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt = Helpers.setDateTimeInDataTableToCurrent(dt, "AddedOn");
                gvNutritions.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNutrition frmAddNutrition = new frmAddNutrition();
            frmAddNutrition.MdiParent = this.MdiParent;
            this.Hide();
            frmAddNutrition.Show();
            frmAddNutrition.WindowState = FormWindowState.Maximized;
        }

        private void gvNutritions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cells = gvNutritions.SelectedRows[0].Cells;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddNutrition frmAddNutrition = new frmAddNutrition();
            frmAddNutrition.WindowState = FormWindowState.Maximized;
            frmAddNutrition.MdiParent = this.MdiParent;
            frmAddNutrition.loadData(cells);
            frmAddNutrition.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string nutritionId = cells["NutritionId"].Value.ToString();
                string qry = "UPDATE tblNutrition " +
                    "SET IsActive=0" +
                    "WHERE NutritionId=@ID";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", nutritionId);
                con.Open();
                cmd.ExecuteNonQuery();
                loadData();
                con.Close();
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
