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
        int cislo, delitel;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            cislo = Convert.ToInt16(textBox1.Text);
            if (cislo < 2) MessageBox.Show("Číslo musí být větší než 1.");
            else
            {
                delitel = 2;
                while (cislo > 1)
                {
                    while (cislo % delitel == 0)
                    {
                        cislo = cislo / delitel;
                        textBox2.AppendText(Convert.ToString(delitel) + Environment.NewLine);
                    }
                    delitel = delitel + 1;
                }
            }
        }
    }
}

