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
    public partial class AddTrainer : Form
    {
        private CD_Trainer cD_Trainer = new CD_Trainer();
        public AddTrainer()
        {
            InitializeComponent();
            
        }

        private void fillTable()
        {
            CD_Trainer cDA = new CD_Trainer();
            dataTable.DataSource = cDA.FillData();
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

       
        

       

        

      

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void AddTrainer_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void ShtoTrainerin_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Trim() != "" && time.Text.Trim() != "" && mobile.Text.Trim() != "")
                {
                    cD_Trainer.InsertTrainer(name.Text, time.Text, mobile.Text);
                    MessageBox.Show("Opp");
                    fillTable();
                }else
                {
                    MessageBox.Show("Mbushni të gjitha fushat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim" + ex);
            }
        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (dataTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtbSearch.Text);

        }
    }
}
