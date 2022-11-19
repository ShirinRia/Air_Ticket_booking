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
    public partial class bag3 : UserControl
    {
        public bag3()
        {
            InitializeComponent();
        }
        public void showControl(Control control)
        {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel1.Controls.Add(control);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bag2 login = new bag2();
            showControl(login);
        }
    }
}
