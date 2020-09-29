using System;

// Структура DateTime представляє поточний час, зазвичай як дата і час доби.
// Тип значення DateTime представляє дату і час в діапазоні від 00:00:00 1 січня 0001 роки (н. Е.)
// до 23:59:59 31 грудня 9999 роки (н. Е.)

namespace WorkDateTime
{
    class Program
    {
        static void Main()
        {
            // DateTime.Now повертає об'єкт System.DateTime, якому присвоєно поточні дата і час
            // доби даного комп'ютера
            DateTime now = DateTime.Now;

            Console.WriteLine("Поточна дата і час: {0}", now);
            Console.WriteLine("Рік: {0}", now.Year);
            Console.WriteLine("Місяць: {0}", now.Month);
            Console.WriteLine("День місяця: {0}", now.Day);

            Console.WriteLine("Поточний час - {0}: {1}: {2}", now.Hour, now.Minute, now.Second);

            Console.WriteLine("День тижня: {0}", now.DayOfWeek);
            Console.WriteLine("Це {0} -й день року", now.DayOfYear);

            // Отримуємо дату поточного комп'ютера і значення часу, рівне (00:00:00).
            Console.WriteLine(DateTime.Now.Date);

            // Затримка.
            Console.ReadKey();
        }
    }
}