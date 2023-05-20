﻿using System;
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
    }
}
