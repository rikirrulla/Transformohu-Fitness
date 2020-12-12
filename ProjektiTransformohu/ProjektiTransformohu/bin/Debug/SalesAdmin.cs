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
    public partial class SalesAdmin : Form
    {
        private CD_Connection conn = new CD_Connection();

        

        public SalesAdmin()
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
            sqlCommand.CommandText = "select * from sales where CONVERT(date, Date_Sold) between '" + ngaData.Text+ "' AND '" + deriData.Text + "'";
           // MessageBox.Show(deriData.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;
            double ammountToPay = 0;
            foreach (DataGridViewRow row in table.Rows)
            {
                ammountToPay += double.Parse(row.Cells["TotalAmount"].Value.ToString());
            }
            // ammountToPay += double.Parse(table["TotalAmount"].ToString());

            textBox1.Text = String.Format("{0:0,0.00}", ammountToPay) + " €";


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

        

       

        
        
       

        private void BtnSot_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            sqlCommand.Connection = conn.connectionDB();
          //  MessageBox.Show(date);
           // MessageBox.Show();
            sqlCommand.CommandText = "select * from sales where CAST(Date_Sold as DATE) = '" + date+"'";//

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;
            double ammountToPay = 0;
            foreach (DataGridViewRow row in table.Rows)
            {
                ammountToPay += double.Parse(row.Cells["TotalAmount"].Value.ToString());
            }
            // ammountToPay += double.Parse(table["TotalAmount"].ToString());

            textBox1.Text = String.Format("{0:0,0.00}", ammountToPay) + " €";

            conn.closeConnection();
        }

        private void Btn1Muaj_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            sqlCommand.Connection = conn.connectionDB();
           // MessageBox.Show(date);
            // MessageBox.Show();
            sqlCommand.CommandText = "select * from sales where Date_Sold >= DATEADD(month, -1, GETDATE())";//

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;
            double ammountToPay = 0;
            foreach (DataGridViewRow row in table.Rows)
            {
                ammountToPay += double.Parse(row.Cells["TotalAmount"].Value.ToString());
            }
            // ammountToPay += double.Parse(table["TotalAmount"].ToString());

            textBox1.Text = String.Format("{0:0,0.00}", ammountToPay) + " €";

            conn.closeConnection();
        }

        private void Btn1Vit_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            sqlCommand.Connection = conn.connectionDB();
            // MessageBox.Show(date);
            // MessageBox.Show();
            sqlCommand.CommandText = "select * from sales where Date_Sold >= DATEADD(year, -1, GETDATE())";//

            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            table.DataSource = dataTable;

            double ammountToPay = 0;
            foreach (DataGridViewRow row in table.Rows)
            {
                ammountToPay += double.Parse(row.Cells["TotalAmount"].Value.ToString());
            }
            // ammountToPay += double.Parse(table["TotalAmount"].ToString());

            textBox1.Text = String.Format("{0:0,0.00}", ammountToPay) + " €";

            conn.closeConnection();
        }
    }
}
