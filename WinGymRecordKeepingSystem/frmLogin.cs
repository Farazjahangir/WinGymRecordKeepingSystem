﻿using System;
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
    public partial class frmLogin : Form
    {
        SqlConnection con;
        public frmLogin()
        {
            InitializeComponent();
            con = DbConnectionManager.GetConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string qry = $"SELECT * FROM tblUser INNER JOIN tblAuth ON [tblAuth].UserId = [tblUser].UserId WHERE [tblUser].Email = '{email}' AND [tblAuth].Password='{password}'";
            SqlDataAdapter da = new SqlDataAdapter(qry , con );
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("User not found");
            } else
            {
                frmDashBoard frmDashBoard = new frmDashBoard();
                frmDashBoard.MdiParent = this.MdiParent;
                 frmDashBoard.Show();
                 this.Hide();
                 frmDashBoard.WindowState = FormWindowState.Maximized;

            }
        }

        private void frmLogin_SizeChanged(object sender, EventArgs e)
        {
            pnLogin.Left = (this.ClientSize.Width - pnLogin.Width) / 2;
            pnLogin.Top = (this.ClientSize.Height - pnLogin.Height) / 2;

        }
       
    }
}


    
    

