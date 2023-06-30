using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaruthiTextiles
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category c = new Category();
            c.ShowDialog();
            c = null;
            this.Show();
            //MessageBox.Show("Goto Catagory");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Goto text");
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock s = new Stock();
            s.ShowDialog();
            s=null;
            this.Show();
            //MessageBox.Show("Goto Stock");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goto Customer");
        }

        private void clock_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnVendor_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Goto Vendor");
        }

        private void catogory1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
