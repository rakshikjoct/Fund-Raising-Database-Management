using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charity_Database_Management
{
    public partial class AboutUs : UserControl
    {
        private static AboutUs instance;
        public static AboutUs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AboutUs();
                }
                return instance;
            }
        }
        public AboutUs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
