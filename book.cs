using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
namespace Airline
{
    public partial class book : UserControl
    {
        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        USER h;
        public book(USER hr)
        {
            InitializeComponent();
            comboBox1.Text = string.Empty;
            this.h = hr;
        }
        void fillcombo()
        {
           
            comboBox1.Text = string.Empty;
            comboBox12.Text = string.Empty;
            string con = "Data Source=DESKTOP-0H6LJPC\\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
            string q = "Select F_NO,Airport,Airline from reg2 where Destination ='" + comboBox2.Text + "' or Destination ='" + comboBox3.Text + "'";
            SqlConnection con1 = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(q, con1);
            SqlDataReader reader;
            try
            {
                con1.Open();
                reader = cmd.ExecuteReader();
                comboBox12.Items.Clear();
                comboBox1.Items.Clear();
                while (reader.Read())
                {

                    string sName = reader["F_NO"].ToString();
                    string sNam = reader["Airport"].ToString();
                    string sNa = reader["Airline"].ToString();
                    comboBox1.Items.Add(sNam);
                    comboBox12.Items.Add(sName);
                    comboBox8.Items.Add(sNa);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void book_Load(object sender, EventArgs e)
        {
            label19.Hide(); label19.Text = h.button2.Text;
            //  timer1.Enabled = true;
            // label3.Text = DateTime.Now.ToLongDateString();
            timer2.Enabled = true;

            label3.Text = DateTime.Now.ToLongTimeString();
        }
            string c;
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            c = "Domestic";
            comboBox2.Hide();
            comboBox3.Show();
            button8.Hide();
            button1.Show();
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            fillcombo();
           
            comboBox1.Text = string.Empty;
        }
         private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            c = "International";

            comboBox3.Hide();
            comboBox2.Show();
            button1.Hide();
            button8.Show();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
        }
        public void showControl(Control control)
        {
            content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            content.Controls.Add(control);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (dateTimePicker1.Text == DateTime.Now.ToLongDateString())
            {
                string variables = "username,Frm,des,date1,F_type,F_no,Class,AIRP,Time,AIRL,Type,Bo_id";
                string values = "'" + h.button2.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + comboBox9.Text + "','" + comboBox12.Text + "','" + comboBox10.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox8.Text + "','" + c + "','" + label3.Text + "'"; //TextBox
                con.dataSend("INSERT INTO book(" + variables + ")  values ( " + values + " )");
                paymnt login = new paymnt(this);
                showControl(login);
            }
            else
                MessageBox.Show("Invalid Date");
        }
        private void content_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void textfn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM reg2 WHERE reg2.F_NO =  '" + comboBox12.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            textBox1.Text = sdr["Departure_Time"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (dateTimePicker1.Text == DateTime.Now.ToLongDateString())
            {
                string variables = "username,Frm,des,date1,F_type,F_no,Class,AIRP,Time,AIRL,Type,Bo_id";
                string values = "'" + h.button2.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','"  + comboBox9.Text + "','" + comboBox12.Text + "','" + comboBox10.Text + "','" + comboBox1.Text + "','" +textBox1.Text + "','" + comboBox8.Text + "','" + c + "','" + label3.Text + "'"; //TextBox
                con.dataSend("INSERT INTO book(" + variables + ")  values ( " + values + " )");
                paymnt login = new paymnt(this);
                showControl(login);
            }
            else
                MessageBox.Show("Invalid Date");
        }

        private void comboBox8_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           /* string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM reg2 WHERE reg2.Airline =  '" + comboBox8.Text + "' and reg2.Destination =  '" + comboBox2.Text + "'or reg2.Destination =  '" + comboBox3.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            textBox1.Text = sdr["Departure_Time"].ToString();
                        }
                    }
                    con.Close();
                }
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
