using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1OOP
{
    /// <summary>
    /// Задание - 1.
    /// </summary>
    static class FirstTaskExamples
    {
        /// <summary>
        /// Задание - 1. Пункт - 1.
        /// Неявное преборазование
        /// </summary>
        public static void ImplicitConversion()
        {
            /* 1) Неявное преобразование простых и ссылочных типов, в виде комментариев внести в программу таблицу неявных преобразований;


            Таблица безопасных неявных преобразований

            Sbyte   - short, int, long, float, double, decimal
            Byte    - short, ushort, int, uint, long, ulong, float, double, decimal
            Short   - int, long, float, double, decimal
            Ushort  - int, uint, long, ulong, float, double, decimal
            Int     - long, float, double, decimal
            Uint    - long, ulong, float, double, decimal
            Long    - float, double, decimal
            Ulong   - float, double, decimal
            Float   - double
            Char    - ushort, int, uint, long, ulong, float, double, decimal
            
            */
            // Примеры:
            float a = 3.16f;
            double b = a;

            long c = long.MaxValue;
            float d = c;
            //Form1.textBox1.Text = c.ToString();
            // Для классов всё просто - неявно кастятся производные классы к базовым, потому что
            // производный класс всегда содержит все поля базового.

            var secondary = new Secondary();
            var based = new BasedClass();
            based = secondary; // based - базовый класс для secondary, неявное преобразование возможно. 
            MessageBox.Show("Первый пункт удачно выполнен.");
        }
        /// <summary>
        /// Задание - 1. Пункт - 2.
        /// Явное преобразование
        /// </summary>
        public static void ExplicitConversion()
        {
            /* 2) Явное преобразование простых и ссылочных типов, в виде комментариев внести в программу таблицу явных преобразований;

            Byte	- SByte
            SByte	- Byte, UInt16, UInt32, UInt64
            Int16	- Byte, SByte, UInt16
            UInt16	- Byte, SByte, Int16
            Int32	- Byte, SByte, Int16, UInt16,UInt32
            UInt32	- Byte, SByte, Int16, UInt16, Int32
            Int64	- Byte, SByte, Int16, UInt16, Int32,UInt32,UInt64
            UInt64	- Byte, SByte, Int16, UInt16, Int32, UInt32, Int64
            Decimal	- Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64
            Double	- Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64

            */

            var a = 42565.131;
            //int b = a; - не работает
            int b = (int)a; // явно указали компилятору, что мы действительно собираемся кастить из double в int.

            // Ссылочные типы можно явно преобразовывать.
            var based = new BasedClass();
            var secondary = new Secondary();
            //secondary = (Secondary)based; - нельзя.
            based = (BasedClass)secondary;
            MessageBox.Show("Второй пункт удачно выполнен.");
        }

        /// <summary>
        /// Задание - 1. Пункт - 3.
        /// Обработка исключений
        /// </summary>
        public static void ProcessingExceptional()
        {
            // 3) Вызвать и обработать исключение преобразования типов;
            try
            {
                long a = 5223372036854775;
                long b = 1041541416430000;
                int c = checked((int)(a + b));
                MessageBox.Show("Переполнения не обнаружено");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Задание - 1. Пункт - 4.
        /// Операторы as и is.
        /// </summary>
        public static void OperatorsAsAndIs()
        {
            // 4) Безопасное приведение ссылочных типов с помощью операторов as и is; 
            // is example
            BasedClass a = new BasedClass();
            object b = new Secondary();

            if (b is BasedClass) // проверяем является ли данный тип данных нужным
            {
                BasedClass c = (BasedClass)b; //если да, то приводим к этому типу
                c.PrintBased();
                MessageBox.Show("Удачно преобразовано в BasedClass"); //выполнится, т.к. secondary наследник basedclass
            }
            else throw new Exception("object b is not BasedClass, преобразование недоступно");

            // as example            
            Secondary d = a as Secondary;
            if (d != null)
            {
                MessageBox.Show("d is BasedClass");
            }
            else MessageBox.Show("d is null"); //выполнится (нельзя преобразовывать базовый в наследника)
                                               //, т.к. при невозможности кастить оператор as перевод в null.
        }
        /// <summary>
        /// Задание - 1. Пункт - 5.
        /// Пользовательские преобразования Explicit/Implicit.
        /// </summary>
        public static void RedefinitionImExOperations()
        {
            // 5) Пользовательское преобразование типов Implicit, Explicit;
            // Преобразуем int в счетчик seconds;
            Counter counter = new Counter { seconds = 10 };
            int mySeconds = (int)counter + 10; //20, явно преоборазовывается
            counter = mySeconds; //неявно преоборазовывается
            MessageBox.Show(counter.seconds.ToString()); //ошибки нет.
        }
        /// <summary>
        /// Задание - 1. Пункт - 6.
        /// Convert, Parse, TryParse.
        /// </summary>
        public static void ConvertingAndParsing()
        {
            // 6) Преобразование с помощью класса Convert и преобразование строки
            // в число с помощью методов Parse, TryParse класса System.Int32.
            int a = 10;
            double b = Convert.ToDouble(a); // Convert
            string c = "41";
            a = int.Parse(c); // Parse

            bool succes = int.TryParse(c, out a); // TryParse
            if (succes) 
                MessageBox.Show($"Удачно преобразовано с помощью TryParse - {a}");
            else 
                MessageBox.Show($"Неудачно преобразовано с помощью TryParse - {a}");


        }
        /// <summary>
        /// Задание - 1. Пункт - 7.
        /// Ввод с правильным форматом вещественного числа.
        /// </summary>
        public static void InputWithDelimetr()
        {
            // 7) Написать программу, позволяющую ввод в текстовое поле TextBox
            // только символов, задающих правильный формат вещественного числа со знаком.
            // Реализовано в Form1.cs


        }
    }





    /// <summary>
    /// Класс для демонстрации каста классов
    /// Производный от: BasedClass
    /// </summary>
    class Secondary : BasedClass
    {
        public void PrintSecondary()
        {

        }
    }
    /// <summary>
    /// Класс для демонстрации каста классов
    /// Родительский.
    /// </summary>
    class BasedClass
    {
        public void PrintBased()
        {

        }
    }
    /// <summary>
    /// Класс для демонстрации пользовательских явных
    /// и неявных преобразований.
    /// </summary>
    class Counter
    {
        public int seconds { get; set; }
        public static implicit  operator Counter(int x)
        {
            return new Counter { seconds = x };
        }
        public static explicit operator int(Counter counter)
        {
            return counter.seconds;
        }
    }
}
