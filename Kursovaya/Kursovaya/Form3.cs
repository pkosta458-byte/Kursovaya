using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val1) &&
        double.TryParse(textBox2.Text, out double val2) &&
        double.TryParse(textBox3.Text, out double val3))
            {
                if (val1 == 0)
                {
                    textBox7.Text = "Ошибка";
                    return;
                }

                double numerator = Math.Pow(val1, -2) * 8.31 * val3;
                double denominator = 0.032 * val2;

                if (denominator == 0)
                {
                    textBox7.Text = "Ошибка";
                    return;
                }

                double result = numerator / denominator;
                textBox7.Text = result.ToString("F2");
            }
            else
            {
                textBox7.Text = "Ошибка";
            }
            textBox4.Text = textBox1.Text;
            textBox6.Text = textBox3.Text;
            textBox5.Text = textBox2.Text;
            textBox8.Text = textBox7.Text;
        }
    }
}
