using System;

// Форматований вивід дати і часу

namespace DateTime3
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Дата місяць (прописом) рік: {0: D}", now);
            Console.WriteLine("Дата.месяц.год: {0: d}", now);
            Console.WriteLine("Дата місяць (прописом) рік час (гг: мм: сс): {0: F}", now);
            Console.WriteLine("Дата місяць (прописом) рік час (гг: мм): {0: f}", now);
            Console.WriteLine("Дата.месяц.год час (гг: мм: cc): {0: G}", now);
            Console.WriteLine("Дата.месяц.год час (гг: мм): {0: g}", now);
            Console.WriteLine("За цей місяць і дата: {0: M}", now);
            Console.WriteLine("За цей місяць і рік: {0: Y}", now);
            Console.WriteLine("Час (чч: мм: cc): {0: T}", now);
            Console.WriteLine("Час (год: хв): {0: t}", now);

            // Delay.
            Console.ReadKey();
        }
    }
}