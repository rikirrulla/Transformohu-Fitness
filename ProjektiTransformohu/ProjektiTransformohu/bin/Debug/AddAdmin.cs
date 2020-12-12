using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiTransformohu
{
    public partial class AddAdmin : Form
    {
        private CD_Admin cD_AddAdmin = new CD_Admin();
        public AddAdmin()
        {
             InitializeComponent();
            
        }

        private void fillTableAdmins()
        {
        CD_Admin cDA = new CD_Admin();
            addTable.DataSource = cDA.FillData();
        }


        private void BunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

      

        private void BunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            fillTableAdmins();
        }

        private void ShtoAdminin_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text.Trim() != "" && password.Text.Trim() != "" && name.Text.Trim() != "" && mobile1.Text.Trim() != "")
                {
                    string selected = comboBox1.SelectedItem.ToString();
                    cD_AddAdmin.InsertAdmin(username.Text, password.Text, name.Text, mobile1.Text, selected);
                    MessageBox.Show("U shtua me sukses");
                    fillTableAdmins();
                }
                else
                {
                    MessageBox.Show("Mbushni të gjitha fushat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch(Exception ex) {
                MessageBox.Show("Gabim"+ex);
            }
        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (addTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtbSearch.Text);

        }
    }
}
