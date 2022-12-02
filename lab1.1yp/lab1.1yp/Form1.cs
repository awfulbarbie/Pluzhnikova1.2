using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._1yp
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                if (a <= 0)
                {
                   MessageBox.Show("Сторона треугольника не может иметь отрицательное или нулевое значение!");
                }
                else
                {
                    textBox2.Text = ("Радиус описанной окружности равен: " + (Math.Round(a / Math.Sqrt(3),3)));
                   
                }
            }
            catch
            { MessageBox.Show("Ошибка. Данные введены некорректно!"); }

        }
    }
}
