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
    public partial class frmAdmission : Form
    {
        bool editMode = false;
        SqlConnection con;
        int memberId;
        public frmAdmission()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void frmAdmission_SizeChanged(object sender, EventArgs e)
        {
            pnAdmission.Left = (this.ClientSize.Width - pnAdmission.Width) / 2;
            pnAdmission.Top = (this.ClientSize.Height - pnAdmission.Height) / 2;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!validateFields())
                MessageBox.Show("Please fill all required fields");
            else
            {
                btnsubmit.Enabled = false;
                if (!editMode)
                {
                    createMember();
                }
                else
                {
                    updateMember();
                }
                btnsubmit.Enabled = true;
            }
        }

        public void loadUserData(DataGridViewCellCollection cells)
        {
            memberId = Convert.ToInt32(cells["UserId"].Value);
            txtFirstName.Text = cells["FirstName"].Value.ToString();
            txtLastName.Text = cells["LastName"].Value.ToString();
            txtEmail.Text = cells["Email"]?.Value?.ToString();
            mtbContact.Text = cells["ContactNo"].Value.ToString();
            mtbNic.Text = cells["NIC"].Value.ToString();
            editMode = true;
            btnsubmit.Text = "Update";
        }

        private void createMember()
        {
            try
            {
                String qry = "INSERT INTO tblUser " +
                                "(FirstName,LastName,Email,ContactNo,NIC, Role) " +
                                "values " +
                                $"('{txtFirstName.Text}','{txtLastName.Text}','{txtEmail.Text}','{mtbContact.Text}','{mtbNic.Text}', '3')";
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Member Added");
                goToUsers();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void updateMember()
        {
            try
            {
                string qry = "UPDATE tblUser " +
                             "SET " +
                             "FirstName=@FName, " +
                             "LastName=@LName, " +
                             "Email=@Email, " +
                             "ContactNo=@Contact, " +
                             "NIC=@NIC " +
                             "WHERE UserId=@ID";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Contact", mtbContact.Text);
                cmd.Parameters.AddWithValue("@NIC", mtbNic.Text);
                cmd.Parameters.AddWithValue("@ID", memberId);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Member Updated");
                goToUsers();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private bool validateFields()
        {
            bool isValidated = true;
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                isValidated = false;
            } else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                isValidated = false;
            } else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                isValidated = false;
            } else if (!mtbContact.MaskFull)
            {
                isValidated = false;
            } else if (!mtbNic.MaskFull)
            {
                isValidated = false;
            }
            return isValidated;
        }

        private void goToUsers()
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = this.MdiParent;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
            this.Hide();
        }
    }
}
