using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int str = 1900;
            textBox1.Text = textBox1.Text.Remove(0, 4);
            int date = Convert.ToInt32(textBox1.Text);
            if (date <= str)
                System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/%D0%9F%D0%B5%D1%80%D0%B2%D0%B0%D1%8F_%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%8F_%D0%B2%D0%BE%D0%B9%D0%BD%D0%B0");
            else if (1900 < date && date <= 2004)
                System.Diagnostics.Process.Start("https://smoking-shop.pro/");
            else
                System.Diagnostics.Process.Start("https://pl.spb.ru/");
        }
    }
}
