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
    public partial class af : UserControl
    {
        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        DataTable dt;
        public af()
        {
            InitializeComponent();
        }
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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Fare_Type"].ToString();
                dataGridView1.Rows[n].Cells["flt"].Value = row["Flight_type"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
            }
        }
        private void LoadData1()
        {
            con.dataGet("Select * from reg2 where Destination='" + textBox1.Text + "'  ");
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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Fare_Type"].ToString();
                dataGridView1.Rows[n].Cells["flt"].Value = row["Flight_type"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string variables = "F_NO,Origin,Destination,Departure_Time,Arrival_Time,Fare,Airport,Airline,Fare_Type,Flight_type"; /*Database Column Name*/
            string values = "'" + textfn.Text + "','" + textfr.Text + "','" + textto.Text + "','" + textdt.Text + "','" + textart.Text + "','" + textf.Text + "','" + textat.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "'"; //TextBox
            DBAccess con = new DBAccess();
            con.dataSend("INSERT INTO reg2(" + variables + ")  values ( " + values + " )");
            MessageBox.Show("Record Saved Successfully");
            LoadData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE  reg2 SET Origin ='" + textfr.Text + "',Destination ='" + textto.Text + "',Airline ='" + comboBox2.Text + "',Departure_Time ='" + textdt.Text + "',Arrival_Time='" + textart.Text + "',Fare='" + textf.Text + "',Airport='" + textat.Text + "' where F_NO='" + textfn.Text + "'");
                MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearData();
                LoadData();

            }
        }

        private void af_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textart_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textfr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textfn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from reg2 where F_NO='" + textfn.Text + "'");
                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            LoadData6();
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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Fare_Type"].ToString();
                dataGridView1.Rows[n].Cells["flt"].Value = row["Flight_type"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();

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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Fare_Type"].ToString();
                dataGridView1.Rows[n].Cells["flt"].Value = row["Flight_type"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();

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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Fare_Type"].ToString();
                dataGridView1.Rows[n].Cells["flt"].Value = row["Flight_type"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Fare_Type"].ToString();
                dataGridView1.Rows[n].Cells["flt"].Value = row["Flight_type"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
            }
        }
        private void LoadData6()
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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["Airport"].ToString();
                dataGridView1.Rows[n].Cells["arl"].Value = row["Airline"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Fare_Type"].ToString();
                dataGridView1.Rows[n].Cells["flt"].Value = row["Flight_type"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["Arrival_Time"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["Fare"].ToString();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Destination")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Destination";
                    textBox1.ForeColor = Color.Black;

                }
            
        }
    }
}
