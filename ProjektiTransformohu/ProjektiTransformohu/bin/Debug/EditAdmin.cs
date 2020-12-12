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
    public partial class EditAdmin : Form
    {
        CD_Admin cD_AddAdmin = new CD_Admin();
        private string idEdit;

        public EditAdmin()
        {
            InitializeComponent();
        }

        private void BunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        

        private void fillTableAdmins()
        {
            CD_Admin cDA = new CD_Admin();
            editTable.DataSource = cDA.FillData();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text.Trim() != "" && password.Text.Trim() != "" && name.Text.Trim() != "" && mobile.Text.Trim() != "")
                {
                    string selected = comboBox1.SelectedItem.ToString();
                    idEdit = editTable.CurrentRow.Cells["Id"].Value.ToString();
                    cD_AddAdmin.EditAdmin(username.Text, password.Text, name.Text, mobile.Text, selected, idEdit);
                    MessageBox.Show("U edita me sukses!");
                    fillTableAdmins();
                }
                else
                {
                    MessageBox.Show("Mbushni të gjitha fushat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Diqka shkoj keq" + ex.Message);
            }
        }

        private void EditAdmin_Load(object sender, EventArgs e)
        {
            fillTableAdmins();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (editTable.SelectedRows.Count > 0)
            {
                username.Text = editTable.CurrentRow.Cells["Username"].Value.ToString();
                password.Text = editTable.CurrentRow.Cells["Password"].Value.ToString();
                name.Text = editTable.CurrentRow.Cells["Name"].Value.ToString();
                mobile.Text = editTable.CurrentRow.Cells["Mobile"].Value.ToString();
                comboBox1.SelectedIndex = comboBox1.FindStringExact(editTable.CurrentRow.Cells["usertype"].Value.ToString());
                idE.Text = editTable.CurrentRow.Cells["Id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selekto ne baze te qelise");
            }
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (editTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtbSearch.Text);

        }
    }
}
