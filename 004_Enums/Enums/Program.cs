using System;

// Перерахування.

// Перерахування - це набір іменованих констант, які зберігають числові значення.
// Перерахування визначають іменовані константи, кожній з яких відповідає числове значення.
// Всі перерахування в C # походять від єдиного Базового класу System.Enum

namespace Enums
{
    // При компіляції - компілятор підставляє замість імен,
    // встановлені вами у відповідність числові значення. [Ім'я] = [число]
    // За замовчанням, типом даних констант перерахування буде int.
    // Можна використовувати будь-який цілий тип даних C # (byte, sbyte, short, ushort, int, uint, long, ulong)

    enum EnumType : byte // Явно вказуємо використовувати тип byte.
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
            Console.WriteLine((byte)EnumType.One);

            EnumType digit = EnumType.Zero;
            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);

            // Delay.
            Console.ReadKey();
        }
    }
}