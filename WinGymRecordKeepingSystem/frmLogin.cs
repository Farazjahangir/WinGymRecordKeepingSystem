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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.MdiParent = this.MdiParent;
            frmDashBoard.Show();
            this.Hide();
            frmDashBoard.WindowState = FormWindowState.Maximized;
        }

        private void frmLogin_SizeChanged(object sender, EventArgs e)
        {
            pnLogin.Left = (this.ClientSize.Width - pnLogin.Width) / 2;
            pnLogin.Top = (this.ClientSize.Height - pnLogin.Height) / 2;
        }
    }
}
