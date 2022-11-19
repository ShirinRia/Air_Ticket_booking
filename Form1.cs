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
using System.IO;

namespace Airline
{
    public partial class Form1 : Form
    {
        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();       
        public Form1()
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
            panel4.Height = 40;
            panel2.Show();
            content.Hide();
            content1.Hide();
           panel5.Hide();
            Flight login = new Flight();
            showControl(login);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = 40; content.Hide(); home login = new home();
            showControl(login);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin f = new admin();
            f.Show();
            this.Hide();
            content1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            content.Show();
            content1.Hide();
            panel2.Hide();
            panel4.Height = 40;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            content.Hide();
            content1.Hide();
            panel5.Hide();
            panel4.Height = 40;
            content.BackColor = Color.FromArgb(20, 0, 0, 0);
            content1.BackColor = Color.FromArgb(20, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(20, 0, 0, 0); panel6.Height = 40;           
        }
        private void button8_Click(object sender, EventArgs e)
        {
        }
        string gender;
        private void button7_Click(object sender, EventArgs e)
        {
            if (textpass.Text == textBox1.Text)
            {
                string variables = "Name,username,Address,Phone,Email,DOB,Gender,jn,Pass,pan"; /*Database Column Name*/
                string values = "'" + textnm.Text + "','" + textun.Text + "','" + textadd.Text + "','" + textpn.Text + "','" + textem.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + dateTimePicker2.Text + "','" + textpass.Text + "','" + button10.Text + "'"; //TextBox
                DBAccess con = new DBAccess();
                con.dataGet("Select * from regi where Username ='" + textun.Text + "' or Phone = '" + textpn.Text + "'   or Email = '" + textem.Text + "'  ");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Username or Phone Number or Email alraedy Exists");
                }
                else
                {
                    con.dataSend("INSERT INTO regi(" + variables + ")  values ( " + values + " )");
                    MessageBox.Show("Record Saved Successfully");
                }
            }
            else
                MessageBox.Show("Password doesn't match");
        }
        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button12.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button9.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel5.Show();
            content.Hide();
            content1.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from regi where username ='" + textBox3.Text + "' and pass = '" + textBox2.Text + "'and pan = '" + button11.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                admin f = new admin();
                f.Show();
                this.Hide();
                content1.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from regi where username ='" + textBox3.Text + "' and pass = '" + textBox2.Text + "' and pan = '" + button10.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                USER f = new USER(this);
                f.Show();
                this.Hide();
                content1.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            content.Hide();
            content1.Hide();
            panel5.Hide(); panel2.Show();// panel4.Height = 40;
            if (panel4.Height == 240)
            {
                panel4.Height = 40;
            }
            else
            {
                panel6.Height = 40;
                panel4.Height = 240;
            }
            

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {
            panel4.Height = 40;
             
        }

