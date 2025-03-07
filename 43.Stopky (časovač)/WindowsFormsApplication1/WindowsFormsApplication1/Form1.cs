using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int minuty, sekundy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START")
            {
                timer1.Enabled = true;
                button1.Text = "STOP";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "START";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(label1.Text + Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Text = "START";
            label1.Text = "0:0";
            textBox1.Clear();
            minuty = 0;
            sekundy = 0; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sekundy = sekundy + 1;
            if (sekundy == 60)
            {
                minuty = minuty + 1;
                sekundy = 0;
            }
            label1.Text = Convert.ToString(minuty) + ':' + Convert.ToString(sekundy);
        }
    }
}
