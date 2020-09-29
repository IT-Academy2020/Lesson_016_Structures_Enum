using System;

// Порівняння елементів перерахування

namespace Enums
{
    class Program
    {
        static void Main()
        {
            EnumType x = EnumType.Five;
            EnumType y = EnumType.One;

            // if (x <y) // Перший варіант порівняння.
            if (EnumType.Five < EnumType.One) // Другий варіант порівняння.
                Console.WriteLine("X = {0} (менше ніж) Y = {1}.", X, y);
            else
                Console.WriteLine("Y = {0} (менше ніж) X = {1}.", Y, x);

            // Delay.
            Console.ReadKey();
        }
    }
}