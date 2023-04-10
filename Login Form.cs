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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DPMMCAVB;Initial Catalog=Salon_Stelata;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string pass = txtpassword.Text;
            if (email == "umistelata@gmail.com" && pass == "UMI123")
            {
                MessageBox.Show("Loging Success!", "Login Salon Stelata System", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Menu f2 = new Menu();
                this.Hide();
                f2.Show();

            }
            else if (email == "dula@gmail.com" && pass == "DULA123")
            {
                MessageBox.Show("Loging Success!", "Login Salon Stelata System", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Menu f2 = new Menu();
                this.Hide();
                f2.Show();
            }
            else if (email == "dew@gmail.com" && pass == "DEW123")
            {
                MessageBox.Show("Loging Success!", "Login Salon Stelata System", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Menu f2 = new Menu();
                this.Hide();
                f2.Show();
            }

            else if (email == "kavi@gmail.com" && pass == "KAVI123")

            {
                MessageBox.Show("Loging Success!", "Login Salon Stelata System", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Menu f2 = new Menu();
                this.Hide();
                f2.Show();
            }
            else if (email == "ima@gmail.com" && pass == "IMA123")
            {
                MessageBox.Show("Loging Success!", "Login Salon Stelata System", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Menu f2 = new Menu();
                this.Hide();
                f2.Show();
            }


            else { MessageBox.Show("Login not Success !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { string email = txtemail.Text;
            string pass = txtpassword.Text;
                string query_insert ="insert into Loging_Detail values('"+email+"','"+pass+"')";
                    SqlCommand cmd=new SqlCommand(query_insert,con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully", "Saving Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    txtemail.Text = "";
                    txtpassword.Text = "";

            }
            catch (Exception ex) { MessageBox.Show("Error while saving data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation); }
            finally { con.Close(); }
        }
    }
}
