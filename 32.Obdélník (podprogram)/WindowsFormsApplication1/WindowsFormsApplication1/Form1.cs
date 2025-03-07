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
        void Obdelnik(double strana1, double strana2, out double obvod, out double obsah) //metoda bez návratové hodnoty s výstupními parametry
        {
            obvod = 2 * (strana1 + strana2);
            obsah = strana1 * strana2;
        }

        double Obdelnik_obvod(double strana1, double strana2) //metoda s návratovou hodnotou
        {
            return 2 * (strana1 + strana2);
        }

        double Obdelnik_obsah(double strana1, double strana2) //metoda s návratovou hodnotou
        {
            return strana1 * strana2;
        }
        
        double s1, s2, obv, obs;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            Obdelnik(s1, s2, out obv, out obs); //volání metody bez návratové hodnoty s výstupními parametry
            MessageBox.Show("Obvod je: " + Convert.ToString(obv) + '\r' + "Obsah je: " + Convert.ToString(obs));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            obv = Obdelnik_obvod(s1, s2); //volání metody s návratovou hodnotou
            obs = Obdelnik_obsah(s1, s2); //volání metody s návratovou hodnotou
            MessageBox.Show("Obvod je: " + Convert.ToString(obv) + '\r' + "Obsah je: " + Convert.ToString(obs));
        }
    }
}