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
        bool logicka1, logicka2, vysledek;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logicka1 = Convert.ToBoolean(Convert.ToInt16(comboBox1.Text));
            logicka2 = Convert.ToBoolean(Convert.ToInt16(comboBox3.Text));
            if (comboBox2.Text == "OR") vysledek = logicka1 || logicka2;
                else if (comboBox2.Text == "AND") vysledek = logicka1 && logicka2; 
                    else vysledek = logicka1 ^ logicka2;
            label1.Text = Convert.ToString(Convert.ToInt16(vysledek));     
        }
    }
}
