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
        string text;
        int soucet;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            text = textBox1.Text;
            if (text.Length == 1) textBox2.AppendText(text);
            else
            {
                while (text.Length > 1)
                {
                    soucet = 0;
                    foreach (char znak in text)
                        soucet = soucet + Convert.ToInt16(Convert.ToString(znak));
                    textBox2.AppendText(Convert.ToString(soucet) + Environment.NewLine);
                    text = Convert.ToString(soucet);
                }
            }
        }
    }
}
