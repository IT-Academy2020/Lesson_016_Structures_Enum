using System;
using System.Text;

// Пошук елемента перерахування по імені константи.

namespace Enums
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Знаходимо елемент перерахування по імені константи.
            object element = Enum.Parse(typeof(EnumType), "Infinite");

            EnumType number = (EnumType)element;

            Console.WriteLine("Значення константи {0}: {1}", number, (byte)number);

            // Enum.IsDefined () - Дозволяє визначити, чи є символьний рядок елементом перерахування?
            bool flag = Enum.IsDefined(typeof(EnumType), "one");

            if (flag == true)
                Console.WriteLine("Так, перерахування містить елемент з таким ім'ям.");
            else
                Console.WriteLine("Ні, перерахування не містить елемент з таким ім'ям.");

            // Delay.
            Console.ReadKey();
        }
    }
}