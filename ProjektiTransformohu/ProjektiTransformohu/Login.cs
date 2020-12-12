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
    
    public partial class Login : Form
    {
        string firstname;
       // private CD_Connection conn = new CD_Connection();
       // Form1 pForm = new Form1();
      //  FormDashboard fAdmin = new FormDashboard();
       // SuperAdmin fSuper = new SuperAdmin();

        public Login()
        {
            InitializeComponent();
            comoboxType.SelectedIndex = comoboxType.FindStringExact("user");
            //pForm.RefToFormLogin = this;
       //     fAdmin.RefToFormLogin = this;
        //    fSuper.RefToFormLogin = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Username_Click(object sender, EventArgs e)
        {
            username.Clear();
       //     picuser.BackgroundImage = Properties.Resources.userFill;
            panel1.BackColor = Color.FromArgb(255, 0, 0);
            username.ForeColor = Color.FromArgb(255, 0, 0);

      //      picpass.BackgroundImage = Properties.Resources.passwordLogin;
            panel2.BackColor = Color.WhiteSmoke;
            password.ForeColor = Color.WhiteSmoke;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            password.Clear();
           // password.PasswordChar = '●';
           // picpass.BackgroundImage = Properties.Resources.passwordFill;
            panel2.BackColor = Color.FromArgb(255, 0, 0);
            password.ForeColor = Color.FromArgb(255, 0, 0);

          //  picuser.BackgroundImage = Properties.Resources.userLogin;
            panel1.BackColor = Color.WhiteSmoke;
            username.ForeColor = Color.WhiteSmoke;
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.WhiteSmoke;
            password.ForeColor = Color.WhiteSmoke;


            panel1.BackColor = Color.WhiteSmoke;
            username.ForeColor = Color.WhiteSmoke;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

           // SqlConnection con = new SqlConnection("Data Source=DESKTOP-81KJ2B6;Initial Catalog=TransformohuDBEntities;Integrated Security=True");
            // SqlCommand cmd = new SqlCommand("select * from users_admins where username='"+username.Text+"' and password='"+password.Text+"'",con);

            SqlCommand cmd = new SqlCommand();
          //  cmd.Connection = conn.connectionDB();
            cmd.CommandText = "select * from users_admins where username='" + username.Text + "' and password='" + password.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string comboBoxUserValue = comoboxType.SelectedItem.ToString();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["usertype"].ToString() == comboBoxUserValue)
                    {
                        if(comoboxType.SelectedIndex == 0)
                        {
            //                firstname = Convert.ToString(dt.Rows[i][1]);
            //                User.firstN = firstname;

             //               pForm.Show();
                            this.Hide();
                        }
                        else if(comoboxType.SelectedIndex == 1)
                        {
                //            firstname = Convert.ToString(dt.Rows[i][2]);
                //            User.firstN = firstname;

                 //           fAdmin.Show();
                            this.Hide();
                        }
                        else 
                        {
                            //fSuper.Show();
                           // firstname = Convert.ToString(dt.Rows[i][3]);

                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username/Password Gabim!", "Provoni Perseri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }else
            {
                MessageBox.Show("Username/Password Gabim!", "Provoni Perseri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        public void pastro()
        {
            username.Text = "";
            username.Focus();
            password.Text = "password";
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

    }
}
