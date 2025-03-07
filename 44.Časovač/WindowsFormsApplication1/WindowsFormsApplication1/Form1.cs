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
            label1.Text = textBox1.Text + ':' + textBox2.Text;
            minuty = Convert.ToInt16(textBox1.Text);
            sekundy = Convert.ToInt16(textBox2.Text);
            progressBar1.Value = 0;
            progressBar1.Maximum = sekundy + minuty * 60;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "START")
            {
                timer1.Enabled = true;
                button1.Enabled = false;
                button2.Text = "STOP";
            }
            else
            {
                timer1.Enabled = false;
                button1.Enabled = true;
                button2.Text = "START";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sekundy = sekundy - 1;
            progressBar1.Value = progressBar1.Value + progressBar1.Step;
            if (sekundy == -1)
            {
                minuty = minuty - 1;
                sekundy = 59;
            }
            label1.Text = Convert.ToString(minuty) + ':' + Convert.ToString(sekundy);
            if (sekundy == 0 && minuty == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;
                button2.Text = "START";
                Console.Beep(392, 300);
                Console.Beep(330, 300);
                Console.Beep(262, 300);
            }
        }
    }
}
