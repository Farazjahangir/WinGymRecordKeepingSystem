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
    public partial class frmNutritionTypes : Form
    {
        SqlConnection con;
        string nutritionId;
        public frmNutritionTypes()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmNutritionTypes_Load(object sender, EventArgs e)
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
                }
                else
                {
                    if (string.IsNullOrEmpty(nutritionId))
                    {
                        addNew();
                    }
                    else
                    {
                        updateData();
                    }
                    txtNutritionType.Text = "";
                    nutritionId = "";
                    btnDelete.Enabled = false;
                    btnSubmit.Text = "Add";
                    loadData();
                }
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

        private void gvNutritionTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cell = gvNutritionTypes.SelectedRows[0].Cells;
            txtNutritionType.Text = cell["Nutrition"].Value.ToString();
            nutritionId = cell["NutritionTypeId"].Value.ToString();
            btnSubmit.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtNutritionType.Text = "";
            nutritionId = "";
            btnSubmit.Text = "Add";
        }
        private void loadData()
        {
            try
            {
                string qry = "SELECT " +
                    "NutritionTypeId, " +
                    "NutritionType AS Nutrition " +
                    "FROM tblNutritionType " +
                    "WHERE IsActive=1";

                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvNutritionTypes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNew()
        {
            string qry = "INSERT INTO tblNutritionType (NutritionType) VALUES (@Type)";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.Parameters.AddWithValue("@Type", txtNutritionType.Text);
            cmd.ExecuteNonQuery();
        }

        private void updateData()
        {
            string qry = "UPDATE tblNutritionType " +
                "SET NutritionType=@Type, UpdatedAt=@UDate " +
                "WHERE NutritionTypeId=@ID";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Type", txtNutritionType.Text);
            cmd.Parameters.AddWithValue("@ID", nutritionId);
            cmd.Parameters.AddWithValue("@UDate", DateTimeOffset.Now);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        private bool validateFields()
        {
            bool isValidated = true;

            if (string.IsNullOrEmpty(txtNutritionType.Text))
            {
                isValidated = false;
            }

            return isValidated;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "UPDATE tblNutritionType " +
                    "SET IsActive=0, UpdatedAt=@UDate " +
                    "WHERE NutritionTypeId=@ID";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", nutritionId);
                cmd.Parameters.AddWithValue("@UDate", DateTimeOffset.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                loadData();

                txtNutritionType.Text = "";
                nutritionId = "";
                btnSubmit.Text = "Add";
                btnDelete.Enabled = false;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                con.Close();
            }
        }
    }
}
