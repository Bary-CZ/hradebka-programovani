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
        int cislo1, cislo2, c1, c2, pomocna, zbytek, nsn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cislo1 = Math.Abs(Convert.ToInt16(textBox1.Text));
            cislo2 = Math.Abs(Convert.ToInt16(textBox2.Text));
            c1 = cislo1;
            c2 = cislo2;
            if (c1 < c2)
            {
                pomocna = c1;
                c1 = c2;
                c2 = pomocna;
            }
            while (c2 != 0)
            {
                zbytek = c1 % c2;
                c1 = c2;
                c2 = zbytek;
            }
            nsn = cislo1 * cislo2 / c1;
            label4.Text = Convert.ToString(c1);
            label6.Text = Convert.ToString(nsn);
        }
    }
}
