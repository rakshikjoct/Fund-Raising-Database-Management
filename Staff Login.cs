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
    public partial class Staff_Login : Form
    {
        public Staff_Login()
        {
            InitializeComponent();
            label3.Hide();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        

        private String getUsername()
        {
            //fetch data from database
            con.Open();
            String syntax = "SELECT Email_id FROM College_Staff where Email_id= '" + textBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private String getPassword()
        {
            //fetch data from database
            con.Open();
            String syntax = "SELECT Password FROM College_Staff where Password= '" + textBox2.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uname = getUsername(), Upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            
            try
            {
               
                
                if (name.Equals(Uname) && pass.Equals(Upass))
                {
                    //login
                    label3.Hide();
                    MessageBox.Show("Login success");
                    introduction obj = new introduction();
                    this.Hide();
                    obj.Show();
                }
                else
                {
                    //dont login
                    label3.Show();

                }
            }
            catch (Exception es)
            {

                MessageBox.Show("invalid credentials" + es);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }





    /*internal class SqlCommand
    {
        private string syntax;
        private SqlConnection con;

        public SqlCommand(string syntax, SqlConnection con)
        {
            this.syntax = syntax;
            this.con = con;
        }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }

    internal class maskedTextBox1
    {
        public static string Text { get; internal set; }
    }*/
}
   

