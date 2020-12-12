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

namespace ProjektiTransformohu
{
    public partial class Supervisor : Form
    {
        private CD_Connection conn = new CD_Connection();

        

        public Supervisor()
        {
            InitializeComponent();
            fillTableAdmins();
        }

       

        private void fillTableAdmins()
        {
            CD_Client cDA = new CD_Client();
            table.DataSource = cDA.FillData();
        }

       

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where Gjinia = 'M' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void ShfaqFemrat_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where Gjinia = 'F' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void TeSkaduar_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where DataSkadimit < '" + DateTime.Now.ToString("MM/dd/yyyy") + "' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void TeAbonuar_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where DataSkadimit > '" + DateTime.Now.ToString("MM/dd/yyyy") + "' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void MeTrainer_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where Traineri != 'Pa Trajner' AND Traineri != '' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void KlientatNeSalle_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where IsInSide = 'Yes' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void TeAbonuar3Muaj_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            DateTime d1 = DateTime.Now;
            var teAbonuar3Muaj = d1.AddMonths(3);

            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where DataSkadimit > '" + teAbonuar3Muaj + "' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void TeAbonuar1Vite_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            DateTime d1 = DateTime.Now;
            var teAbonuar3Muaj = d1.AddMonths(12);

            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where DataSkadimit > '" + teAbonuar3Muaj + "' ORDER BY Emri";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }
    }
}
