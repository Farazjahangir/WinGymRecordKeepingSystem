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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void LoadDummyData()
        {
            gvMembers.Rows.Add("Faraz", "Jahangir", "0321-212121", "42001-3423232");
            gvMembers.Rows.Add("Ashar", "Khalid", "0321-212121", "42001-3423232");

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadDummyData();

        }
    }
}
