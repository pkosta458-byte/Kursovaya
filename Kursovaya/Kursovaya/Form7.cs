using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double h) &&      
        double.TryParse(textBox2.Text, out double pKpa) &&      
        double.TryParse(textBox3.Text, out double S) &&      
        double.TryParse(textBox4.Text, out double tCelsius))    
            {
                double p = pKpa * 1000.0;         
                double T = tCelsius + 273;         
                double R = 8.31;                  
                double mu = 0.029;               
                if (T == 0)
                {
                    textBox7.Text = "Ошибка";
                    return;
                }
                double numerator = p * h * S * mu;
                double denominator = R * T;
                double m = numerator / denominator;
                textBox7.Text = m.ToString("F2");
            }
            else
            {
                textBox7.Text = "Ошибка";
            }
            textBox5.Text = textBox2.Text;
            textBox6.Text = textBox4.Text;
            textBox8.Text = textBox7.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }
    }
}
