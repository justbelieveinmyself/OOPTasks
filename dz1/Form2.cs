using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1OOP
{
    /// <summary>
    /// Задание - 2. Вычисление квадратных корней.
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        decimal prevResForNewton = 1;
        long iter;
        decimal resIt;
        decimal approxIt;
        decimal deltaIt;
        /// <summary>
        /// Переход на 3 форму.
        /// </summary>
        private void buttonTo3Task_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Close();
        }
        /// <summary>
        /// Считает квадрат Math.Sqrt по нажатию кнопки
        /// </summary>
        private void buttonGetMathSquare_Click(object sender, EventArgs e)
        {
            bool succes = false;
            succes = CheckBox.CheckDoubleNum(textBoxInputSquare);
            if (succes)
            {
                double num = double.Parse(textBoxInputSquare.Text);
                if (num < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                    return;
                }
                textBoxOutputMathSqrt.Text = SqrtCalculate.MathMethod(num).ToString();
            }

        }

        private void textBoxInputSquare_TextChanged(object sender, EventArgs e)
        {
            CheckBox.CheckDelimetr(textBoxInputSquare);
        }
        /// <summary>
        /// Считает квадрат методом Ньтона по нажатию кнопки
        /// </summary>
        private void buttonGetNewtonSquare_Click(object sender, EventArgs e)
        {
            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ",";
            bool succes = CheckBox.CheckDecimalNum(textBoxInputSquare);
            if (succes)
            {
                decimal num = decimal.Parse(textBoxInputSquare.Text, format);
                if (num < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                    return;
                }
                var calculator = new SqrtCalculate();
                var newtonSqrt = 0m;
                foreach (var iteration in calculator.NewtonMethod(num))
                {
                    newtonSqrt = iteration;
                }
                textBoxOutputNewton.Text = newtonSqrt.ToString();
                var doubleMathSqrt = double.Parse(textBoxInputSquare.Text);
                doubleMathSqrt = SqrtCalculate.MathMethod(doubleMathSqrt);
                var decimalMathSqrt = Convert.ToDecimal(doubleMathSqrt);
                labelFault.Text = labelFault.Text.Split(':')[0].ToString() + ": " + (decimalMathSqrt - newtonSqrt).ToString("e0");
            }

        }
        /// <summary>
        /// Переходит к следующей итерации метода Ньютона по нажатию кнопки
        /// </summary>
        private void buttonIteration_Click(object sender, EventArgs e)
        {
            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ",";
            bool succes = CheckBox.CheckDecimalNum(textBoxInputSquare);
            if (succes)
            {
                decimal num = decimal.Parse(textBoxInputSquare.Text, format);
                if (num < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                    return;
                }
                if(num == 0 )
                {
                    MessageBox.Show("На 0 делить незя(");
                    return;
                }
                var nextNum = new SqrtCalculate().NewtonMethod(num, prevValue: prevResForNewton).First();
                if (iter == 0)
                {
                    deltaIt = (decimal)Math.Pow(10, -28);
                    approxIt = num / 2;
                    resIt = ((num / approxIt) + approxIt) / 2;
                    var fault = Math.Abs(nextNum - prevResForNewton);
                    prevResForNewton = nextNum;
                    
                }
                if(Math.Abs(resIt - approxIt)> deltaIt)
                {
                    approxIt = resIt;
                    resIt = ((num / approxIt) + approxIt) / 2;
                }
                else
                {
                    textBoxOutputNewton.Text = resIt.ToString();
                    iter = 0;
                    resIt = 0;
                    approxIt = 0;
                    return;
                }
                iter++;
                labelIteration.Text = labelIteration.Text.Split(':')[0] + ": " + iter;
                labelFault.Text = labelFault.Text.Split(':')[0] + ": " + (double)Math.Abs(resIt - approxIt);
                labelChanges.Text = labelChanges.Text.Split(':')[0] + ": " + (double)(approxIt - resIt) ;
                textBoxOutputNewton.Text = resIt.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }
    }
}
