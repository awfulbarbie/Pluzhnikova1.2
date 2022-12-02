using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._2_yp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;


            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox3.Text);
                c = Convert.ToDouble(textBox4.Text);

                if ((Math.Pow(a, 2) + (Math.Pow(b, 2)) == Math.Pow(c, 2)))
                {
                    textBox2.Text = ("Треугольник являтся прямоугольным");
                }
                else
                {
                    textBox2.Text = ("Треугольник не является прямоугольным");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка! Введен недопустимый символ.");
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