        private void content1_Paint(object sender, PaintEventArgs e)
        {
            panel4.Height = 40;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Username or Email")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Username or Email";
                textBox3.ForeColor = Color.Silver;
            }
        }



        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {

            
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textnm_Enter(object sender, EventArgs e)
        {
            if (textnm.Text == "Full Name")
            {
                textnm.Text = "";
                textnm.ForeColor = Color.Black;
               
            }
        }

        private void textnm_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Full Name";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            content.Hide(); content1.Show(); panel4.Height = 40;panel2.Hide();
        }

        private void textun_Enter(object sender, EventArgs e)
        {
            if (textun.Text == "Username")
            {
                textun.Text = "";
                textun.ForeColor = Color.Black;
            }
        }

        private void textun_Leave(object sender, EventArgs e)
        {
            if (textun.Text == "")
            {
                textun.Text = "Username";
                textun.ForeColor = Color.Silver;
            }
        }

        private void textadd_Enter(object sender, EventArgs e)
        {
            if (textadd.Text == "Address")
            {
                textadd.Text = "";
                textadd.ForeColor = Color.Black;
            }
        }

        private void textpn_Enter(object sender, EventArgs e)
        {
            if (textpn.Text == "Contact No.")
            {
                textpn.Text = "";
                textpn.ForeColor = Color.Black;
            }
        }

        private void textadd_Leave(object sender, EventArgs e)
        {
            if (textadd.Text == "")
            {
                textadd.Text = "Address";
                textadd.ForeColor = Color.Silver;
            }
        }

        private void textpn_Leave(object sender, EventArgs e)
        {
            if (textadd.Text == "")
            {
                textadd.Text = "Contact No.";
                textadd.ForeColor = Color.Silver;
            }
        }

        private void textem_Enter(object sender, EventArgs e)
        {
            if (textem.Text == "Email")
            {
                textem.Text = "";
                textem.ForeColor = Color.Black;
            }
        }

        private void textem_Leave(object sender, EventArgs e)
        {
            if (textem.Text == "")
            {
                textem.Text = "Contact No.";
                textem.ForeColor = Color.Silver;
            }
        }

        private void textpass_Enter(object sender, EventArgs e)
        {
            if (textpass.Text == "Password")
            {
                textpass.Text = "";
                textpass.ForeColor = Color.Black;
                textpass.PasswordChar = '*';
            }
        }

        private void textpass_Leave(object sender, EventArgs e)
        {
            if (textpass.Text == "")
            {
                textpass.Text = "Password";
                textpass.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Confirm Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Confirm Password";
                textBox1.ForeColor = Color.Silver;
            }
        }

       
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
        string conn = "Data Source=DESKTOP-0H6LJPC\\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
        private void button4_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.FileName = "";
            od.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (od.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(od.FileName);
                Control();
            }           
        }
        public void Control()
        {
            SqlConnection conj = new SqlConnection(conn);
            conj.Open();
            SqlCommand cmd = conj.CreateCommand();
            var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@username", textun.Text);
            cmd.CommandText = "INSERT INTO pic (image,username) VALUES (@image,@username)";
            if (cmd.ExecuteNonQuery() > 0)

            {
            }
            else
                MessageBox.Show("failed to load image");
            conj.Close();
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
          
        }
        private void textBox4_Enter_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "Contact No.")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
               
            }
        }
        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_Leave_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Contact No.";
                textBox4.ForeColor = Color.Silver;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Username or Email")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;

            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Username or Email";
                textBox5.ForeColor = Color.Silver;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            SqlConnection conh = new SqlConnection(@"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True");
            conh.Open();
            SqlCommand cmd =new SqlCommand("Select * from regi where username ='" + textBox5.Text + "' and Phone = '" + textBox4.Text + "'",conh);           
            SqlDataReader dr = cmd.ExecuteReader();           
            if (dr.Read())
            {
                MessageBox.Show("PASS:" + dr.GetValue(9).ToString());
                panel5.Hide();
                content.Show();
            }
            else
            {
                MessageBox.Show("Not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           panel5.Hide();
            content.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            content.Hide();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            panel2.Show(); content.Hide();
            content1.Hide();
            panel5.Hide();
            if (textpass.Text == textBox1.Text)
            {
                string variables = "Name,username,Address,Phone,Email,DOB,Gender,jn,Pass,pan"; /*Database Column Name*/
                string values = "'" + textnm.Text + "','" + textun.Text + "','" + textadd.Text + "','" + textpn.Text + "','" + textem.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + dateTimePicker2.Text + "','" + textpass.Text + "','" + button11.Text + "'"; //TextBox
                DBAccess con = new DBAccess();
                con.dataGet("Select * from regi where Username ='" + textun.Text + "' or Phone = '" + textpn.Text + "'   or Email = '" + textem.Text + "'  ");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Username or Phone Number or Email alraedy Exists");
                }
                else
                {
                    con.dataSend("INSERT INTO regi(" + variables + ")  values ( " + values + " )");
                    MessageBox.Show("Record Saved Successfully");
                }
            }
            else
                MessageBox.Show("Password doesn't match");
        }
        private void textnm_TextChanged(object sender, EventArgs e)
        {

        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (panel6.Height == 160)
            {
                panel6.Height = 40;
            }
            else
            {
                panel4.Height = 40;
                panel6.Height = 160;
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            content.Hide();
            content1.Hide();
            panel5.Hide(); panel2.Show(); About login = new About();
            showControl(login);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            content.Hide();
            content1.Hide();
            panel5.Hide(); panel2.Show(); hlp login = new hlp();
            showControl(login);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            food login = new food(); panel6.Height = 40;
            showControl(login);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            panel6.Height = 40; bag login = new bag();
            showControl(login);
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel2.Show();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            med login = new med();
            showControl(login); panel6.Height = 40;
        }
        private void button19_Click(object sender, EventArgs e)
        {

        }
    }  
}
