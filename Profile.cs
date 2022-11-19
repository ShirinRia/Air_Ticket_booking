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
using System.IO;

namespace Airline
{
    public partial class Profile : UserControl
    {

        DBAccess obj1 = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        DataTable dt;
        USER obj2 = new USER();
        USER u= new USER(); 
        public Profile(USER us)
        {
            InitializeComponent();
            this.u = us;
        }
        string constr = @"Data Source=DESKTOP-0H6LJPC\SQLEXPRESS;Initial Catalog=new1;Integrated Security=True";
        private void Profile_Load(object sender, EventArgs e)
        {
            panel2.Hide(); panel3.Hide();panel5.Hide();   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        public void Control()
        {
            SqlConnection conj = new SqlConnection(constr);
            conj.Open();
            SqlCommand cmd = conj.CreateCommand();
            var image = new ImageConverter().ConvertTo(pictureBox2.Image, typeof(Byte[]));
            cmd.Parameters.AddWithValue("@image", image);
            cmd.CommandText = "update pic SET image = @image where username = '" + u.button2.Text + "'";
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Photo Successfully changed");
            else
                MessageBox.Show("failed to change photo");
            conj.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE regi SET Name ='" + textnm.Text + "',Address ='" + textadd.Text + "', Email ='" + textem.Text + "',Gender='" + textBox2.Text + "'  where Phone='" + label14.Text + "'");
                MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                            textnm.Text = label16.Text;
                            textem.Text = label13.Text;
                            textadd.Text = label15.Text;
                            textpn.Text = label14.Text;
                            textBox2.Text = label3.Text;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name,Email,Address,Phone,DOB,Pass,Gender,jn FROM regi WHERE username =  '" + u.button2.Text + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            label16.Text = sdr["Name"].ToString();
                            label13.Text = sdr["Email"].ToString();
                            label15.Text = sdr["Address"].ToString();
                            label14.Text = sdr["Phone"].ToString();
                            label5.Text = sdr["DOB"].ToString();
                            textBox4.Text = sdr["Pass"].ToString();
                            label3.Text = sdr["Gender"].ToString();
                            label1.Text = sdr["jn"].ToString();                           
                        }
                    }
                    con.Close();
                    SqlCommand cmdh = con.CreateCommand();
                    con.Open();                    
                    cmdh.CommandText = "SELECT pic.image FROM regi,pic where regi.username ='" + u.button2.Text + "' and regi.username=pic.username";
                    SqlDataReader r = cmdh.ExecuteReader();
                    if (r.Read())
                    {
                        MemoryStream s = new MemoryStream(r.GetSqlBytes(0).Buffer);
                        pictureBox1.Image = Image.FromStream(s);
                    }
                    con.Close();
                }
            }
        }
        private void textnm_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel1.Hide();
            panel2.Hide();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }
        private void LoadData()        
        {
            con.dataGet("Select  * from pmnt where phone =  '" + label14.Text + "'");
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
                dataGridView1.Rows[n].Cells["dgap"].Value = row["P_no"].ToString();
                dataGridView1.Rows[n].Cells["airp"].Value = row["airp"].ToString();
                dataGridView1.Rows[n].Cells["airl"].Value = row["airl"].ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.FileName = "";
            od.Filter = "Supported Images|*.jpg;*.jpe;*.png";
            if (od.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(od.FileName);
                Control();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Hide();
            panel1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Hide();
            panel1.Show();
        }

        private void textem_TextChanged(object sender, EventArgs e)
        {
            label13.Text = textem.Text;
        }
        private void textem_Enter(object sender, EventArgs e)
        {
        }
        private void textem_Leave(object sender, EventArgs e)
        {
        }
        private void textnm_TextChanged_1(object sender, EventArgs e)
        {
            label16.Text = textnm.Text;
        }
        private void textadd_TextChanged(object sender, EventArgs e)
        {
            
            label15.Text = textadd.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox3.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To change your password", "Change", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.dataSend("UPDATE regi SET Pass='" + textBox1.Text + "' where Phone='" + label14.Text + "'");
                    MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter Correct Password");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }
    }
}
