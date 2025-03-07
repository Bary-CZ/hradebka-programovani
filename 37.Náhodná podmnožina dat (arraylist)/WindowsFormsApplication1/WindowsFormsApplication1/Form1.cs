using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // připsat tento řádek

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList data = new ArrayList();
        Random nahodne = new Random();
        int pocet, i, cislo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Clear();
            pocet = Convert.ToInt16(textBox3.Text);
            if (pocet > textBox1.Lines.Length)
                MessageBox.Show("Počet prvků podmnožiny nesmí být větší než počet prvků množiny.");
            else
            {
                foreach (string text in textBox1.Lines) data.Add(text);
                for (i = 1; i <= pocet; i = i + 1)
                {
                    cislo = nahodne.Next(0, data.Count);
                    textBox2.AppendText(data[cislo] + Environment.NewLine);
                    data.RemoveAt(cislo);
                }
                textBox2.AppendText("------------" + Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
