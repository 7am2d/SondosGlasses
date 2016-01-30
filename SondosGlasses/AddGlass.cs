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
    public partial class AddGlass : Form
    {
        public AddGlass()
        {
            InitializeComponent();
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    string type, model, cost, price, quantity;
                    
                    type = combType.Text;
                    model = combModel.Text;
                    cost = textCost.Text;
                    price = textPrice.Text;
                    quantity = textQuantity.Text;
                    
                    command.Connection = con;            // <== lacking
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Glasses  VALUES (@ty, @mod, @co, @pri, @qua)";
                    command.Parameters.AddWithValue("@ty", type);
                    command.Parameters.AddWithValue("@mod", model);
                    command.Parameters.AddWithValue("@co", cost);
                    command.Parameters.AddWithValue("@pri", price);
                    command.Parameters.AddWithValue("@qua", quantity);
                    try
                    {
                        con.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("تمت إضافة النظارة");
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

