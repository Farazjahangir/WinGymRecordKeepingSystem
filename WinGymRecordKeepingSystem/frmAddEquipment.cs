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
    }
}
