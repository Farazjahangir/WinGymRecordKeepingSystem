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
    public partial class frmEquipments : Form
    {
        public frmEquipments()
        {
            InitializeComponent();
        }

        private void frmEquipments_Load(object sender, EventArgs e)
        {
            gvEquipments.Rows.Add("Dumbell", 3, 3);
            gvEquipments.Rows.Add("Butterfly", null, 2);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            this.Hide();
            frmUsers.Show();
        }
    }
}
