using System;

// Перерахування.

namespace Enums
{
    // Для значення константи у перерахуванні можна використовувати псевдонім для будь-якого цілого типу даних C # (byte, sbyte, short, ushort, int,
    // uint, long, ulong)

    enum EnumType : sbyte
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
            Console.WriteLine(EnumType.One);

            // Delay.
            Console.ReadKey();
        }
    }
}