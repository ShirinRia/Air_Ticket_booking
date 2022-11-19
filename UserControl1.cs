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
    public partial class UserControl1 : UserControl
    {
        admin a;
        DBAccess con = new DBAccess();
        DataTable dt;
        public UserControl1(admin a1)
        {
            InitializeComponent();
            this.a = a1;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            con.dataGet("Select * from regi  where pan = '" + label1.Text + "' ");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = row["Id"].ToString();
                dataGridView1.Rows[n].Cells["dgfn"].Value = row["Username"].ToString();
                dataGridView1.Rows[n].Cells["name"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["gn"].Value = row["Gender"].ToString();
                dataGridView1.Rows[n].Cells["dgon"].Value = row["Address"].ToString();
                dataGridView1.Rows[n].Cells["dgds"].Value = row["Phone"].ToString();
                dataGridView1.Rows[n].Cells["dgdp"].Value = row["Email"].ToString();
                
                dataGridView1.Rows[n].Cells["dgat"].Value = row["DOB"].ToString();
                dataGridView1.Rows[n].Cells["dgf"].Value = row["jn"].ToString();
            }
        }
    }
}
