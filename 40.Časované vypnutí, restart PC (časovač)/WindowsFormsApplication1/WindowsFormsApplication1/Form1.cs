using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //připsat

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now);
            if (textBox1.Text == label1.Text)
                if (radioButton1.Checked == true) Process.Start("shutdown", "/s /t 0");
                else Process.Start("shutdown", "/r /t 0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) Process.Start("shutdown", "/s /t 0");
            else Process.Start("shutdown", "/r /t 0");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button1.Enabled = true;
                textBox1.Enabled = false;
                textBox1.Clear();
            }
            else
            {
                button1.Enabled = false;
                textBox1.Enabled = true;
                textBox1.Text = label1.Text;
            }
        }
    }
}
