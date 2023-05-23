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
    public partial class frmAddEquipment : Form
    {
        public frmAddEquipment()
        {
            InitializeComponent();
        }

        public void loadData(DataGridViewCellCollection data)
        {
            txtName.Text = data["name"].Value.ToString();
        }

        private void frmAddEquipment_SizeChanged(object sender, EventArgs e)
        {
            pnAddEquipment.Left = (this.ClientSize.Width - pnAddEquipment.Width) / 2;
            pnAddEquipment.Top = (this.ClientSize.Height - pnAddEquipment.Height) / 2;
        }
    }
}
