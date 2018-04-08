using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımyapımıodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            besebes newForm = new besebes();
            // ShowDialog() metodu ile Form2'den yarattığımız instance olan newForm üzerinden Form2'yi gösteriyoruz.
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            altıyaaltı newForm = new altıyaaltı();
            // ShowDialog() metodu ile Form2'den yarattığımız instance olan newForm üzerinden Form2'yi gösteriyoruz.
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yediyeyedi newForm = new yediyeyedi();
            // ShowDialog() metodu ile Form2'den yarattığımız instance olan newForm üzerinden Form2'yi gösteriyoruz.
            newForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sekizesekiz newForm = new sekizesekiz();
            // ShowDialog() metodu ile Form2'den yarattığımız instance olan newForm üzerinden Form2'yi gösteriyoruz.
            newForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dokuzadokuz newForm = new dokuzadokuz();
            // ShowDialog() metodu ile Form2'den yarattığımız instance olan newForm üzerinden Form2'yi gösteriyoruz.
            newForm.ShowDialog();
        }
    }
}
