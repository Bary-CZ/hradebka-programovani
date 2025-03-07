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
        string text, spocitane;
        int i, j, pocet;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            listBox1.Items.Clear();
            spocitane = "";
            for(i = 0; i <= text.Length - 1; i = i + 1)
            {
                if (spocitane.Contains(text[i]) == false)
                {
                    pocet = 0;
                    for (j = i; j <= text.Length - 1; j = j + 1)
                        if (text[j] == text[i]) pocet = pocet + 1;
                    spocitane = spocitane + text[i];
                    if (radioButton1.Checked == true) 
                        listBox1.Items.Add(Convert.ToString(pocet) + " - " + text[i]);
                    else listBox1.Items.Add(text[i] + " - " + Convert.ToString(pocet));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
