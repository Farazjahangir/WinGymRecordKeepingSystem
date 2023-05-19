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
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
             frmLogin frmLogin = new frmLogin();
             frmLogin.MdiParent = this;
             frmLogin.Show();
             frmLogin.WindowState = FormWindowState.Maximized;
        }
    }
}
