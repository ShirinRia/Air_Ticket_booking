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
    public partial class paymnt : UserControl
    {

        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
       
        DBAccess con = new DBAccess();
        book h1;
        public paymnt(book he)
        {
            InitializeComponent();
            this.h1 = he;
          
        }
        public void showControl(Control control)
        {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel1.Controls.Add(control);

        }
        string c;
      
        private void paymnt_Load(object sender, EventArgs e)
        {
            label26.Text = h1.label3.Text;
            panel4.Hide();
            string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT regi.Name,regi.Phone,regi.Email,book.Frm,book.des,book.F_no,book.boid,book.date1,book.Time,book.AIRL,book.AIRP,book.class,reg2.Fare,reg2.Destination,book.Type FROM regi,book,reg2 WHERE regi.username =  '" + h1.label19.Text + "' and  book.date1='" + h1.dateTimePicker1.Text + "' and book.AIRL='" + h1.comboBox8.Text + "'and reg2.Fare_Type='" + h1.comboBox9.Text + "'and book.Bo_id='" + h1.label3.Text + "' and reg2.Destination=book.des"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            textBox4.Text = sdr["Name"].ToString();
                            textBox11.Text = sdr["Phone"].ToString();
                            textBox18.Text = sdr["Email"].ToString();
                            label21.Text = sdr["Frm"].ToString();
                            label20.Text = sdr["des"].ToString();
                            textBox17.Text = sdr["boid"].ToString();
                            textBox5.Text = sdr["date1"].ToString();
                            textBox6.Text = sdr["Time"].ToString();
                            textBox12.Text = sdr["AIRL"].ToString();
                            textBox7.Text = sdr["AIRP"].ToString();
                            textBox16.Text = sdr["class"].ToString();
                            textBox9.Text = sdr["Fare"].ToString();
                            textBox19.Text = sdr["Type"].ToString();
                            textBox3.Text = sdr["F_no"].ToString();

                        }
                    }
                    con.Close();
                }

            }
        }
        private void label24_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            double d1, e1, l;
            double.TryParse(textBox10.Text, out d1);
            double.TryParse(textBox9.Text, out e1);
            l = d1 * e1;
            textBox8.Text = l.ToString("c").Remove(0, 1);
            textBox13.Text = textBox8.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           /* if (textBox13.Text != "")
            {
                c = "paid";
            }
            else
                c = "Not Paid";
            string variables = "c_no,c_h_na,Amount, P_no,PS,bid,fno,name,email,phone,frm,too,date,time,airp,airl,class,type,fare";
            string values = "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox13.Text + "','" + textBox10.Text + "','" + c + "','" + textBox17.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox18.Text + "','" + textBox11.Text + "','" + label21.Text + "','" + label20.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox12.Text + "','" + textBox16.Text + "','" + textBox19.Text + "','" + textBox9.Text + "'"; //TextBox
            con.dataSend("INSERT INTO pmnt(" + variables + ")  values ( " + values + " )");*/
            panel2.Hide();
            panel4.Show();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double d1, e1, l;
            double.TryParse(textBox10.Text, out d1);
            double.TryParse(textBox9.Text, out e1);
            l = d1 * e1;
            textBox8.Text = l.ToString("c").Remove(0, 1);
            textBox13.Text = textBox8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                c = "paid";
            }
            else
                c = "Not Paid";
            string variables = "c_no,c_h_na,Amount, P_no,PS,bid,fno,name,email,phone,frm,too,date,time,airp,airl,class,type,fare,feed";
            string values = "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox13.Text + "','" + textBox10.Text + "','" + c + "','" + textBox17.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox18.Text + "','" + textBox11.Text + "','" + label21.Text + "','" + label20.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox12.Text + "','" + textBox16.Text + "','" + textBox19.Text + "','" + textBox9.Text + "','" + richTextBox2.Text + "'"; //TextBox
            con.dataSend("INSERT INTO pmnt(" + variables + ")  values ( " + values + " )"); 
            MessageBox.Show("Successfully booked your ticket");
            print f = new print(this);
            f.Show();
            this.Hide();
            /*prnt login = new prnt(this);
            showControl(login);*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label25.Text = h1.label19.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USER f = new USER();
            f.Show();
            this.Hide();
        }
    }
}
