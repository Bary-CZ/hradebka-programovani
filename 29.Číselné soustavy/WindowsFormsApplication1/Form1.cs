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
        int desitkove, zaklad, zbytek, pocet;
        string vysledek;
        int[] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            desitkove = Convert.ToInt16(textBox1.Text);
            zaklad = Convert.ToInt16(textBox2.Text);
            vysledek = "";
            while (desitkove != 0)
            {
                zbytek = desitkove % zaklad;
                desitkove = desitkove / zaklad;
                vysledek = Convert.ToString(zbytek) +' '+ vysledek;
            }
            label4.Text = vysledek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desitkove = Convert.ToInt16(textBox1.Text);
            zaklad = Convert.ToInt16(textBox2.Text);
            vysledek = "";
            pocet = 0;
            pole = new int[pocet];
            while (desitkove != 0)
            {
                zbytek = desitkove % zaklad;
                desitkove = desitkove / zaklad;
                pocet = pocet + 1;
                Array.Resize(ref pole, pocet);
                pole[pocet-1] = zbytek;
            }
            Array.Reverse(pole);
            foreach (int cislo in pole) vysledek = vysledek + Convert.ToString(cislo) + ' ';
            label4.Text = vysledek;
        }
    }
}
