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
    public partial class Student_signup : Form
    {
        
        public Student_signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("stusignup", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USN", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Branch", textBox3.Text);
            cmd.Parameters.AddWithValue("@Semester", textBox4.Text);
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

        private void Student_signup_Load(object sender, EventArgs e)
        {

        }
    }
}
