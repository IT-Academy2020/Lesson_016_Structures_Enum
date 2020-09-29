﻿using System;

// Упаковка і розпакування.

// Упаковка (Boxing) - перетворення структурного типу (типу значення) в reference тип
// (Object або будь-який інший тип інтерфейсу, що реалізовується цим типом).
// Коли value тип приводиться до типу Object, він створює програму-оболонку для значення, яке зберігається всередині
// System.Object і зберігає її в кучі.

// Розпакування (Unboxing) - перетворення reference типу в структурний тип.
// Операція розпакування-перетворення витягує value тип з об'єкта.
// Перед розпакуванням програма перевіряє сумісність між об'єктом і структурою,
// в яку буде відбуватися розпакування.

namespace Boxing
{
    class Program
    {
        static void Main()
        {

            short a = 25;

            // Упаковка змінної - а (Boxing).
            object o = a;

            // Розпакування об'єкта (UnBoxing).
            short b = (short)o;

            // Розпакування повинна проводитися тільки в той тип, з якого була зроблена упаковка.
            // byte s = (byte) o;

            // Delay.
            Console.ReadKey();
        }
    }
}