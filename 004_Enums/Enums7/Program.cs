using System;
using System.Text;

// Перерахування. Форматований вивід елементів перерахування

namespace Enums
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            EnumType digit = EnumType.Ten;

            Console.WriteLine("Число {0}", digit.ToString());

            // Enum.Format () - Дозволяє робити більш точне форматування за рахунок вказівки прапора,
            // а також отримувати імена елементів перерахування по їх числовим значенням

            // Висновок в 16-річному форматі. Прапор "x" - hex (16-ковий формат)
            Console.WriteLine("Hex значення {0}", Enum.Format(typeof(EnumType), EnumType.Ten, "x"));

            // Висновок в 10-тичного форматі. Прапор "D" - dec (10-тичного формат)
            Console.WriteLine("Dec значення {0}", Enum.Format(typeof(EnumType), digit, "D"));

            // Висновок в строковому форматі. Прапор "G" - str (Строковий формат)
            Console.WriteLine("Str значення {0}", Enum.Format(typeof(EnumType), 10, "G"));

            // Delay.
            Console.ReadKey();
        }
    }
}