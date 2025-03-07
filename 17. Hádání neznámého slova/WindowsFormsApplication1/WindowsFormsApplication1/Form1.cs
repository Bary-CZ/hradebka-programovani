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
        int i, celkem, spravne, minimum, pocet;
        string slovo, slovo1;
        char pismeno;
        bool shoda;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            celkem = 0;
            spravne = 0;
            slovo1 = "";
            label5.Text = "";
            label7.Text = "";
            label9.Text = "";
            slovo = textBox1.Text.ToLower();
            for (i = 0; i < slovo.Length; i = i + 1) slovo1 = slovo1 + '?';
            minimum = slovo.Distinct().ToArray().Length;
            pocet = slovo.Length;
            label3.Text = slovo1 + "   (" + pocet + ")";
            label5.Text = " / " + Convert.ToString(minimum);
            textBox1.Clear();
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pismeno = textBox2.Text.ToLower()[0];
            if (slovo1.Contains(pismeno) == true)
                MessageBox.Show("Písmeno " + pismeno + " je již doplněno.");
            else
            {
                celkem = celkem + 1;
                shoda = false;
                for (i = 0; i < slovo.Length; i = i + 1)
                    if (pismeno == slovo[i])
                    {
                        slovo1 = slovo1.Remove(i, 1);
                        slovo1 = slovo1.Insert(i, Convert.ToString(pismeno));
                        shoda = true;
                    }
                if (shoda == true) spravne = spravne + 1;
            }
            textBox2.Clear();
            textBox2.Focus();
            label3.Text = slovo1 + "   (" + pocet + ")";
            label5.Text = Convert.ToString(celkem) + " / " + Convert.ToString(minimum);
            label7.Text = Convert.ToString(spravne);
            label9.Text = Convert.ToString(celkem - spravne);
            if (slovo == slovo1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
    }
}
