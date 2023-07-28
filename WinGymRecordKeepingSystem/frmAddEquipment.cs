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
            con = DbConnectionManager.GetConnection();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string kg = null;
            if (txtKg.Text != String.Empty)
                    kg = txtKg.Text;
            
            string qry = "INSERT INTO tblEquipment (Name,Kg,Quantity) VALUES (@Name, @Kg, @Quantity)";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Kg", kg ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Equipment Add Sucessfully");
        }
    }
}
