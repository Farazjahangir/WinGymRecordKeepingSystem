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

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            frmEquipments frmEquipments = new frmEquipments();
            frmEquipments.MdiParent = this;
            frmEquipments.Show();
            frmEquipments.WindowState = FormWindowState.Maximized;

        }

        private void MDIParent_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is frmLogin)
            {
                pnMdiParent.Visible = false;
            } else
            {
                pnMdiParent.Visible = true;
            }
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = this;
            frmUsers.Show();
            frmUsers.WindowState = FormWindowState.Maximized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Show();
            frmLogin.WindowState = FormWindowState.Maximized;
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            frmTrainers frmTrainers = new frmTrainers();
            frmTrainers.MdiParent = this;
            frmTrainers.Show();
            frmTrainers.WindowState = FormWindowState.Maximized;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayments frmPayments = new frmPayments();
            frmPayments.MdiParent = this;
            frmPayments.Show();
            frmPayments.WindowState = FormWindowState.Maximized;
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.MdiParent = this;
            frmDashBoard.Show();
            frmDashBoard.WindowState = FormWindowState.Maximized;
        }

        private void btnNutritionType_Click(object sender, EventArgs e)
        {
            frmNutritionTypes frmNutitionTypes = new frmNutritionTypes();
            frmNutitionTypes.MdiParent = this;
            frmNutitionTypes.Show();
            frmNutitionTypes.WindowState = FormWindowState.Maximized;
        }

        private void btnNutritionCompany_Click(object sender, EventArgs e)
        {
            frmNutitionCompany frmNutitionCompany = new frmNutitionCompany();
            frmNutitionCompany.MdiParent = this;
            frmNutitionCompany.Show();
            frmNutitionCompany.WindowState = FormWindowState.Maximized;
        }

    }
}
