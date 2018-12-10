using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Charity_Database_Management
{
    public partial class MakeaDonation : UserControl
    {
        private static MakeaDonation instance;
        public static MakeaDonation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MakeaDonation();
                }
                return instance;
            }
        }
        public MakeaDonation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        private void MakeaDonation_Load(object sender, EventArgs e)
        {
            
        }
       
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DonationAdd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DNo", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email_id", textBox5.Text);
            cmd.Parameters.AddWithValue("@CNo", textBox4.Text);
           
            cmd.Parameters.AddWithValue("@Donated_Amt", textBox3.Text);
            cmd.Parameters.AddWithValue("@Mode_of_Payment", textBox11.Text);
            cmd.Parameters.AddWithValue("@Card_No", textBox7.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donation Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID" + ex);
            }
            con.Close();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DonationAdd3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DNum", textBox12.Text);
            cmd.Parameters.AddWithValue("@Email_id", textBox6.Text);
            cmd.Parameters.AddWithValue("@CNo", textBox10.Text);
            cmd.Parameters.AddWithValue("@Donated_Item", textBox9.Text);
            cmd.Parameters.AddWithValue("@No_of_Items", textBox8.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donation Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID" + ex);
            }
            con.Close();
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
