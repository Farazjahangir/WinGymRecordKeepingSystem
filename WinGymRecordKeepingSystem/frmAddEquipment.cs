using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinGymRecordKeepingSystem
{
    public partial class frmAddEquipment : Form
    {
        SqlConnection con;
        int? equipmentId = null;
        public frmAddEquipment()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        public void loadData(DataGridViewCellCollection data)
        {
            equipmentId = Convert.ToInt32(data["EquipmentId"].Value);
            txtName.Text = data["Name"].Value.ToString();
            txtKg.Text = data["Kg"].Value.ToString();
            txtQuantity.Text = data["Quantity"].Value.ToString();
            btnAdd.Text = "Update";
            lblAddEquipmentForm.Text = "Update Equipment";
        }

        private void frmAddEquipment_SizeChanged(object sender, EventArgs e)
        {
            pnAddEquipment.Left = (this.ClientSize.Width - pnAddEquipment.Width) / 2;
            pnAddEquipment.Top = (this.ClientSize.Height - pnAddEquipment.Height) / 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Please fill all required fields");
            } 
            else
            {
                try
                {
                    if (equipmentId != null)
                    {
                        updateData();
                    }
                    else
                    {
                        createData();
                    }
                    createTransaction();
                    frmEquipments frmEquipments = new frmEquipments();
                    frmEquipments.MdiParent = this.MdiParent;
                    frmEquipments.WindowState = FormWindowState.Maximized;
                    this.Hide();
                    frmEquipments.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    con.Close();
                }
            }
        }

        private void createData()
        {

            string kg = null;
            if (txtKg.Text != String.Empty)
                kg = txtKg.Text;

            string qry = "INSERT INTO tblEquipment (Name,Kg,Quantity) VALUES (@Name, @Kg, @Quantity)";
        
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Kg", kg ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Equipment added");
        }

        private void updateData()
        {
            string kg = null;
            if (txtKg.Text != String.Empty)
                kg = txtKg.Text;

            string qry = "Update tblEquipment " +
                "SET " +
                "Name=@Name, " +
                "Quantity=@Quantity, " +
                "Kg=@Kg, " +
                "UpdateAt=@UDate " +
                "Where EquipmentId=@ID";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@Kg", kg ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@UDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@ID", equipmentId);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Equipment Updated");
        }

        private bool validateFields()
        {
            bool isValidated = true;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                isValidated = false;
            }

            else if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                isValidated = false;
            } else if (string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                isValidated = false;
            } else if (cmbUsers.SelectedValue.ToString() == "0")
            {
                isValidated = false;
            }
            return isValidated;
        }

        private void frmAddEquipment_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "SELECT * FROM tblUser WHERE Role=1";
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createTransaction()
        {
                string qry = "INSERT INTO tblTransaction" +
                        "(UserId, Payment, DateTime, TransactionType, PaymentType, Quantity, UnitPrice)" +
                        "VALUES (@ID, @Payment, @Date, @TransType, @PayType, @Quantity, @UPrice)";
                string totalPayment = (Convert.ToInt32(txtUnitPrice.Text)
                    *
                    Convert.ToInt32(txtQuantity.Text)).ToString();
                
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", cmbUsers.SelectedValue);
                cmd.Parameters.AddWithValue("@Payment", totalPayment);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("TransType", "2");
                cmd.Parameters.AddWithValue("PayType", "2");
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@UPrice", txtUnitPrice.Text);

                cmd.ExecuteNonQuery();
        }
    }
}
