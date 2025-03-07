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
        static class Obdelnik
        {
            public static double strana1, strana2, obvod, obsah;
            public static void Obvod_obsah()
            {
                obvod = 2 * (strana1 + strana2);
                obsah = strana1 * strana2;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obdelnik.strana1 = Convert.ToDouble(textBox1.Text);
            Obdelnik.strana2 = Convert.ToDouble(textBox2.Text);
            Obdelnik.Obvod_obsah(); 
            MessageBox.Show("Obvod je: " + Convert.ToString(Obdelnik.obvod) + '\r' + "Obsah je: " + Convert.ToString(Obdelnik.obsah));
        }
    }
}
