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
    /// <summary>
    /// Доп.задание - 1.
    /// </summary>
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonGetNumMyType_Click(object sender, EventArgs e)
        {
            var stringToType = StringTypes.stringTypes;
            var fromType = stringToType[comboBoxIn.Text];
            var toType = stringToType[comboBoxOut.Text];
            if (!StringTypes.CanConvertType(textBoxInput.Text, fromType))
                return;
            dynamic fromValue = Convert.ChangeType(textBoxInput.Text, fromType);
            if(!StringTypes.CanUseConvertToType(fromValue, toType))
            {
                MessageBox.Show("Невозможно преобразовать");
                return;
            }
            var toValue = Convert.ChangeType(fromValue, toType);
            labelRes.Text = toValue.ToString();
        }
    }
    public static class StringTypes
    {
        public static Dictionary<string, Type> stringTypes = new Dictionary<string, Type>()
        {
            {"char", typeof(char) },
            {"string", typeof(string) },
            {"byte", typeof(byte) },
            {"int", typeof(int) },
            {"float", typeof(float) },
            {"double", typeof(double) },
            {"decimal", typeof(decimal) },
            {"bool", typeof(bool) },
            {"object", typeof(object) }

        };
        public static bool CanConvertType(string from, Type to)
        {
            try
            {
                Convert.ChangeType(from, to);
            }
            catch(Exception ex)
            {
                if (ex is InvalidCastException)
                    MessageBox.Show("Так нельзя. Исправь типы или их значения");
                else if (ex is OverflowException)
                    MessageBox.Show("Ошибка переполнения. Выберите больший тип данных или уменьшите число");
                else if (ex is FormatException)
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show("Неизвестная ошибка: " + ex.Message);
                return false;
            }
            return true;
        }
        public static bool CanUseConvertToType(dynamic obj, Type type)
        {
            try
            {
                Convert.ChangeType(unchecked(obj), type);
            }
            catch(Exception ex)
            {
                if (ex is FormatException) 
                    MessageBox.Show("Неверный формат ввода значения");
                return false;
            }
            return true;
        }
    }
}
