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

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            frmEquipments frmEquipments = new frmEquipments();
            this.Hide();
            frmEquipments.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAdmission frmAdmission = new frmAdmission();
            this.Hide();
            frmAdmission.Show();
        }

        private void frmUsers_SizeChanged(object sender, EventArgs e)
        {
        
        }
    }
}
