using System;

// DateTime представляє момент (значення) часу, тоді як TimeSpan представляє інтервал (проміжок) часу.
// Це означає, що можна відняти один екземпляр DateTime з іншого для отримання об'єкта TimeSpan,
// який являє собою часовий інтервал між ними.
// Або можна додати позитивне значення TimeSpan до поточного значення DateTime, щоб отримати значення
// DateTime, яке представляє собою майбутню дату.

namespace DateTime2
{
    class Program
    {
        static void Main()
        {
            // Створення Нової дати. DateTime (рр, мм, дд)
            DateTime newYearDate = new DateTime(2013, 1, 1);
            DateTime today = DateTime.Now;

            // Створює інтервал часу.
            TimeSpan left = newYearDate - today;
            Console.WriteLine("До нового року залишилося" + left.Days + "днів");
            Console.WriteLine("До нового року залишилося" + left.TotalHours + "годин");

            // Створення Нової дати і часу. DateTime (рр, мм, дд, чч, хв, сек)
            DateTime newDate = new DateTime(2012, 12, 05, 23, 11, 11);

            Console.WriteLine(newDate); // Вивід значення дати і часу на екран
            Console.WriteLine(newDate.TimeOfDay); // Вивід значення часу на екран

            // Перетворює задане строкове представлення дати і часу в DateTime
            Console.WriteLine(DateTime.Parse("3/12/2012"));

            Console.WriteLine(DateTime.Parse("05 march 2012"));.

            // Затримка.
            Console.ReadKey();
        }
    }
}