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
    public partial class bt : UserControl
    {
        DBAccess con = new DBAccess();
        DataTable dt; 
        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
        USER u;
        public bt(USER u1)
        {
            InitializeComponent();
            this.u = u1;
        }

        private void bt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string variables = "username,compliaint";
            string values = "'" +u.button2.Text + "','"+ richTextBox1.Text + "'"; //TextBox
            con.dataSend("INSERT INTO cmplt(" + variables + ")  values ( " + values + " )");
 
        }
    }
}
