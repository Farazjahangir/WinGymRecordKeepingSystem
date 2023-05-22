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
    public partial class frmAddTrainer : Form
    {
        public frmAddTrainer()
        {
            InitializeComponent();
        }

        private void frmAddTrainer_SizeChanged(object sender, EventArgs e)
        {
            pnTrainer.Left = (this.ClientSize.Width - pnTrainer.Width) / 2;
            pnTrainer.Top = (this.ClientSize.Height - pnTrainer.Height) / 2;
        }
    }
}
