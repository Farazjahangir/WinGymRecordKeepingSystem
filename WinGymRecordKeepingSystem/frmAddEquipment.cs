using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinGymRecordKeepingSystem
{
    public partial class frmAddEquipment : Form    
    {
        SqlConnection con;
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

        private void frmAddEquipment_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("workstation id=dbGymRecordKeepingSystem.mssql.somee.com;packet size=4096;user id=farazjahangir_SQLLogin_1;pwd=elg1ge3ayc;data source=dbGymRecordKeepingSystem.mssql.somee.com;persist security info=False;initial catalog=dbGymRecordKeepingSystem");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("workstation id=dbGymRecordKeepingSystem.mssql.somee.com;packet size=4096;user id=farazjahangir_SQLLogin_1;pwd=elg1ge3ayc;data source=dbGymRecordKeepingSystem.mssql.somee.com;persist security info=False;initial catalog=dbGymRecordKeepingSystem");
            String qry = "INSERT INTO tblEquipment " +
            "(Name,Kg,Quantity)" + "values" + $"('{txtName.Text}','{txtKg.Text}','{txtQuantity.Text}')";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Equipment Add Sucessfully");
        }
    }
}
