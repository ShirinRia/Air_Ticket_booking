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
    public partial class feedback : UserControl
    {
        DBAccess con = new DBAccess();
        DataTable dt;
        public feedback()
        {
            InitializeComponent();
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            con.dataGet("Select * from pmnt");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgsl"].Value = n + 1;                
                dataGridView1.Rows[n].Cells["nm"].Value = row["name"].ToString();               
                dataGridView1.Rows[n].Cells["email"].Value = row["email"].ToString();                
                dataGridView1.Rows[n].Cells["fd"].Value = row["feed"].ToString();
            }
        }
    }
}
