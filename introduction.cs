using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Charity_Database_Management
{
    public partial class introduction : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public introduction()
        {
            InitializeComponent();
            //Intializations for sliding Panel
            isSlidingPannelExpanded = true;
            expandSlidingPannelGUI();
        }

        private void introduction_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidingPannelGUI()
        {
            //gui adjustments for expanding
            button2.Text = "Causes We Support";
            button5.Text = "Donors";
            button4.Text = "About Us";
            button5.Text = "Help";
            /*SlidingPanel_ToggelButton.Image=Properties.Resources.
            *button2.Image=null;
             * button3.Image=null;
             * button4.Image=null;
             * button5.Image=null;*/
        }

        public void retractSlidingGUI()
        {
            button2.Text = "";
            button5.Text = "";
            button4.Text = "";
            button5.Text = "";
            /*SlidingPanel_ToggelButton.Image=Properties.Resources.
            *button2.Image=Properties.Resources.;
             * button3.Image=Properties.Resources. ;
             * button4.Image=Properties.Resources.;
             * button5.Image=Properties.Resources.;*/
        }
        bool isSlidingPannelExpanded;
        const int MaxSliderWidth=240;
        const int MinSliderWidth=50;


        private void button1_Click(object sender, EventArgs e)
        {
            if(isSlidingPannelExpanded)
            {
                //retract pannel
            }
            timer1.Start();
           
        }

        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract pannel
                SlidingPanel.Width -= 30;
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPannelExpanded = false;
                    timer1.Stop();
                    retractSlidingGUI();
                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    //stop retract
                    isSlidingPannelExpanded = true;
                    timer1.Stop();
                    expandSlidingPannelGUI();
                    this.Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(! panel2.Controls.Contains(CausesWeSupprot.Instance))
            {
                panel2.Controls.Add(CausesWeSupprot.Instance);
                CausesWeSupprot.Instance.Dock = DockStyle.Fill;
                CausesWeSupprot.Instance.BringToFront();
            }
            else
            {
                CausesWeSupprot.Instance.BringToFront();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Donors.Instance))
            {
                panel2.Controls.Add(Donors.Instance);
                Donors.Instance.Dock = DockStyle.Fill;
                Donors.Instance.BringToFront();
            }
            else
            {
                Donors.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!panel2.Controls.Contains(AboutUs.Instance))
            {
                panel2.Controls.Add(AboutUs.Instance);
                AboutUs.Instance.Dock = DockStyle.Fill;
                AboutUs.Instance.BringToFront();
            }
            else
            {
                AboutUs.Instance.BringToFront();
            }
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Help.Instance))
            {
                panel2.Controls.Add(Help.Instance);
                Help.Instance.Dock = DockStyle.Fill;
                Help.Instance.BringToFront();
            }
            else
            {
                Help.Instance.BringToFront();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(MakeaDonation.Instance))
            {
                panel2.Controls.Add(MakeaDonation.Instance);
                MakeaDonation.Instance.Dock = DockStyle.Fill;
                MakeaDonation.Instance.BringToFront();
            }
            else
            {
                MakeaDonation.Instance.BringToFront();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Details.Instance))
            {
                panel2.Controls.Add(Details.Instance);
                Details.Instance.Dock = DockStyle.Fill;
                Details.Instance.BringToFront();
            }
            else
            {
                Details.Instance.BringToFront();
            }
        }
    }
}
