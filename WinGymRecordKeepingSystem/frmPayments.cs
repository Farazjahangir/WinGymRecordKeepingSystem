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
    public partial class frmPayments : Form
    {
        SqlConnection con;
        public frmPayments()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void btnCollectFee_Click(object sender, EventArgs e)
        {
            frmCollectFee frmCollectFee = new frmCollectFee();
            frmCollectFee.MdiParent = this.MdiParent;
            this.Hide();
            frmCollectFee.WindowState = FormWindowState.Maximized;
            frmCollectFee.Show();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                string qry = "Select" +
                    "[tblTransaction].Payment, " +
                    "[tblTransaction].DateTime, " +
                    "[tblTransaction].Quantity, " +
                    "[tblTransaction].UnitPrice, " +
                    "[tblUser].FirstName, " +
                    "[tblUser].LastName, " +
                    "[tblUser].NIC, " +
                    "[tblUser].ContactNo, " +
                    "[tblUser].Email, " +
                    "[tblTransactionType].Name AS TransactionType, " +
                    "[tblPaymentType].Name AS PaymentType " +
                "FROM tblTransaction " +
                "INNER JOIN tblTransactionType ON [tblTransaction].TransactionType = [tblTransactionType].TransactionTypeId " +
                "INNER JOIN tblPaymentType ON [tblTransaction].PaymentType = [tblPaymentType].PaymentTypeId " +
                "INNER JOIN tblUser ON [tblTransaction].UserId = [tblUser].UserId ";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPayments.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
