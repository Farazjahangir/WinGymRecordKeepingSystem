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
    public partial class frmAdmission : Form
    {
        public frmAdmission()
        {
            InitializeComponent();
        }

        private void frmAdmission_SizeChanged(object sender, EventArgs e)
        {
            pnAdmission.Left = (this.ClientSize.Width - pnAdmission.Width) / 2;
            pnAdmission.Top = (this.ClientSize.Height - pnAdmission.Height) / 2;
        }
    }
}
