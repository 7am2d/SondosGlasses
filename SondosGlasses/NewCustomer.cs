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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreateButt_Click(object sender, EventArgs e)
        {
            string name, phone, Age;
            name = txtName.Text;
            phone = txtPhone.Text;
            Age = age.Text;

            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;            // <== lacking
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Customer  VALUES (@un,@ph, @ag)";
                    command.Parameters.AddWithValue("@un", name);
                    command.Parameters.AddWithValue("@ph",phone );
                    command.Parameters.AddWithValue("@ag", Age);
                    try
                    {
                        con.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("تمت إضافة العميل");
                        this.Hide();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("خطأ في حفظ البيانات");
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
