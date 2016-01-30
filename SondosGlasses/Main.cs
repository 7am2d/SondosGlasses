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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        
        private void Main_Load(object sender, EventArgs e)
        {
            DataGriVie();
        }

        public void DataGriVie()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();

            }
            sda = new SqlDataAdapter("SELECT Id, Type, Model, Price, Quantity FROM Glasses", con);
            dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Globals.CID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Globals.CN = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Globals.CA = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Globals.CP = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Customer ss = new Customer();
            ss.Show();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void إضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer ss = new NewCustomer();
            ss.Show();
        }

        private void إضافةنضارةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGlass ss = new AddGlass();
            ss.Show();
        }

        private void butNCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer ss = new NewCustomer();
            ss.Show();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewUser ss = new NewUser();
            ss.Show();
        }

        private void buGlass_Click(object sender, EventArgs e)
        {
            AddGlass ss = new AddGlass();
            ss.Show();
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            MessageBox.Show("Good Bye ;");
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            DataGriVie();
        }

        private void حولالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void إدارةالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
