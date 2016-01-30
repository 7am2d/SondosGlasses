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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
            textCustomer.Text = Globals.CN;
            textDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void CreateButt_Click(object sender, EventArgs e)
        {

            string date, doctor, sphr, sphl, clyr, clyl, axr, axl, sphr_, sphl_, clyr_, clyl_, axr_, axl_;
            int CID = Int32.Parse(Globals.CID);                         //<---- Customer ID
            date = DateTime.Today.ToString("dd-MM-yyyy");//<---- add Date
            doctor = txtDr.Text;
            sphr = txtSphR.Text;
            sphl = txtSphL.Text;
            clyr = txtClyR.Text;
            clyl = txtClyL.Text;
            axr = txtAxR.Text;
            axl = txtAxL.Text;
            sphr_ = txtSphR_.Text;
            sphl_ = txtSphL_.Text;
            clyr_ = txtClyR_.Text;
            clyl_ = txtClyL_.Text;
            axr_ = txtAxR_.Text;
            axl_ = txtAxL_.Text;
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    

                    command.Connection = con;           
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO Prescript VALUES( 1, '2016-1-11', 'محمد حامد', 1, '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1')";
                    //command.CommandText = "INSERT INTO Prescript VALUES( @CID, '@Da', '@Dr', @sr, @sl, @cr, @cl, @xr, @xl, @sr_, @sl_, @cr_, @cl_, @xr_, @xl_)";
                    command.Parameters.AddWithValue("@CID", CID);
                    command.Parameters.AddWithValue("@Da", date);
                    command.Parameters.AddWithValue("@Dr", doctor);
                    command.Parameters.AddWithValue("@sr", sphr);
                    command.Parameters.AddWithValue("@sl", sphl);
                    command.Parameters.AddWithValue("@cr", clyr);
                    command.Parameters.AddWithValue("@cl", clyl);
                    command.Parameters.AddWithValue("@xr", axr);
                    command.Parameters.AddWithValue("@xl", axl);
                    command.Parameters.AddWithValue("@sr_", sphr_);
                    command.Parameters.AddWithValue("@sl_", sphl_);
                    command.Parameters.AddWithValue("@cr_", clyr_);
                    command.Parameters.AddWithValue("@cl_", clyl_);
                    command.Parameters.AddWithValue("@xr_", axr_);
                    command.Parameters.AddWithValue("@xl_", axl_);
                    try
                    {
                        con.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("تم تسجيل الكشف");
                        this.Hide();
                    }

                    catch (SqlException)
                    {
                        MessageBox.Show("Error to save on database");
                    }

                    finally
                    {
                        con.Close();
                    }
                }
            }


        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}