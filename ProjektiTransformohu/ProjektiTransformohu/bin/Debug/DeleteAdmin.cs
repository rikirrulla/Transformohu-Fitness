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
    public partial class DeleteAdmin : Form
    {
        CD_Admin cD_Admin = new CD_Admin();
        private string idEdit;


        public DeleteAdmin()
        {
            InitializeComponent();
        }

        private void BunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteAdmin_Load(object sender, EventArgs e)
        {
            fillTableUsers();
        }

        private void fillTableUsers()
        {
            CD_Admin cDA = new CD_Admin();
            deleteTable.DataSource = cDA.FillData();
        }

        private void Load_Click(object sender, EventArgs e)
        {

            if (deleteTable.SelectedRows.Count > 0)
            {
                username.Text = deleteTable.CurrentRow.Cells["Username"].Value.ToString();
                password.Text = deleteTable.CurrentRow.Cells["Password"].Value.ToString();
                name.Text = deleteTable.CurrentRow.Cells["Name"].Value.ToString();
                mobile.Text = deleteTable.CurrentRow.Cells["Mobile"].Value.ToString();
                comboBox1.SelectedIndex = comboBox1.FindStringExact(deleteTable.CurrentRow.Cells["usertype"].Value.ToString());
                id.Text = deleteTable.CurrentRow.Cells["Id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selekto ne baze te qelise");
            }
        }

        private void FshijeAdminin_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text.Trim() != "") {
                    idEdit = deleteTable.CurrentRow.Cells["Id"].Value.ToString();
                    cD_Admin.DeleteAdmin(idEdit);
                    fillTableUsers();
                    MessageBox.Show("U fshie me sukses");
                }
                else
                {
                    MessageBox.Show("Mbushni fushen e ID!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Diqka shkoj keq" + ex.Message);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Id_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (deleteTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtbSearch.Text);

        }
    }
}
