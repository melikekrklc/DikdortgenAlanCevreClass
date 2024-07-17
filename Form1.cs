using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DikdortgenAlanCevreClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int en, boy, alan, cevre;

            en = Convert.ToInt32(textBox1.Text);
            boy = Convert.ToInt32(textBox2.Text);

            Dikdortgen d1 = new Dikdortgen();

            d1.en = en;
            d1.boy = boy;
            alan = d1.AlanHesapla();
            cevre = d1.CevreHesapla();

            textBox3.Text = alan.ToString();
            textBox4.Text = cevre.ToString();
        }
    }
}
