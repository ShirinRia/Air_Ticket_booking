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
using System.Configuration;

namespace Airline
{
    public partial class cbox : UserControl
    {
        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        DataTable dt;
        public cbox()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            con.dataGet("Select * from [cmplt]");
            dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgsl"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgu"].Value = row["username"].ToString();
                dataGridView1.Rows[n].Cells["dgc"].Value = row["compliaint"].ToString();  
            }
        }
        private void cbox_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
