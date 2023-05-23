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
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            InitializeComponent();
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
