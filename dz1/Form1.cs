using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTo2Task_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }
        /// <summary>
        /// Пункт - 1.
        /// </summary>
        private void button1Point_Click(object sender, EventArgs e)
        {
            FirstTaskExamples.ImplicitConversion();
            long c = long.MaxValue;
            double d = c;
            textBox1.Text = c.ToString();
            textBox2.Text = d.ToString();
        }
        /// <summary>
        /// Пункт - 2.
        /// </summary>
        private void button2Point_Click(object sender, EventArgs e)
        {
            FirstTaskExamples.ExplicitConversion();
            
            double d = 300;
            byte c= (byte)d;
            textBox1.Text = c.ToString();
            textBox2.Text = d.ToString();
        }
        /// <summary>
        /// Пункт - 3.
        /// </summary>
        private void button3Point_Click(object sender, EventArgs e)
        {
            FirstTaskExamples.ProcessingExceptional();
        }
        /// <summary>
        /// Пункт - 4.
        /// </summary>
        private void button4Point_Click(object sender, EventArgs e)
        {
            FirstTaskExamples.OperatorsAsAndIs();
        }
        /// <summary>
        /// Пункт - 5.
        /// </summary>
        private void button5Point_Click(object sender, EventArgs e)
        {
            FirstTaskExamples.RedefinitionImExOperations();
        }
        /// <summary>
        /// Пункт - 6.
        /// </summary>
        private void button6Point_Click(object sender, EventArgs e)
        {
            FirstTaskExamples.ConvertingAndParsing();
        }
        /// <summary>
        /// Пункт - 7.
        /// </summary>
        private void button7Point_Click(object sender, EventArgs e)
        { 

            if (double.TryParse(textBoxDelimetr.Text, out double a)) 
                MessageBox.Show($"Удачно - {a}");
            else 
                MessageBox.Show("Введите число!");
        }
        /// <summary>
        /// Проверка на разделитель.
        /// </summary>
        private void textBoxDelimetr_TextChanged(object sender, EventArgs e)
        {
            string str = textBoxDelimetr.Text;
            if (str.Contains("."))
            {
                string s = str.Replace(".",",");
                textBoxDelimetr.Clear();
                textBoxDelimetr.AppendText(s);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            Close();
        }
    }
}
