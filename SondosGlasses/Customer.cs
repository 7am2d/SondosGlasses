using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SondosGlasses
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            CName.Text = Globals.CN;
            CAge.Text = Globals.CA;
            CPhone.Text = Globals.CP;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription ss = new Prescription();
            ss.Show();
        }
    }
}
