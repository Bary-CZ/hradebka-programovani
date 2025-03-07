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
        int pismena, cislice, i, male;
        string heslo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            heslo = "";
            pismena = Convert.ToInt16(textBox1.Text);
            cislice = Convert.ToInt16(textBox2.Text);
            for (i = 1; i <= pismena; i = i + 1)
            {
                if (checkBox1.Checked == true)
                {
                    male = nahodne.Next(0, 2);
                    if (male == 1) heslo = heslo + Convert.ToChar(nahodne.Next(97, 123)); else 
                        heslo = heslo + Convert.ToChar(nahodne.Next(65, 91));
                }
                else heslo = heslo + Convert.ToChar(nahodne.Next(65, 91));    
            }
            for (i = 1; i <= cislice; i = i + 1) heslo = heslo + Convert.ToString(nahodne.Next(0, 10));
            label3.Text = heslo;
        }
    }
}
