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
    public partial class Sales : Form
    {
        private CD_Connection conn = new CD_Connection();

        

        public Sales()
        {
            InitializeComponent();
            fillTableAdmins();
        }

       

        private void fillTableAdmins()
        {
            CD_Sales cDA = new CD_Sales();
            table.DataSource = cDA.FillData();
        }

       

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

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

        

       

        public void populateRec()
        {
            SqlDataReader sqlDataReader1;
            DataTable dataTable1 = new DataTable();
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = conn.connectionDB();
            sqlCommand1.Connection = conn.connectionDB();
            sqlCommand1.CommandText = "SELECT * FROM sales WHERE Date_Sold BETWEEN DATEADD(hh, -9, GETDATE()) AND DATEADD(hh, 0, GETDATE())  and username = '" + User.firstN + "'";

            sqlDataReader1 = sqlCommand1.ExecuteReader();
            dataTable1.Load(sqlDataReader1);

            table.DataSource = dataTable1;

            conn.closeConnection();
        }

        private void Barazimi_Click(object sender, EventArgs e)
        {
            populateRec();
            total();
        }

        public void total()
        {
            double ammountToPay = 0;
            foreach (DataGridViewRow row in table.Rows)
            {
                ammountToPay += double.Parse(row.Cells["TotalAmount"].Value.ToString());
            }
           // ammountToPay += double.Parse(table["TotalAmount"].ToString());
            
            textBoxA.Text = String.Format("{0:0,0.00}", ammountToPay)+ " €";
        }

        private void BtnSot_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.connectionDB();
            sqlCommand.CommandText = "select * from sales where CONVERT(date, Date_Sold) = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'";

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;


            conn.closeConnection();
        }

        private void BtnGjitha_Click(object sender, EventArgs e)
        {
            fillTableAdmins();
        }
    }
}
