using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }

        private void Form2_Point(object sender, PaintEventArgs e)
        {
           Graphics g = e.Graphics;
            using (Pen pen = new Pen(Color.Black, 2))
                g.DrawLine(pen, 261, 193, 530, 193);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double result = (0.2 * Math.Pow(10, 6) * 820 * Math.Pow(10, -6) * 0.028) / (2 * Math.Pow(10, -3) * 8.31);
            Console.WriteLine(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double valA) &&      
                double.TryParse(textBox2.Text, out double valB) &&      
                double.TryParse(textBox1.Text, out double valC))        
            {
                double numerator = valA * 1e6 * valB * 1e-6 * 0.028;
                double denominator = valC * 1e-3 * 8.31;

                if (denominator != 0)
                {
                    double result = numerator / denominator;
                    double finalResult = result - 273.15;
                    textBox7.Text = finalResult.ToString("F2"); 
                }
                else
                {
                    textBox7.Text = "Ошибка";
                }
            }
            else
            {
                textBox7.Text = "Ошибка";
            }
            textBox6.Text = textBox1.Text;
            textBox5.Text = textBox2.Text;
            textBox4.Text = textBox3.Text;
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
    }
}
