using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class bag : UserControl
    {
        public bag()
        {
            InitializeComponent();
        }
        public void showControl(Control control)
        {
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel2.Controls.Add(control);

        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bag3 login = new bag3();
            showControl(login);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
