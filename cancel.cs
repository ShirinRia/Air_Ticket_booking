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
    public partial class cancel : UserControl
    {

        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();

        DBAccess con = new DBAccess();
        public cancel()
        {
            InitializeComponent();
        }

        private void cancel_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM pmnt WHERE pmnt.bid =  '" + textBox8.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            textBox1.Text = sdr["name"].ToString();
                            textBox9.Text = sdr["date"].ToString();
                           // textBox6.Text = sdr["time"].ToString();
                            textBox10.Text = sdr["airp"].ToString();
                            textBox2.Text = sdr["airl"].ToString();
                            textBox5.Text = sdr["fno"].ToString();
                            textBox1.Text = sdr["fno"].ToString();
                            textBox7.Text = sdr["Amount"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d1, e1, l;
            double.TryParse(textBox3.Text, out d1);
            double.TryParse(textBox4.Text, out e1);
            l = d1 * e1;
            textBox7.Text = l.ToString("c").Remove(0, 1);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string variables = "BID,name,fno,arl,arp,date,tno,upp,fare,cmnt";
            string values = "'" + textBox8.Text + "','" + textBox1.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox2.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','"  + textBox3.Text + "','" + textBox7.Text + "','" + textBox4.Text + "'"; //TextBox
            con.dataSend("INSERT INTO cncl(" + variables + ")  values ( " + values + " )");
            /* bt login = new bt();
             showControl(login);*/
            MessageBox.Show("Successfully canceled your ticket");
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM pmnt WHERE pmnt.bid =  '" + textBox8.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            textBox1.Text = sdr["name"].ToString();
                            textBox9.Text = sdr["date"].ToString();
                           /// textBox6.Text = sdr["time"].ToString();
                            textBox10.Text = sdr["airp"].ToString();
                            textBox2.Text = sdr["airl"].ToString();
                            textBox5.Text = sdr["fno"].ToString();
                            // textBox7.Text = sdr["AIRP"].ToString();
                            textBox4.Text = sdr["fare"].ToString();
                            textBox11.Text = sdr["Amount"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double d1, e1, l,k1,k;
            double.TryParse(textBox3.Text, out d1);
            double.TryParse(textBox4.Text, out e1);
            l = d1 * e1;
            double.TryParse(textBox11.Text, out k1);
            k = k1 - l;
            textBox7.Text = k.ToString("c").Remove(0, 1);
            //textBox1.Text = l.ToString("c").Remove(0, 1);
        }
    }
}

