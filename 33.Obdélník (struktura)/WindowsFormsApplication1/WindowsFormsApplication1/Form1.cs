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
        struct Obdelnik
        {
            public double strana1, strana2, obvod, obsah;
            public void Obvod_obsah()
            {
                obvod = 2 * (strana1 + strana2);
                obsah = strana1 * strana2;
            }
        }
        
        struct Obdelnik1
        {
            public double strana1, strana2;
            public double Obvod()
            {
                return 2 * (strana1 + strana2);
            }
            public double Obsah()
            {
                return strana1 * strana2;
            }
        }

        Obdelnik o;
        Obdelnik1 o1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o.strana1 = Convert.ToDouble(textBox1.Text);
            o.strana2 = Convert.ToDouble(textBox2.Text);
            o.Obvod_obsah(); 
            MessageBox.Show("Obvod je: " + Convert.ToString(o.obvod) + '\r' + "Obsah je: " + Convert.ToString(o.obsah));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o1.strana1 = Convert.ToDouble(textBox1.Text);
            o1.strana2 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Obvod je: " + Convert.ToString(o1.Obvod()) + '\r' + "Obsah je: " + Convert.ToString(o1.Obsah()));
        }
    }
}
