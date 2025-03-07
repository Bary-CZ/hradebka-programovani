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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(label1.Text + Environment.NewLine);
        }
    }
}
