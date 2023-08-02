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
    public partial class frmCollectFee : Form
    {
        SqlConnection con;
        public frmCollectFee()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmCollectFee_Load(object sender, EventArgs e)
        {
            loadSetupTable();
            pnCollectFee.Left = (this.ClientSize.Width - pnCollectFee.Width) / 2;
            pnCollectFee.Top = (this.ClientSize.Height - pnCollectFee.Height) / 2;
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Fill all required fields");
            } else
            {
                try
                {
                    btnCollect.Enabled = false;
                    DataRow row = validateUser();
                    string qry = "INSERT INTO tblTransaction" +
                        "(UserId, Payment, DateTime, TransactionType, PaymentType, Quantity, UnitPrice)" +
                        "VALUES (@ID, @Payment, @Date, @TransType, @PayType, @Quantity, @UPrice)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@ID", row["UserId"].ToString());
                    cmd.Parameters.AddWithValue("@Payment", txtFee.Text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("TransType", "2");
                    cmd.Parameters.AddWithValue("PayType", "1");
                    cmd.Parameters.AddWithValue("@Quantity", "1");
                    cmd.Parameters.AddWithValue("@UPrice", txtFee.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Collected");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    con.Close();
                    btnCollect.Enabled = true;
                }
            }
        }

        private void loadSetupTable()
        {
            try
            {
                string qry = "SELECT * FROM tblSetup";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.Rows[0];
                txtFee.Text = row["GymFees"].ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email field cannot be empty");
            } else
            {
                try
                {
                    btnSearch.Enabled = false;
                    string qry = "SELECT * FROM tblUser WHERE Email=@Email AND Role = 3";
                    SqlDataAdapter da = new SqlDataAdapter(qry, con);
                    da.SelectCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        throw new Exception("User not found");
                    }
                    
                    DataRow row = dt.Rows[0];
                    txtFName.Text = row["FirstName"].ToString();
                    txtLastName.Text = row["LastName"].ToString();
                    mtbNic.Text = row["NIC"].ToString();
                    mtbContact.Text = row["ContactNo"].ToString();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    btnSearch.Enabled = true;
                }
            }
        }

        private bool validateFields()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtFName.Text))
            {
                isValid = false;
            }
            else if(string.IsNullOrEmpty(txtLastName.Text))
            {
                isValid = false;
            }
            else if (!mtbContact.MaskFull)
            {
                isValid = false;
            }
            else if (!mtbNic.MaskFull)
            {
                isValid = false;
            }
            return isValid;
        }

        private DataRow validateUser()
        {
            string qry = "SELECT * FROM tblUser WHERE ContactNo=@Contact AND Role = 3 AND IsActive = 1";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            da.SelectCommand.Parameters.AddWithValue("@Contact", mtbContact.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                throw new Exception("User not found");
            }
            return dt.Rows[0];
        }
    }
}
