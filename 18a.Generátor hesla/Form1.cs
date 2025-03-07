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
        string heslo;
        int pocet, i, typ_znaku;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            heslo = "";
            pocet = Convert.ToInt16(textBox1.Text);
            for (i = 1; i <= pocet; i = i + 1)
            {
                if (checkBox1.Checked == true) typ_znaku = nahodne.Next(1, 4);
                else typ_znaku = nahodne.Next(1, 3);
                if (checkBox1.Checked == true)
                    switch (typ_znaku)
                    {
                        case 1: heslo = heslo + Convert.ToString(nahodne.Next(0, 10)); break;
                        case 2: heslo = heslo + Convert.ToChar(nahodne.Next(97, 123)); break;
                        case 3: heslo = heslo + Convert.ToChar(nahodne.Next(65, 91)); break;
                    }          
                else if 
                    (typ_znaku == 1) heslo = heslo + Convert.ToString(nahodne.Next(0, 10));
                else heslo = heslo + Convert.ToChar(nahodne.Next(65, 91));
            }
            label2.Text = heslo;
        }
    }
}
