using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Detail f4 = new Customer_Detail();
            this.Hide();
            f4.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Products_Detail f6 = new Products_Detail();
            this.Hide();
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service f5 = new Service();
            this.Hide();
            f5.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff_Detail f3 = new Staff_Detail();
            this.Hide();
            f3.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
