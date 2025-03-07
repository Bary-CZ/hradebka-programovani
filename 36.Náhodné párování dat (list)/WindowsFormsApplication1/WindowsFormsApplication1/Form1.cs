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
        List<string> data1 = new List<string>();
        List<string> data2 = new List<string>();  
        Random nahodne = new Random();
        int cislo1, cislo2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string text in textBox1.Lines) data1.Add(text);
            foreach (string text in textBox2.Lines) data2.Add(text);
            while (data1.Count > 0)
            {
                cislo1 = nahodne.Next(0, data1.Count);
                cislo2 = nahodne.Next(0, data1.Count);
                textBox3.AppendText(data1[cislo1] + " - " + data2[cislo2] + Environment.NewLine);
                data1.RemoveAt(cislo1);
                data2.RemoveAt(cislo2);
            }
            textBox3.AppendText("------------" + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
