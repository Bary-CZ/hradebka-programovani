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
        int i;
        string cesta, nazev;
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
            if(checkBox1.Checked == true)
            for (i = 0; i < textBox3.Lines.Count(); i = i + 1)
            {
                if (textBox4.Lines[i] == label1.Text && textBox5.Lines[i] == "start") Process.Start(textBox3.Lines[i]);
                if (textBox4.Lines[i] == label1.Text && textBox5.Lines[i] == "stop")
                    foreach (Process proces in Process.GetProcessesByName(textBox3.Lines[i])) proces.Kill();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cesta = textBox1.Text;
            Process.Start(cesta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nazev = textBox2.Text;
            foreach (Process proces in Process.GetProcessesByName(nazev)) proces.Kill();
        }
    }
}
