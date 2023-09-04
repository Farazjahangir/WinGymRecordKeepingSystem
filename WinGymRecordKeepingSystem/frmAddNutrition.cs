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
    public partial class frmAddNutrition : Form
    {
        SqlConnection con;
        string nutritionId;
        public frmAddNutrition()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmAddNutrition_SizeChanged(object sender, EventArgs e)
        {
            pnAddNutrition.Left = (this.ClientSize.Width - pnAddNutrition.Width) / 2;
            pnAddNutrition.Top = (this.ClientSize.Height - pnAddNutrition.Height) / 2;
        }

        private void frmAddNutrition_Load(object sender, EventArgs e)
        {
            bindCmbUsers();
            bindCmbCompany();
            bindCmbType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Please fill all required fileds");
            } else
            {
                try
                {
                    if (nutritionId != null)
                    {
                        updateData();
                    }
                    else
                    {
                        addData();
                    }

                    cmbCompany.SelectedValue = '0';
                    cmbType.SelectedValue = '0';
                    cmbUsers.SelectedValue = '0';
                    txtName.Text = "";
                    nutritionId = null;
                    btnAdd.Text = "Add";
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

        private void bindCmbUsers() {
            try
            {
                string qry = "SELECT * FROM tblUser WHERE Role=1 AND IsActive=1";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["UserId"] = 0;
                defaultRow["FirstName"] = "Select User";
                dt.Rows.InsertAt(defaultRow, 0);


                cmbUsers.DataSource = dt;
                cmbUsers.DisplayMember = "FirstName";
                cmbUsers.ValueMember = "UserId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindCmbCompany()
        {
            try
            {
                string qry = "SELECT * FROM tblNutritionCompany WHERE IsActive=1";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["NutritionCompanyId"] = 0;
                defaultRow["NutritionCompany"] = "Select Nutrition Company";
                dt.Rows.InsertAt(defaultRow, 0);


                cmbCompany.DataSource = dt;
                cmbCompany.DisplayMember = "NutritionCompany";
                cmbCompany.ValueMember = "NutritionCompanyId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindCmbType()
        {
            try
            {
                string qry = "SELECT * FROM tblNutritionType WHERE IsActive=1";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["NutritionTypeId"] = 0;
                defaultRow["NutritionType"] = "Select Nutrition Type";
                dt.Rows.InsertAt(defaultRow, 0);


                cmbType.DataSource = dt;
                cmbType.DisplayMember = "NutritionType";
                cmbType.ValueMember = "NutritionTypeId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validateFields()
        {
            bool isValidated = true;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                isValidated = false;
            }

            else if (cmbCompany.SelectedValue.ToString() == "0")
            {
                isValidated = false;
            }
            else if (cmbType.SelectedValue.ToString() == "0")
            {
                isValidated = false;
            }
            else if (cmbUsers.SelectedValue.ToString() == "0")
            {
                isValidated = false;
            }
            return isValidated;
        }

        private void addData()
        {
                string qry = "INSERT INTO tblNutrition" +
                    "(NutritionCompany, NutritionType, Name, AddedBy)" +
                    "VALUES (@Company, @Type, @Name, @AddedBy)";
                
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Company", cmbCompany.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Type", cmbType.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Name", txtName.Text.ToString());
            cmd.Parameters.AddWithValue("@AddedBy", cmbUsers.SelectedValue.ToString()) ;
            con.Open();
                cmd.ExecuteNonQuery();
            MessageBox.Show("Nutirion Added");
        }

        public void loadData(DataGridViewCellCollection cell)
        {
            txtName.Text = cell["Name"].Value.ToString();
            cmbType.SelectedItem = cell["NutritionType"].Value.ToString();
            cmbCompany.SelectedValue = cell["NutritionCompanyId"].Value.ToString();
            cmbUsers.SelectedValue = cell["AddedByUserId"].Value.ToString();
            nutritionId = cell["NutritionId"].Value.ToString();
            btnAdd.Text = "Update";
        }

        private void updateData()
        {
                string qry = "UPDATE tblNutrition SET " +
                    "Name=@Name, " +
                    "NutritionCompany=@NCom, " +
                    "NutritionType=@NType, " +
                    "AddedBy=@User " +
                    "WHERE NutritionId=@ID";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@NCom", cmbCompany.SelectedValue);
                cmd.Parameters.AddWithValue("@NType", cmbType.SelectedValue);
                cmd.Parameters.AddWithValue("@User", cmbUsers.SelectedValue);
                cmd.Parameters.AddWithValue("@ID", nutritionId);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nutirion updated");
        }
    }
}
