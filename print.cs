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
using Microsoft.VisualBasic;
using System.IO;

namespace Airline
{
    public partial class print : Form
    {
        DBAccess con = new DBAccess();
        DataTable dt;paymnt u;
        public print(paymnt u1)
        {
            InitializeComponent();
            this.u = u1;
        }

        private void print_Load_1(object sender, EventArgs e)
        {
           /* Panel p = new Panel();
            this.Controls.Add(p);
            Graphics g = p.CreateGraphics();
            Size s = this.ClientSize;
            b = new Bitmap(s.Width, s.Height, g);
            g = Graphics.FromImage(b);
            Point p1 = PointToScreen(p.Location);
            g.CopyFromScreen(p1.X, p1.Y, 0, 0, s);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            button1.Hide();*/

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {

           /* double d1, e1, l;
            double.TryParse(label7.Text, out d1);
            double.TryParse(label9.Text, out e1);
            l = d1 - e1;
            label11.Text = l.ToString("c").Remove(0, 1);*/
        }
        Bitmap b;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(b, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            Panel p = new Panel();
            this.Controls.Add(p);
            Graphics g = p.CreateGraphics();
            Size s = this.ClientSize;
            b = new Bitmap(s.Width, s.Height, g);
            g = Graphics.FromImage(b);
            Point p1 = PointToScreen(p.Location);
            g.CopyFromScreen(p1.X, p1.Y, 0, 0, s);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label4.Text = u.textBox4.Text;
            label22.Text = u.label21.Text;
            label7.Text = u.label20.Text;

            label18.Text = u.textBox5.Text;
            label24.Text = u.textBox3.Text;
            label16.Text = u.textBox17.Text;

            label28.Text = label4.Text;
            label27.Text = label22.Text;
            label29.Text = label7.Text;

            label14.Text = label18.Text;
            label15.Text = label24.Text;
            label26.Text = label16.Text;
            string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name,Email,Address,Phone,DOB,Pass,Gender,jn FROM regi WHERE username =  '" + u.label25.Text + "'"))
                {                   
                    SqlCommand cmdh = con.CreateCommand();
                    con.Open();                    
                    cmdh.CommandText = "SELECT pic.image FROM regi,pic where regi.username ='" + u.label25.Text + "' and regi.username=pic.username";
                    SqlDataReader r = cmdh.ExecuteReader();
                    if (r.Read())
                    {
                        MemoryStream s = new MemoryStream(r.GetSqlBytes(0).Buffer);
                        pictureBox1.Image = Image.FromStream(s);
                    }
                    con.Close();
                }
            }
        }
   private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
