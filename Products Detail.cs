using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Products_Detail : Form
    {
        public Products_Detail()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MBC-PC;Initial Catalog=Salon_Stelata;Integrated Security=True");
        private void Products_Detail_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            this.Hide();
            f2.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try { 
            string pname = txtpname.Text;
            string edate = txtedate.Text;
            string pprice = txtpprice.Text;
            string qun = txtqun.Text;

            string query_insert = "insert into Products values('" + pname + "','" + edate + "','" + pprice + "','" + qun + "')";
            SqlCommand cmd = new SqlCommand(query_insert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtpname.Text="";
            txtedate.Text="";
            txtpprice.Text="";
            txtqun.Text="";
            txtpname.Focus();

            }
            catch (Exception ex) { MessageBox.Show("Error while saving data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpname.Text = "";
            txtedate.Text = "";
            txtpprice.Text = "";
            txtqun.Text = "";
            txtpname.Focus();

        }
    }
}
