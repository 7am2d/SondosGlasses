using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace SondosGlasses
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitBotton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        private void LoginBotton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From USERS where username='" + txtUsername.Text + "' and password='" + txtPassword.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Globals.User = txtUsername.Text;
                this.Hide();
                MessageBox.Show("Welcome " + Globals.User);
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Invalide Username or Password");
                txtPassword.Clear();
                txtPassword.Focus();
            }
             
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From USERS where username='" + txtUsername.Text + "' and password='" + txtPassword.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Globals.User = txtUsername.Text;
                this.Hide();
                MessageBox.Show("Welcome " + Globals.User);
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Invalide Username or Password");
                txtPassword.Clear();
                txtPassword.Focus();
            }
            }
        }
    }
}
