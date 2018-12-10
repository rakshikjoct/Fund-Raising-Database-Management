using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charity_Database_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Login obj = new Student_Login();
            this.Hide();
            obj.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_signup obj1 = new Student_signup();
            this.Hide();
            obj1.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff_Login obj1 = new Staff_Login();
            this.Hide();
            obj1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff_Signup obj1 = new Staff_Signup();
            this.Hide();
            obj1.Show();

        }
    }
}
