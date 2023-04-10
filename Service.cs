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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MBC-PC;Initial Catalog=Salon_Stelata;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
             txtcusno.Text="";
             rbbd.Checked = false;
             rbft.Checked = false;
             rbbt.Checked = false;
             rbhd.Checked = false;
             txtadate.Text = "";
             txtatime.Text = "";     
             cmbq.Text = "";
             txtcusno.Focus();
        }

        private void Service_Load(object sender, EventArgs e)
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
            try
            { 
                
            string cusno =  txtcusno.Text;
            string QQ;
            if (rbbd.Checked)
            { QQ = "Bridal Dressing"; }
            else if (rbft.Checked)
            { QQ = "Facial threatment"; }
            else if (rbbt.Checked)
            { QQ = "Body threatment"; }
            else
            { QQ = "Hair and Dressing"; }

            string adate = txtadate.Text;
            string atime = txtatime.Text;
            string Q =cmbq.Text;


            string query_insert = "insert into Service values('" + cusno + "','" + QQ +"','"+ adate + "','" + atime + "','" + Q + "')";

            SqlCommand cmd = new SqlCommand(query_insert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtcusno.Text = "";
            rbbd.Checked = false;
            rbft.Checked = false;
            rbbt.Checked = false;
            rbhd.Checked = false;
            txtadate.Text = "";
            txtatime.Text = "";
            cmbq.Text = "";
            txtcusno.Focus();
       

            }
            catch (Exception ex) { MessageBox.Show("Error while Saving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            finally { con.Close(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
