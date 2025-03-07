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
        int pocet, c1, c2, c3, i;
        int[] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pocet = Convert.ToInt16(numericUpDown1.Value);
            if (pocet == 1) textBox1.AppendText("1 - 0" + Environment.NewLine); 
            else
            {
                c1 = 0;
                c2 = 1;
                textBox1.AppendText("1 - " + Convert.ToString(c1) + Environment.NewLine + "2 - " + Convert.ToString(c2) + Environment.NewLine);
                for (i = 3; i <= pocet; i = i + 1)
                {
                    c3 = c1 + c2;
                    textBox1.AppendText(Convert.ToString(i) + " - " + Convert.ToString(c3) + Environment.NewLine);
                    c1 = c2;
                    c2 = c3;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pocet = Convert.ToInt16(numericUpDown1.Value);
            if (pocet == 1) textBox1.AppendText("1 - 0" + Environment.NewLine);
            else
            {
                pole = new int[pocet];
                pole[0] = 0;
                pole[1] = 1;
                for (i = 2; i < pocet; i = i + 1) pole[i] = pole[i - 1] + pole[i - 2];
                for (i = 0; i < pole.Length; i = i + 1) textBox1.AppendText(Convert.ToString(i + 1) + " - " + Convert.ToString(pole[i]) + Environment.NewLine);
            }
        }
    }
}
