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
        string[] mnozina1, mnozina2, vysledek;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mnozina1 = new string[textBox1.Lines.Length];
            mnozina2 = new string[textBox2.Lines.Length];
            mnozina1 = textBox1.Lines;
            mnozina2 = textBox2.Lines;
            if (radioButton1.Checked == true) vysledek = mnozina1.Intersect(mnozina2).ToArray();
                else if (radioButton2.Checked == true) vysledek = mnozina1.Union(mnozina2).ToArray();
                    else vysledek = mnozina1.Except(mnozina2).ToArray();
            textBox3.Lines = vysledek;
        }
    }
}
