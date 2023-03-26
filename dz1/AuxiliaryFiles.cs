using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Task1OOP
{
    class CheckBox
    {
        /// <summary>
        /// Check is it Double type of user input
        /// </summary>
        /// <param name="box">TextBox to check</param>
        /// <returns></returns>
        public static bool CheckDoubleNum(TextBox box)
        {
            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ",";
            double num;
            try
            {
                num = double.Parse(box.Text, format);
                return true;
            }
            catch (Exception ex)
            {
                if (ex is OverflowException)
                    MessageBox.Show("Число должно быть меньше, чем " + double.MaxValue);
                if (box.TextLength > 1)
                    box.Clear();
                else
                    box.Text = "";
                
                return false;
            }
        }/// <summary>
         /// Check is it Decimal type of user input
         /// </summary>
         /// <param name="box"></param>
         /// <returns></returns>
        public static bool CheckDecimalNum(TextBox box)
        {
            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ",";
            decimal num;
            try
            {
                num = decimal.Parse(box.Text, format);
                return true;
            }
            catch (Exception ex)
            {
                if (ex is OverflowException)
                    MessageBox.Show("Число должно быть меньше, чем " + decimal.MaxValue);
                if (box.TextLength > 1)
                    box.Clear();
                else
                    box.Text = "";
                return false;
            }
        }
        /// <summary>
        /// Check is it Int type of user input
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        public static bool CheckIntNum(TextBox box)
        {
            int num;
            try
            {
                num = int.Parse(box.Text);
                return true;
            }
            catch (Exception ex)
            {
                if (ex is OverflowException)
                    MessageBox.Show("Число должно быть меньше, чем " + int.MaxValue);
                if (box.TextLength > 1)
                    box.Clear();
                else
                    box.Text = "";
                return false;
            }
        }
        /// <summary>
        /// Check string to contains wrong delimetr
        /// </summary>
        /// <param name="box"></param>
        public static void CheckDelimetr(TextBox box)
        {
            string str = box.Text;
            if (str.Contains("."))
            {
                string s = str.Replace(".", ",");
                box.Clear();
                box.AppendText(s);
            }
        }
    }

    class SqrtCalculate
    {
        /// <summary>
        /// Calculate Math.Sqrt
        /// </summary>
        /// <param name="num">Takes a num with type Double</param>
        /// <returns>Returns square root of num</returns>
        public static double MathMethod(double num)
        {
            return Math.Sqrt(num);
        }
        public IEnumerable<decimal> NewtonMethod(decimal num, decimal eps = 1e-28m, decimal prevValue = 1)
        {
            decimal result = prevValue;
            var it = 0;
            while (true)
            {
                result = (result + num/result ) / 2;
                yield return result;
                if (Math.Abs(result* result - num) <= eps || it++ > 1e6)
                    yield break;
            }
        }
    }
}
