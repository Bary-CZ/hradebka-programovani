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
        double prumer;
        int[] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            dolni = Convert.ToInt16(textBox1.Text);
            horni = Convert.ToInt16(textBox2.Text);
            pocet = Convert.ToInt16(textBox3.Text);
            pole = new int[pocet];
            for (pocitadlo = 0; pocitadlo < pocet; pocitadlo = pocitadlo + 1)
            {
                cislo = nahodne.Next(dolni, horni + 1);
                pole[pocitadlo] = cislo;
            }
            foreach (int cislo in pole) textBox4.AppendText(Convert.ToString(cislo) + Environment.NewLine);
            minimum = pole.Min();
            maximum = pole.Max();
            prumer = Math.Round(pole.Average(), 2);       
            pole = pole.Distinct().ToArray();
            Array.Sort(pole);
            label4.Text = "Minimum je: " + Convert.ToString(minimum);
            label5.Text = "Maximum je: " + Convert.ToString(maximum);
            label6.Text = "Průměr je: " + Convert.ToString(prumer);
            textBox5.AppendText("Setříděno" + Environment.NewLine);
            textBox5.AppendText("bez duplicit" + Environment.NewLine);
            textBox5.AppendText("-------------------" + Environment.NewLine);
            foreach (int cislo in pole) textBox5.AppendText(Convert.ToString(cislo) + Environment.NewLine);
        }
    }
}
