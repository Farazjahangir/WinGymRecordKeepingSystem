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
    public partial class frmNutitionCompany : Form
    {
        SqlConnection con;
        string companyId;
        public frmNutitionCompany()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmNutitionCompany_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateFields())
                {
                    throw new Exception("Please fill required field");
                } else
                {
                    if (string.IsNullOrEmpty(companyId))
                    {
                        addNew();
                    } else
                    {
                        update();
                    }

                    txtNutritionCompany.Text = "";
                    companyId = "";
                    btnDelete.Enabled = false;
                    btnSubmit.Text = "Add";
                    loadData();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                con.Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtNutritionCompany.Text = "";
            companyId = "";
            btnSubmit.Text = "Add";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "UPDATE tblNutritionCompany " +
                    "SET IsActive=0, UpdatedAt=@UDate " +
                    "WHERE NutritionCompanyId=@ID";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", companyId);
                cmd.Parameters.AddWithValue("@UDate", DateTimeOffset.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                loadData();

                txtNutritionCompany.Text = "";
                companyId = "";
                btnSubmit.Text = "Add";
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void gvNutritionCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cell = gvNutritionCompanies.SelectedRows[0].Cells;
            txtNutritionCompany.Text = cell["Company"].Value.ToString();
            companyId = cell["NutritionCompanyId"].Value.ToString();
            btnSubmit.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void loadData()
        {
            try
            {
                string qry = "SELECT " +
                   "NutritionCompanyId, " +
                   "NutritionCompany AS Company " +
                   "FROM tblNutritionCompany " +
                   "WHERE IsActive=1";

                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvNutritionCompanies.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validateFields()
        {
            bool isValidated = true;

            if (string.IsNullOrEmpty(txtNutritionCompany.Text))
            {
                isValidated = false;
            }

            return isValidated;
        }

        private void addNew()
        {
            string qry = "INSERT INTO tblNutritionCompany (NutritionCompany) VALUES (@Company)";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.Parameters.AddWithValue("@Company", txtNutritionCompany.Text);
            cmd.ExecuteNonQuery();
        }

        private void update()
        {
            string qry = "UPDATE tblNutritionCompany " +
                "SET NutritionCompany=@Company, UpdatedAt=@UDate " +
                "WHERE NutritionCompanyId=@ID";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Company", txtNutritionCompany.Text);
            cmd.Parameters.AddWithValue("@ID", companyId);
            cmd.Parameters.AddWithValue("@UDate", DateTimeOffset.Now);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
