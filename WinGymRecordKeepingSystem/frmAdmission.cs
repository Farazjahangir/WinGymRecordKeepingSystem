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
          if (!editMode)
            {
                createMember();
            } else {
                updateMember();
            }
        }

        public void loadUserData(DataGridViewCellCollection cells)
        {
            memberId = Convert.ToInt32(cells[0].Value);
            txtFirstName.Text = cells[1].Value.ToString();
            txtLastName.Text = cells[2].Value.ToString();
            txtEmail.Text = cells[3]?.Value?.ToString();
            mtbContact.Text = cells[4].Value.ToString();
            mtbNic.Text = cells[5].Value.ToString();
            editMode = true;
            btnsubmit.Text = "Update";
        }

        private void createMember()
        {
            con = new SqlConnection("workstation id=dbGymRecordKeepingSystem.mssql.somee.com;packet size=4096;user id=farazjahangir_SQLLogin_1;pwd=elg1ge3ayc;data source=dbGymRecordKeepingSystem.mssql.somee.com;persist security info=False;initial catalog=dbGymRecordKeepingSystem");
            String qry = "INSERT INTO tblUser " +
                "(FirstName,LastName,Email,ContactNo,NIC, Role) " +
                "values " +
                $"('{txtFirstName.Text}','{txtLastName.Text}','{txtEmail.Text}','{mtbContact.Text}','{mtbNic.Text}', '3')";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void updateMember()
        {
            string qry = $"UPDATE tblUser " +
            $"SET " +
            $"FirstName='{txtFirstName.Text}', " +
            $"LastName='{txtLastName.Text}', " +
            $"Email='{txtEmail.Text}', " +
            $"ContactNo='{mtbContact.Text}', " +
            $"NIC='{mtbNic.Text}' " +
            $"WHERE UserId='{memberId}'";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Member Updated");
            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = this.MdiParent;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
            this.Hide();
        }
    }
}
