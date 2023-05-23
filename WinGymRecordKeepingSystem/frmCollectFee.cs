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
        int selectedMemberId = 1;
        public frmCollectFee()
        {
            InitializeComponent();
        }

        public void getMemberId(int id)
        {
            selectedMemberId = id;
        }
        private void frmCollectFee_Load(object sender, EventArgs e)
        {
            Console.WriteLine("frmCollectFee_Load");
            pnCollectFee.Left = (this.ClientSize.Width - pnCollectFee.Width) / 2;
            pnCollectFee.Top = (this.ClientSize.Height - pnCollectFee.Height) / 2;
            Dictionary<int, string> membersList = new Dictionary<int, string>();
             membersList.Add(1, "Faraz");
            membersList.Add(2, "Ashar");
             membersList.Add(3, "Rehan");
            cmbName.DataSource = new BindingSource(membersList, null);
            cmbName.DisplayMember = "Value";
            cmbName.ValueMember = "Key";
            cmbName.SelectedValue = selectedMemberId;
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMemberId = int.Parse(cmbName.SelectedValue.ToString());
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("selectedMemberId ==> ", selectedMemberId);
        }
    }
}
