using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGymRecordKeepingSystem
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void LoadDummyData()
        {
            gvMembers.Rows.Add("AB-10023", "Faraz", "Jahangir", "0321-212121", "42001-3423232", "jahangirfaraz98@gmail.com");
            gvMembers.Rows.Add("AB-22212", "Ashar", "Khalid", "0321-212121", "42001-3423232");
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadDummyData();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAdmission frmAdmission = new frmAdmission();
            frmAdmission.MdiParent = this.MdiParent;
            this.Hide();
            frmAdmission.WindowState = FormWindowState.Maximized;
            frmAdmission.Show();
        }

        private void btnCollectFee_Click(object sender, EventArgs e)
        {
            frmCollectFee frmCollectFee = new frmCollectFee();
            frmCollectFee.MdiParent = this.MdiParent;
            this.Hide();
            frmCollectFee.WindowState = FormWindowState.Maximized;
            frmCollectFee.Show();
        }
    }
}
