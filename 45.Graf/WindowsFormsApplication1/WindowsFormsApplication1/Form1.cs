using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //připsat

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int zacatek, konec, radek;
        double x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            dataGridView1.RowCount = 50;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "X";
            dataGridView1.Columns[1].HeaderText = "Y";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            if (checkBox1.Checked == false) chart1.Series[0].ChartType = SeriesChartType.Line;
            else chart1.Series[0].ChartType = SeriesChartType.Spline;
            zacatek = Convert.ToInt16(textBox1.Text);
            konec = Convert.ToInt16(textBox2.Text);
            for (radek = zacatek; radek <= konec; radek = radek + 1)
                if (dataGridView1.Rows[radek].Cells[0].Value != "" && dataGridView1.Rows[radek].Cells[1].Value != "")
                {
                    x = Convert.ToDouble(dataGridView1.Rows[radek].Cells[0].Value);
                    y = Convert.ToDouble(dataGridView1.Rows[radek].Cells[1].Value);
                    chart1.Series[0].Points.AddXY(x, y);
                }
        }
    }
}
