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
    public partial class TR : UserControl
    {
        DBAccess con = new DBAccess();
        DataTable dt;
        public TR()
        {
            InitializeComponent();
        }

        private void TR_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()        
        {
            con.dataGet("Select  * from pmnt");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgsl"].Value = n + 1;
                dataGridView1.Rows[n].Cells["bi"].Value = row["bid"].ToString();
               dataGridView1.Rows[n].Cells["dgon"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["fno"].ToString();
                dataGridView1.Rows[n].Cells["dgt"].Value = row["too"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["date"].ToString();
                dataGridView1.Rows[n].Cells["fr"].Value = row["frm"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["time"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["phone"].ToString();
               dataGridView1.Rows[n].Cells["dgf"].Value = row["email"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["P_no"].ToString();
                dataGridView1.Rows[n].Cells["ps"].Value = row["ps"].ToString();
                dataGridView1.Rows[n].Cells["airp"].Value = row["airp"].ToString();
                dataGridView1.Rows[n].Cells["airl"].Value = row["airl"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Amount"].ToString();
            }
        }
        private void LoadData1()
        {
            con.dataGet("Select  * from pmnt where bid='" + textBox2.Text + "'");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgsl"].Value = n + 1;
                dataGridView1.Rows[n].Cells["bi"].Value = row["bid"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["fno"].ToString();
                dataGridView1.Rows[n].Cells["dgt"].Value = row["too"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["date"].ToString();
                dataGridView1.Rows[n].Cells["fr"].Value = row["frm"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["time"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["phone"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["email"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["P_no"].ToString();
                dataGridView1.Rows[n].Cells["ps"].Value = row["ps"].ToString();
                dataGridView1.Rows[n].Cells["airp"].Value = row["airp"].ToString();
                dataGridView1.Rows[n].Cells["airl"].Value = row["airl"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Amount"].ToString();
            }
        }
        private void LoadData2()
        {
            con.dataGet("Select  * from pmnt where name='" + textBox2.Text + "'");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgsl"].Value = n + 1;
                dataGridView1.Rows[n].Cells["bi"].Value = row["bid"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["fno"].ToString();
                dataGridView1.Rows[n].Cells["dgt"].Value = row["too"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["date"].ToString();
                dataGridView1.Rows[n].Cells["fr"].Value = row["frm"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["time"].ToString();
                dataGridView1.Rows[n].Cells["dgat"].Value = row["phone"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["email"].ToString();
                dataGridView1.Rows[n].Cells["dgap"].Value = row["P_no"].ToString();
                dataGridView1.Rows[n].Cells["ps"].Value = row["ps"].ToString();
                dataGridView1.Rows[n].Cells["airp"].Value = row["airp"].ToString();
                dataGridView1.Rows[n].Cells["airl"].Value = row["airl"].ToString();
                dataGridView1.Rows[n].Cells["frt"].Value = row["Amount"].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from pmnt where bid='" + textBox1.Text + "'");
                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.Text=="Booking ID")
            {
                LoadData1();
            }
            if (comboBox1.Text == "Name")
            {
                LoadData2();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Booking ID")
            {
                LoadData1();
            }
            if (comboBox1.Text == "Name")
            {
                LoadData2();
            }
        }
    }
}
