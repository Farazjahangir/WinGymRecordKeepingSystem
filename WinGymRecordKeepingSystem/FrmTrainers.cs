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
    public partial class frmTrainers : Form
    {
        public frmTrainers()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddTrainer frmAddTrainer = new frmAddTrainer();
            frmAddTrainer.MdiParent = this.MdiParent;
            this.Hide();
            frmAddTrainer.WindowState = FormWindowState.Maximized;
            frmAddTrainer.Show();
        }
    }
}
