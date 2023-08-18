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
                   "[tblNutritionType].NutritionType " +
               "FROM tblNutrition " +
               "INNER JOIN tblNutritionCompany ON [tblNutrition].NutritionCompany = [tblNutritionCompany].NutritionCompanyId " +
               "INNER JOIN tblNutritionType ON [tblNutrition].NutritionType = [tblNutritionType].NutritionTypeId " +
               "WHERE [tblNutrition].isActive = '1'";

                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvNutritions.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
