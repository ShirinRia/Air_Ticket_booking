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
    public partial class cl : UserControl
    {
        DBAccess con = new DBAccess();
        DataTable dt;
        public cl()
        {
            InitializeComponent();
        }

        private void cl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()   
        {
            con.dataGet("Select  * from cncl");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgsl"].Value = n + 1;
                dataGridView1.Rows[n].Cells["bi"].Value = row["BID"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["fno"].ToString();
              //  dataGridView1.Rows[n].Cells["dgt"].Value = row["dest"].ToString();
               // dataGridView1.Rows[n].Cells["fr"].Value = row["frm"].ToString();
                dataGridView1.Rows[n].Cells["airl"].Value = row["arl"].ToString();
                dataGridView1.Rows[n].Cells["airp"].Value = row["arp"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["date"].ToString();
               // dataGridView1.Rows[n].Cells["dgdp"].Value = row["time"].ToString();
                //dataGridView1.Rows[n].Cells["dgap"].Value = row["tno"].ToString();
                dataGridView1.Rows[n].Cells["up"].Value = row["fare"].ToString();
                dataGridView1.Rows[n].Cells["cmnt"].Value = row["cmnt"].ToString();
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[1].Cells["bi"].Value.ToString();
            /*textName.Text = dataGridView1.SelectedRows[0].Cells["dgName"].Value.ToString();
            textIntake.Text = dataGridView1.SelectedRows[0].Cells["dgIntake"].Value.ToString();
            textSection.Text = dataGridView1.SelectedRows[0].Cells["dgSection"].Value.ToString();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                 con.dataSend("Delete from pmnt where bid='" + textBox1.Text + "'");
                con.dataSend("Delete from book where B_Id='" + textBox1.Text + "'");
                 con.dataSend("Delete from cncl where BID='" + textBox1.Text + "'");
                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE pmnt SET Amount ='" + textBox2.Text + "' where bid ='" + textBox1.Text + "'");
              //  con.dataSend("UPDATE  cncl SET where BID='" + textBox1.Text + "'");
                MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearData();
                LoadData();

            }
        }
    }
}
