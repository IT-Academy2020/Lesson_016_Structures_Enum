using System;
using System.Text;

// Отримання інформації про кількість елементів перерахування. Отримання всіх елементів перерахування і їх значень

namespace Enums
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Enum.GetValues ​​() - повертає екземпляр System.Array, при цьому кожному елементу масиву
            // буде відповідати член зазначеного перерахування.

            // Розміщуємо в масив елементи перерахування.
            Array array = Enum.GetValues(typeof(EnumType));

            // Отримуємо інформацію про кількість елементів в масиві.
            Console.WriteLine("Це перерахування містить {0} членів \n", array.Length);

            // Вивід на екран всіх елементів перерахування
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ім'я константи: {0}, значення {0:D}", array.GetValue(i));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}