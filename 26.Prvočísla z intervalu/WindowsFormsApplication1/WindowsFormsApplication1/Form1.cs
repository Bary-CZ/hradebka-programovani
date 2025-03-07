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
        int dolni, horni, i, j;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            dolni = Convert.ToInt16(textBox1.Text);
            horni = Convert.ToInt16(textBox2.Text);
            if (dolni > horni) MessageBox.Show("Dolní mez musí být menší než horní mez."); else
                if (dolni < 2) MessageBox.Show("Nejmenší dolní mez pro výpis prvočísel je číslo 2."); else
                    for (i = dolni; i <= horni; i = i + 1)
                    {
                        for (j = 2; j <= i - 1; j = j + 1) if (i % j == 0) goto skok;
                        textBox3.AppendText(Convert.ToString(i) + Environment.NewLine);
                        skok: ;
                    }
        }
    }
}
