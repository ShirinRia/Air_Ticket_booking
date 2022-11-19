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
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }
        string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM about where Id='" + label23.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            label22.Text = sdr["Name"].ToString();
                            label24.Text = sdr["Intake"].ToString();
                            label25.Text = sdr["email"].ToString();
                            label26.Text = sdr["phone"].ToString();
                            label27.Text = sdr["dept"].ToString();
                            label28.Text = sdr["Section"].ToString();                         
                        }
                    }
                    con.Close();
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM about where Id='" + label13.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            label14.Text = sdr["Name"].ToString();                           
                            label12.Text = sdr["Intake"].ToString();
                            label11.Text = sdr["email"].ToString();
                            label10.Text = sdr["phone"].ToString();
                            label9.Text = sdr["dept"].ToString();
                            label8.Text = sdr["Section"].ToString();   
                        }
                    }
                    con.Close();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM about where Id='" + label34.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            label35.Text = sdr["Name"].ToString();
                            label33.Text = sdr["Intake"].ToString();
                            label32.Text = sdr["email"].ToString();
                            label31.Text = sdr["phone"].ToString();
                            label30.Text = sdr["dept"].ToString();
                            label29.Text = sdr["Section"].ToString();   
                        }
                    }
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
