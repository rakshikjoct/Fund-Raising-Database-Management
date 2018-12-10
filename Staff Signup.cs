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

namespace Charity_Database_Management
{
    public partial class Staff_Signup : Form
    {
        public Staff_Signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Staffsignup", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Branch", textBox3.Text);
            cmd.Parameters.AddWithValue("@Designation", textBox4.Text);
            cmd.Parameters.AddWithValue("@PhoneNo", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email_id", textBox6.Text);
            cmd.Parameters.AddWithValue("@Password", textBox7.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sign Up Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID" + ex);
            }
            con.Close();
            introduction obj1 = new introduction();
            this.Hide();
            obj1.Show();


        }

        private void Staff_Signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
