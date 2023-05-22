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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEquipment frmAddEquipment = new frmAddEquipment();
            frmAddEquipment.MdiParent = this.MdiParent;
            this.Hide();
            frmAddEquipment.WindowState = FormWindowState.Maximized;
            frmAddEquipment.Show();
        }

        private void gvEquipments_SelectionChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("SELECTION =====>");
        }

        private void gvEquipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cell = gvEquipments.SelectedRows[0].Cells;
            frmAddEquipment frmAddEquipment = new frmAddEquipment();
            frmAddEquipment.loadData(cell);
            frmAddEquipment.Show();
        }
    }
}
