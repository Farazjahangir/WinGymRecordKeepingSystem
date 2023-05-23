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
            gvMembers.Rows.Add(1, "Faraz", "Jahangir", "0321-212121", "42001-3423232", "jahangirfaraz98@gmail.com");
            gvMembers.Rows.Add(2, "Ashar", "Khalid", "0321-212121", "42001-3423232");
            gvMembers.Rows.Add(3, "M", "Rehan", "0321-212121", "42001-3423232");
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadDummyData();
            gvMembers.CurrentCell.Selected = false;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAdmission frmAdmission = new frmAdmission();
            frmAdmission.MdiParent = this.MdiParent;
            this.Hide();
            frmAdmission.WindowState = FormWindowState.Maximized;
            frmAdmission.Show();
        }

        private void gvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cell = gvMembers.SelectedRows[0].Cells;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
         
        }
    }
}
