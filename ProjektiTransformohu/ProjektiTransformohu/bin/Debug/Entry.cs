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
    public partial class Entry : Form
    {
        private CD_Connection conn = new CD_Connection();

        

        public Entry()
        {
            InitializeComponent();
            fillTableAdmins();
        }

       

        private void fillTableAdmins()
        {
            CD_Client cDA = new CD_Client();
            table.DataSource = cDA.FillDataHyrjet();
        }

       

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

         
        

        private void btnSot_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select * from [TransformohuDBEntities].[dbo].[Hyrjet] where CONVERT(date, DataHyrjes) = '" + DateTime.Now.ToString() + "' ORDER BY DataHyrjes";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

       

       

        

       

       

       

        private void HyrjetPerMuaj_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            DateTime dt = DateTime.Now;
            int m = dt.Month;
            sqlCommand.CommandText = "select * from [TransformohuDBEntities].[dbo].[Hyrjet] where DATEPART(MONTH, DataHyrjes) = '"+m+"' ";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void Per1Vit_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            DateTime dt = DateTime.Now;
            int m = dt.Year;
            sqlCommand.CommandText = "select * from [TransformohuDBEntities].[dbo].[Hyrjet] where DATEPART(YEAR, DataHyrjes) = '" + m + "' ";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select * from [TransformohuDBEntities].[dbo].[Hyrjet] where CONVERT(date, DataHyrjes) between '" + ngaData.Text + "' AND '" + deriData.Text + "'";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (table.DataSource as DataTable).DefaultView.RowFilter = string.Format("emri LIKE '%{0}%'", txtbSearch.Text);

        }
    }
}
