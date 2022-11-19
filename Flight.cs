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
    public partial class Flight : UserControl
    {
        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        public Flight()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData10();
        }

        private void Flight_Load(object sender, EventArgs e)
        {
           // LoadData();
        }
        DataTable dt;
        private void LoadData()
        {
            con.dataGet("Select * from [reg2]   ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["F_NO"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Origin"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Destination"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Departure_Time"].ToString();
                //dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
            }
        }
        private void LoadData10()
        {
            con.dataGet("Select * from reg2 where Destination = '" +textBox11.Text + "' and Origin = '" + textBox12.Text + "'  ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["F_NO"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Origin"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Destination"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Departure_Time"].ToString();
                //dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
            }
        }
        private void LoadData1()
        {
            con.dataGet("Select * from reg2 where Airline = '" + radioButton4.Text + "'  ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["F_NO"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Origin"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Destination"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Departure_Time"].ToString();
                //dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
            }
        }
        private void LoadData2()
        {
            con.dataGet("Select * from reg2 where Airline = '" + radioButton5.Text + "'  ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["F_NO"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Origin"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Destination"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Departure_Time"].ToString();
                //dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
            }
        }
        private void LoadData3()
        {
            con.dataGet("Select * from reg2 where Airline = '" + radioButton6.Text + "'  ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["F_NO"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Origin"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Destination"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Departure_Time"].ToString();
                //dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
            }
        }
        private void LoadData4()
        {
            con.dataGet("Select * from reg2 where Airline = '" + radioButton8.Text + "'  ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["F_NO"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Origin"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Destination"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Departure_Time"].ToString();
                //dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
            }
        }
        private void LoadData5()
        {
            con.dataGet("Select * from reg2 where Airline = '" + radioButton7.Text + "'  ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["F_NO"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Origin"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Destination"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Departure_Time"].ToString();
                //dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            LoadData2();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            LoadData3();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            LoadData4();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            LoadData5();
        }
    }
}
