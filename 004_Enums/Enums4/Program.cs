using System;
using System.Text;

// Перерахування.

namespace Enums
{
    class Program
    {
        // Enum, як аргумент методу
        public static void MethodEnum(EnumType e)
        {
            switch (e)
            {
                case EnumType.Zero:
                    Console.WriteLine("Число 0");
                    break;
                case EnumType.Two:
                    Console.WriteLine("Число 2");
                    break;
                case EnumType.Five:
                    Console.WriteLine("Число 5");
                    break;
                case EnumType.Ten:
                    Console.WriteLine("Число 10");
                    break;

                default: break;
            }
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            MethodEnum(EnumType.Five);

            EnumType digit = EnumType.Ten;
            MethodEnum(digit);

            int i = (int)(++digit);
            Console.WriteLine(i);

            Console.WriteLine(digit); // Змінна змінилася.
            Console.WriteLine((int)EnumType.Ten); // Константа не змінилася.

            digit++;
            digit = digit + 5;

            // Неприпустимо.
            // digit = ++ EnumType.One;
            // digit = EnumType.One + EnumType.Two;

            // Delay.
            Console.ReadKey();
        }
    }
}