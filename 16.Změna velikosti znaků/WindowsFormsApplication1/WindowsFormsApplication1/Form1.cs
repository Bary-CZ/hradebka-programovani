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
        string vysledny, text;
        char znak1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vysledny = string.Empty; //vysledny = "";
            text = textBox1.Text;
            foreach (char znak in text)
            {
                znak1 = Convert.ToChar(Convert.ToString(znak).ToLower());
                if (znak == znak1) vysledny = vysledny + Convert.ToString(znak1).ToUpper(); else vysledny = vysledny + znak1;
            }
            label3.Text = vysledny;
        }
    }
}
