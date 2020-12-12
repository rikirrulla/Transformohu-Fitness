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
    public partial class EditTrainer : Form
    {
        CD_Trainer cD_Trainer = new CD_Trainer();
        private string idEdit;

        public EditTrainer()
        {
            InitializeComponent();
        }

      
        

        private void fillTable()
        {
            CD_Trainer cDA = new CD_Trainer();
            editTable.DataSource = cDA.FillData();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text.Trim() != "")
                {

                    idEdit = editTable.CurrentRow.Cells["Id"].Value.ToString();
                    cD_Trainer.EditTrainer(name.Text, time.Text, mobile.Text, idEdit);
                    fillTable();
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

       

        private void Load_Click(object sender, EventArgs e)
        {
            if (editTable.SelectedRows.Count > 0)
            {
                name.Text = editTable.CurrentRow.Cells["Name"].Value.ToString();
                time.Text = editTable.CurrentRow.Cells["Time"].Value.ToString();
                mobile.Text = editTable.CurrentRow.Cells["Mobile"].Value.ToString();
                id.Text = editTable.CurrentRow.Cells["Id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selekto ne baze te qelise");
            }
        }

        private void EditTrainer_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (editTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtbSearch.Text);

        }
    }
}
