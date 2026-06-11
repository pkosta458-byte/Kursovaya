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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

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
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double t1Celsius) &&   
                double.TryParse(textBox2.Text, out double p1Mpa) &&  
                double.TryParse(textBox3.Text, out double p2Mpa))    
            {
                double T1 = t1Celsius + 273;     
                double p1 = p1Mpa * 1e6;         
                double p2 = p2Mpa * 1e6;      
                if (p1 == 0)
                {
                    textBox9.Text = "Ошибка";
                    return;
                }
                double T2 = (p2 * T1) / p1;
                textBox9.Text = T2.ToString("F1");
            }
            else
            {
                textBox9.Text = "Ошибка";
            }
            textBox4.Text = textBox2.Text;
            textBox8.Text = textBox2.Text;
            textBox5.Text = textBox3.Text;
            textBox6.Text = textBox3.Text;
            textBox7.Text = textBox1.Text;
            textBox10.Text = textBox9.Text;
        }
    }
}
