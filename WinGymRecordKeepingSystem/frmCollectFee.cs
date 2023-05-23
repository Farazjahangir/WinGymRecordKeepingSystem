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
    public partial class frmCollectFee : Form
    {
        public frmCollectFee()
        {
            InitializeComponent();
        }

        private void frmCollectFee_Load(object sender, EventArgs e)
        {
            pnCollectFee.Left = (this.ClientSize.Width - pnCollectFee.Width) / 2;
            pnCollectFee.Top = (this.ClientSize.Height - pnCollectFee.Height) / 2;
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }
    }
}
