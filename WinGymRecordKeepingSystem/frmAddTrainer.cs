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
    public partial class frmAddTrainer : Form
    {
        SqlConnection con;
        string trainerId;
        public frmAddTrainer()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmAddTrainer_SizeChanged(object sender, EventArgs e)
        {
            pnTrainer.Left = (this.ClientSize.Width - pnTrainer.Width) / 2;
            pnTrainer.Top = (this.ClientSize.Height - pnTrainer.Height) / 2;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Please fill required fields");
            } else
            {
                try
                {
                    if (string.IsNullOrEmpty(trainerId))
                    {
                        createTrainer();
                    } else
                    {
                        updateTrainer();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    con.Close();
                    btnsubmit.Enabled = true;
                }
            }
        }
        private bool validateFields()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                isValid = false;
            } else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                isValid = false;
            } else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                isValid = false;
            } else if (!mtbContact.MaskFull)
            {
                isValid = false;
            } else if (!mtbNic.MaskFull)
            {
                isValid = false;
            }
            return isValid;
        }

        private void createTrainer()
        {
           
                btnsubmit.Enabled = false;
                string qry = "INSERT INTO tblUser " +
                                "(FirstName,LastName,Email,ContactNo,NIC, Role) " +
                                "values " +
                                "(@FName, @LName, @Email, @Contact, @NIC, 2)";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Contact", Helpers.removeDashesFromString(mtbContact.Text));
                cmd.Parameters.AddWithValue("@NIC", Helpers.removeDashesFromString(mtbNic.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trainer Added");
        }

        private void updateTrainer()
        {
            btnsubmit.Enabled = false;
            string qry = "UPDATE tblUser SET " +
                "FirstName=@FName, " +
                "LastName=@LName, " +
                "Email=@Email, " +
                "NIC=@NIC, " +
                "ContactNo=@CntNo, " +
                "UpdatedAt=@UDate " +
                "WHERE UserId=@ID";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue(
                "@NIC", 
                Helpers.removeDashesFromString(mtbNic.Text)
                );
            cmd.Parameters.AddWithValue(
                "CntNo", 
                Helpers.removeDashesFromString(mtbContact.Text)
                );
            cmd.Parameters.AddWithValue("@UDate", DateTimeOffset.Now);
            cmd.Parameters.AddWithValue("@ID", trainerId);


            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Trainer updated");
        }

        public void loadData(DataGridViewCellCollection cell)
        {
            txtFirstName.Text = cell["FirstName"].Value.ToString();
            txtLastName.Text = cell["LastName"].Value.ToString();
            txtEmail.Text = cell["Email"].Value.ToString();
            mtbContact.Text = cell["ContactNo"].Value.ToString();
            mtbNic.Text = cell["NIC"].Value.ToString();
            trainerId = cell["UserId"].Value.ToString();
        }
    }
}
