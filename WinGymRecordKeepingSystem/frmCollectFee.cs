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
        string selectedUserId;
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
                    string qry = "INSERT INTO tblTransaction" +
                        "(UserId, Payment, DateTime, TransactionType, PaymentType, Quantity, UnitPrice)" +
                        "VALUES (@ID, @Payment, @Date, @TransType, @PayType, @Quantity, @UPrice)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@ID", selectedUserId);
                    cmd.Parameters.AddWithValue("@Payment", txtFee.Text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("TransType", "2");
                    cmd.Parameters.AddWithValue("PayType", "2");
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
            if (!validateSearchFeilds())
            {
                MessageBox.Show("Provide atleast one search criteria");
            } else
            {
                try
                {
                    btnSearch.Enabled = false;
                    StringBuilder qryBuilder = new StringBuilder("SELECT * FROM tblUser WHERE Role=3");
                    string email = txtEmail.Text.Trim();
                    string userId = txtUserId.Text.Trim();
                    string contact = mtbContactSearch.Text.Replace("-", "").Trim();

                    if (!string.IsNullOrEmpty(email))
                    {
                        qryBuilder.Append($" AND Email='{email}'");
                    }
                    if(!string.IsNullOrEmpty(userId))
                    {
                        qryBuilder.Append($" AND UserId='{userId}'");
                    }
                    if (!string.IsNullOrEmpty(contact))
                    {
                        qryBuilder.Append($" AND ContactNo='{contact}'");
                    }

                    string qry = qryBuilder.ToString();
                    SqlDataAdapter da = new SqlDataAdapter(qry, con);
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
                    selectedUserId = row["UserId"].ToString();
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

        private bool validateSearchFeilds()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtEmail.Text) 
                && string.IsNullOrEmpty(txtUserId.Text)
                && !mtbContactSearch.MaskFull
                )
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
