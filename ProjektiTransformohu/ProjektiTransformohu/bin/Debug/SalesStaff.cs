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
    public partial class SalesStaff : Form
    {
        private CD_Connection conn = new CD_Connection();

        

        public SalesStaff()
        {
            InitializeComponent();
            fillTableAdmins();
        }



        private void fillTableAdmins()
        {
            CD_Sales cDA = new CD_Sales();
            table.DataSource = cDA.FillDataStaff();
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
            sqlCommand.CommandText = "select * from salesStaff where CONVERT(date, Date_Sold) between '" + ngaData.Value.ToString("MM/dd/yyyy")+ "' AND '" + deriData.Value.ToString("MM/dd/yyyy") + "'";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Raportet e Shitjeve";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy HH:mm:ss"));
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
            (table.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName LIKE '%{0}%'", txtbSearch.Text);

        }

        


        
    }
}
