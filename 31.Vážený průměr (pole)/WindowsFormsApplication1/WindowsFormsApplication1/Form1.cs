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
        int i;
        double citatel, jmenovatel, cislo, vaha, prumer;
        string[] cisla, vahy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            citatel = 0;
            jmenovatel = 0;
            for (i = 0; i < textBox1.Lines.Length; i = i + 1)
            {
                cislo = Convert.ToDouble(textBox1.Lines[i]);
                vaha = Convert.ToDouble(textBox2.Lines[i]);
                citatel = citatel + cislo * vaha;
                jmenovatel = jmenovatel + vaha;
            }
            prumer = Math.Round(citatel / jmenovatel, 2);
            label3.Text = "Vážený průměr je: " + Convert.ToString(prumer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            citatel = 0;
            jmenovatel = 0;
            cisla = new string[textBox1.Lines.Length];
            vahy = new string[textBox2.Lines.Length];
            cisla = textBox1.Lines;
            vahy = textBox2.Lines;
            for (i = 0; i < cisla.Length; i = i + 1)
            {
                cislo = Convert.ToDouble(cisla[i]);
                vaha = Convert.ToDouble(vahy[i]);
                citatel = citatel + cislo * vaha;
                jmenovatel = jmenovatel + vaha;
            }
            prumer = Math.Round(citatel / jmenovatel, 2);
            label3.Text = "Vážený průměr je: " + Convert.ToString(prumer);
        }
    }
}
