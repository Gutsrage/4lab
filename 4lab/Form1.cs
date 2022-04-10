using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double func(double x, double b)
        {
            return (Math.Pow(x, 5 / 2) - b) * Math.Log(x * x + 12.7);
        }
        double x0, xk, dx,  b;

        private void button1_Click(object sender, EventArgs e)
        {
            x0 = textBox1.Text == "" ? 0 : Convert.ToDouble(textBox1.Text.Replace('.', ','));
            xk = textBox2.Text == "" ? 0 : Convert.ToDouble(textBox2.Text.Replace('.', ','));
            dx = textBox3.Text == "" ? 0 : Convert.ToDouble(textBox3.Text.Replace('.', ','));
            b  = textBox4.Text == "" ? 0 : Convert.ToDouble(textBox4.Text.Replace('.', ','));
            for (double x = x0; x <= xk; x += dx)
            {
                textBox5.Text += Environment.NewLine + "x=" + Convert.ToString(x).Replace(',', '.') + ";\ty=" + Convert.ToString(func(x,  b)).Replace(',', '.');
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
