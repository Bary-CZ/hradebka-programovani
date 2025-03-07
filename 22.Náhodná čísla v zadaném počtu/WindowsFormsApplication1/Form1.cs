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
        Random nahodne = new Random();
        int dolni, horni, pocet, pocitadlo, cislo, minimum, maximum;
        double soucet, prumer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soucet = 0;
            textBox4.Clear();
            dolni = Convert.ToInt16(textBox1.Text);
            horni = Convert.ToInt16(textBox2.Text);
            pocet = Convert.ToInt16(textBox3.Text);
            for (pocitadlo = 1; pocitadlo <= pocet; pocitadlo = pocitadlo + 1)
            {
                cislo = nahodne.Next(dolni, horni + 1);
                textBox4.AppendText(Convert.ToString(cislo) + Environment.NewLine);
                soucet = soucet + cislo;
                if (pocitadlo == 1)
                {
                    minimum = cislo;
                    maximum = cislo;
                }
                else
                {
                    if (cislo < minimum) minimum = cislo;
                    if (cislo > maximum) maximum = cislo;
                }
            }
            prumer = Math.Round(soucet / pocet, 2);
            label4.Text = "Minimum je: " + Convert.ToString(minimum);
            label5.Text = "Maximum je: " + Convert.ToString(maximum);
            label6.Text = "Průměr je: " + Convert.ToString(prumer);
        }
    }
}
