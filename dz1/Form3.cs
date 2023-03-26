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
    /// Задание - 3. Перевод из числа в двоичное.
    /// </summary>
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Переводит число в двоичное по нажатию кнопки.
        /// </summary>
        private void buttonGetBinary_Click(object sender, EventArgs e)
        {
            bool succes = int.TryParse(textBoxInput.Text, out int num);
            if (succes)
            {
                if (num < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                    return;
                }
                int remainder = 0;
                StringBuilder binary = new StringBuilder();
                do
                {
                    remainder = num % 2;
                    num /= 2;
                    binary.Insert(0, remainder);
                } while (num > 0);
                labelBinary.Text = binary.ToString();
            }
        }
        /// <summary>
        /// Проверяет на разделитель.
        /// </summary>
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            CheckBox.CheckIntNum(textBoxInput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void buttonTo2Task_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }

    }
}
