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
        SqlConnection con;
        public frmAdmission()
        {
            InitializeComponent();
        }

        private void frmAdmission_SizeChanged(object sender, EventArgs e)
        {
            pnAdmission.Left = (this.ClientSize.Width - pnAdmission.Width) / 2;
            pnAdmission.Top = (this.ClientSize.Height - pnAdmission.Height) / 2;
        }

        private void frmAdmission_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("workstation id=dbGymRecordKeepingSystem.mssql.somee.com;packet size=4096;user id=farazjahangir_SQLLogin_1;pwd=elg1ge3ayc;data source=dbGymRecordKeepingSystem.mssql.somee.com;persist security info=False;initial catalog=dbGymRecordKeepingSystem");

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("workstation id=dbGymRecordKeepingSystem.mssql.somee.com;packet size=4096;user id=farazjahangir_SQLLogin_1;pwd=elg1ge3ayc;data source=dbGymRecordKeepingSystem.mssql.somee.com;persist security info=False;initial catalog=dbGymRecordKeepingSystem");
            String qry = $"INSERT INTO tblMember (firstName,lastName,email,contactNumber,nic) values ('{txtFirstName.Text}','{txtLastName.Text}','{txtEmail.Text}','{mtbContact.Text}','{mtbNic.Text}')";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
