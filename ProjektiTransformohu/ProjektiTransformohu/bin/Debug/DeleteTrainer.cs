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
    public partial class DeleteTrainer : Form
    {
        CD_Trainer cD_Trainer = new CD_Trainer();
        private string idEdit;


        public DeleteTrainer()
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
            fillTable();
        }

        private void fillTable()
        {
            CD_Trainer cDA = new CD_Trainer();
            deleteTable.DataSource = cDA.FillData();
        }

        private void Load_Click(object sender, EventArgs e)
        {

            if (deleteTable.SelectedRows.Count > 0)
            {
                name.Text = deleteTable.CurrentRow.Cells["Name"].Value.ToString();
                time.Text = deleteTable.CurrentRow.Cells["Time"].Value.ToString();
                mobile.Text = deleteTable.CurrentRow.Cells["Mobile"].Value.ToString();
                id.Text = deleteTable.CurrentRow.Cells["Id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selekto ne baze te qelise");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
             if (id.Text.Trim() != "")
             { 
                    idEdit = deleteTable.CurrentRow.Cells["Id"].Value.ToString();
                cD_Trainer.DeleteTrainer(idEdit);
                fillTable();
                MessageBox.Show("U fshie me sukses");
            }else
            {
                MessageBox.Show("Mbushni fushen e ID!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show("Diqka shkoj keq" + ex.Message);
            }
        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (deleteTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtbSearch.Text);

        }
    }
}
