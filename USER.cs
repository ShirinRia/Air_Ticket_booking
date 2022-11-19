using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject;
using System.Data.SqlClient;

namespace Airline
{
    public partial class USER : Form
    {
        Form1 h;
        public USER(Form1 he)
        {
            InitializeComponent();
            this.h = he;
        }
        public USER()
        {
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Height = 40;
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = 40; 
            Flight login = new Flight();
            showControl(login);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = 40;
            home login = new home();
            showControl(login);
        }
        private void USER_Load(object sender, EventArgs e)
        {
            button2.Text = h.textBox3.Text;
            panel3.Height = 40; 
            panel4.Height = 40; 
            panel2.Height = 40;           
        }
        public void showControl(Control control)
        {
            panel4.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel4.Controls.Add(control);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            panel3.Height = 40; 
            book login = new book(this);
            showControl(login);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 120)
            {
                panel3.Height = 40;
            }
            else
            {
                panel2.Height = 40;
                panel3.Height = 120;
            }
        }      
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Profile login = new Profile(this);
            showControl(login);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            panel3.Height = 40; 
            cancel login = new cancel();
            showControl(login);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            bt login = new bt(this);
            showControl(login);
        }
        private void button10_Click(object sender, EventArgs e)
        {
           hlp login = new hlp();
            showControl(login);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            About login = new About();
            showControl(login);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 160)
            {
                panel2.Height = 40;
            }
            else
            {
                panel3.Height = 40;
                panel2.Height = 160;
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            food login = new food();
            showControl(login); panel2.Height = 40;
        }
        private void button12_Click(object sender, EventArgs e)
        {
           bag login = new bag(); panel2.Height = 40;
            showControl(login);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            med login = new med(); panel2.Height = 40;
            showControl(login);
        }
    }   
}
