using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Traffic_light_lbl_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Traffic_light_lbl.BackColor = Color.Yellow;
                    break;
                case MouseButtons.Right:
                    Traffic_light_lbl.BackColor = Color.Green;
                    break;
            }
        }
    }
}
