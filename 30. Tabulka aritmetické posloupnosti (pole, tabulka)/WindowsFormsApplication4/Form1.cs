using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int radky, sloupce, r, s;
        double clen, diference;
        double[,] posloupnost;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radky = Math.Abs(Convert.ToInt16(textBox1.Text));
            sloupce = Math.Abs(Convert.ToInt16(textBox2.Text));
            clen = Convert.ToDouble(textBox3.Text);
            diference = Convert.ToDouble(textBox4.Text);
            dataGridView1.RowCount = radky;
            dataGridView1.ColumnCount = sloupce;
            posloupnost = new double[radky,sloupce];
            clen = clen - diference;
            for (r = 0; r < radky; r = r + 1)
                for (s = 0; s < sloupce; s = s + 1)
                {
                    clen = clen + diference;
                    posloupnost[r,s] = clen;
                    dataGridView1.Rows[r].Cells[s].Value = posloupnost[r,s];
                }
        }
    }
}
