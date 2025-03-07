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
        int frekvence1, frekvence2, delka, skok, i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frekvence1 = Convert.ToInt32(textBox1.Text);
                frekvence2 = Convert.ToInt32(textBox2.Text);
                delka = Convert.ToInt32(textBox3.Text);
                skok = Convert.ToInt32(textBox4.Text);
                for (i = frekvence1; i <= frekvence2; i = i + skok) Console.Beep(i, delka);
            }
            catch (FormatException vyjimka)
            {
                 MessageBox.Show("Je zadána neplatná hodnota pro skok, frekvenci nebo délku tónu."); // vlastní formulace výjimky
                 MessageBox.Show(vyjimka.Message); // hotová formulace výjimky
            }
            catch (ArgumentOutOfRangeException vyjimka)
            {
                MessageBox.Show("Interval hodnot pro frekvenci tónu je dán v rozmezí 37 - 32767 Hz.");
                MessageBox.Show(vyjimka.Message);
            }
          /*catch (Exception vyjimka) //obecná výjimka
            {
              MessageBox.Show(vyjimka.Message);
            }*/
        }
    }
}

