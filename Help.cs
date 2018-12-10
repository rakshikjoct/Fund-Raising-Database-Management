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
    public partial class Help : UserControl
    {
        private static Help instance;
        public static Help Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Help();
                }
                return instance;
            }
        }
        public Help()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
