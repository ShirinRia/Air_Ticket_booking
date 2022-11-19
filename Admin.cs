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
using DatabaseProject;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Airline
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public void showControl(Control control)
        {
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel2.Controls.Add(control);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Height =40;
            panel3.Height = 40;
            panel4.Height = 40; af login = new af();
            showControl(login);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40; Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40; Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 120)
            {
                panel3.Height = 40;
            }
            else
            {
                panel3.Height = 120;
                panel4.Height = 40;
                panel6.Height = 40;
            }
        }
        private void admin_Load(object sender, EventArgs e)
        {
            panel3.Height = 40; panel4.Height = 40; panel6.Height = 40;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel3.Height = 40; 
            TR login = new TR();
            showControl(login);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Height = 40; 
            userlist login = new userlist(this);
            showControl(login);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel4.Height == 160)
            {
                panel4.Height = 40;
            }
            else
            {
                panel4.Height = 160;
                panel3.Height = 40;
                panel6.Height = 40;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel3.Height = 40;
            cl login = new cl();
            showControl(login);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = 40;
            UserControl1 login = new UserControl1(this);
            showControl(login);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel6.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40; About login = new About();
            showControl(login);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel6.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40; hlp login = new hlp();
            showControl(login);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (panel6.Height == 160)
            {
                panel6.Height = 40;
            }
            else
            {
                panel6.Height = 160;
                panel3.Height = 40;
                panel4.Height = 40;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel6.Height = 40; 
            food login = new food();
            showControl(login);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel6.Height = 40;
            med login = new med();
            showControl(login);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel6.Height = 40; 
           
            bag login = new bag();
            showControl(login);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Height = 40; 
            feedback login = new feedback();
            showControl(login);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40; 
            cbox login = new cbox();
            showControl(login);
        }
    }
}
