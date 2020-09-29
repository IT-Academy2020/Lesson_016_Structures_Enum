using System;

// Перерахування. Значення за замовчуванням для перерахувань.

namespace Enums
{
    enum EnumType : byte
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    class Program
    {
        static void Main()
        {
            // Змінній five типу EnumType може бути призначено будь-яке значення, що входить в діапазон
            // базового типу, значення не обмежені іменованими константами.

            EnumType five = (EnumType)5;

            Console.WriteLine(five);

            // Delay.
            Console.ReadKey();
        }
    }
}