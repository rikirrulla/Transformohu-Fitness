using DGVPrinterHelper;
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
    public partial class ClientReport : Form
    {
        private CD_Connection conn = new CD_Connection();

        

        public ClientReport()
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

            ngaData.Format = DateTimePickerFormat.Custom;
            ngaData.CustomFormat = "yyyy-MM-dd";
            deriData.Format = DateTimePickerFormat.Custom;
            deriData.CustomFormat = "yyyy-MM-dd";
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            MessageBox.Show(ngaData.Text+" deri "+deriData);
            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where DataFillimit between '" + ngaData.Text+ "' AND '" + deriData.Text + "'";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Raportet e Klientave";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Transformohu";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(table);
        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            (table.DataSource as DataTable).DefaultView.RowFilter = string.Format("Emri LIKE '%{0}%'", txtbSearch.Text);

        }

        private void BtnSot_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            DateTime d1 = DateTime.Now;

            sqlCommand.CommandText = "select RFIDNr,Emri,Mbiemri,PersonalNr,Gjinia,DataFillimit,DataSkadimit,IsInside,Traineri,Pako from [TransformohuDBEntities].[dbo].[Abonuesi] where DataRegjistrimit = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }
    }
}
