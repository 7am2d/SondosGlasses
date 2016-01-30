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
namespace SondosGlasses
{
    public partial class NewUser : Form
    {
        
        
        public NewUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, pass, phone, type;

            name = Username.Text;
            pass = Password.Text;
            phone = Phone.Text;
            type = tpybecom.Text;
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;            // <== lacking
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into USERS  VALUES (@un, @pw, @ph, @ty)";
                    command.Parameters.AddWithValue("@un", name);
                    command.Parameters.AddWithValue("@pw", pass);
                    command.Parameters.AddWithValue("@ph", phone);
                    command.Parameters.AddWithValue("@ty", type);

                    try
                    {
                        con.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("New User Added");
                        this.Hide();
                        
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error to save on database");
                        con.Close();
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            
        }
    }
}
