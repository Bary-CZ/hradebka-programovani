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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START")
            {
                label3.Text = textBox1.Text;
                timer1.Interval = Convert.ToInt16(textBox2.Text);
                button1.Text = "STOP";
                timer1.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                button1.Text = "START";
                timer1.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (label3.Left > Size.Width) label3.Left = -label3.Size.Width;
                if (label3.Right < 0) label3.Left = Size.Width;
            }
            else
            {
                if (radioButton1.Checked == true && label3.Right == Size.Width) radioButton2.Checked = true;
                if (radioButton2.Checked == true && label3.Left == 0) radioButton1.Checked = true;
            }
            if (radioButton1.Checked == true) label3.Left = label3.Left + 1; else label3.Left = label3.Left - 1;
        }
    }
}
