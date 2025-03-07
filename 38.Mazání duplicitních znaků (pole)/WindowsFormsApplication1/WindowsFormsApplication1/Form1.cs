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
        string text, text1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text1 = "";
            text = textBox1.Text;
            if (checkBox1.Checked == true) text = text.ToLower();  
            foreach(char znak in text)
            {
                foreach (char znak1 in text1)
                    if (znak == znak1) goto skok;
                text1 = text1 + znak;
                skok: ;
            }
            label2.Text = text1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
	        text = textBox1.Text;
            if (checkBox1.Checked == true) text = text.ToLower();			
            label2.Text = new string(text.Distinct().ToArray());
        }
    }
}
