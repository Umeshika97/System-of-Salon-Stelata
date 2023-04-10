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
    public partial class Staff_Detail : Form
    {
        public Staff_Detail()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DPMMCAVB;Initial Catalog=Salon_Stelata;Integrated Security=True");
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Detail_Load(object sender, EventArgs e)
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
            try { string fname = txtfname.Text;
            string email = txtemail.Text;
            string sid = txtsid.Text;
            string gender; if (rbmale.Checked)
            { gender = "Male"; }
            else
            { gender = "Female"; }
            
            int tp = Convert.ToInt32(txttp.Text);
            string query_insert = "insert into Staff_Detail values('"+fname+"','"+email+"','"+sid+"','"+gender+"','"+tp+"')";
            SqlCommand cmd = new SqlCommand(query_insert, con);
            con.Open();
            cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Saving Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                txtfname.Text = "";
                txtemail.Text = "";
                txtsid.Text = "";
                rbmale.Checked = false;
                rbfemale.Checked = false;
                txttp.Text = "";

            }
            catch (Exception ex) { MessageBox.Show("Error while saving data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation); }
            finally { con.Close(); }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtsearch.Text; 
                string fname = txtfname.Text;
                string email = txtemail.Text;
                string sid = txtsid.Text;
                string gender; if (rbmale.Checked)
                { gender = "Male"; }
                else
                { gender = "Female"; }
                int tp = Convert.ToInt32(txttp.Text);
                string query_update = "Update  Staff_Detail set Email='" + email +"' ,Tp= + '"+ tp +"'where Email ='"+ search +"'";

                SqlCommand cmd1 = new SqlCommand(query_update, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Update Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtfname.Text = "";
                txtemail.Text = "";
                txtsid.Text = "";
                rbmale.Checked = false;
                rbfemale.Checked = false;
                txttp.Text = "";
                txtsearch.Text = "";
            }
            catch (Exception ex) { MessageBox.Show("Error while updating data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally {con.Close(); }
        }
    
public  string Search { get; set; }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try{
                string search =txtsearch.Text;
                string query_delete = "Delete from Staff_Detail where Email='" +search+"'";

                SqlCommand cmd1 = new SqlCommand(query_delete, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to delete this Data?","Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                txtfname.Text = "";
                txtemail.Text = "";
                txtsid.Text = "";
                rbmale.Checked = false;
                rbfemale.Checked = false;
                txttp.Text = "";
                txtsearch.Text = "";
            }
            catch (Exception ex) { MessageBox.Show("Error while Deleting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            finally{ con.Close();}

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try{ string search =txtsearch.Text;
                string query_select = "select*from Staff_Detail where Email='" +search+"'";
                 SqlCommand cmd = new SqlCommand(query_select, con);
                con.Open();
               SqlDataReader r=cmd.ExecuteReader();
                while(r.Read())
                {txtfname.Text = r[0].ToString();
                txtemail.Text = r[1].ToString();
                txtsid.Text = r[2].ToString();
                     string gender=r[3].ToString();
                    if (gender == "Male")
                { rbmale.Checked=true; }
                else
                { rbfemale.Checked=true; }
                    txttp.Text = r[4].ToString();

                }
}
            catch (Exception ex) { MessageBox.Show("Error while searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            
            finally{con.Close();}
        }}
}
