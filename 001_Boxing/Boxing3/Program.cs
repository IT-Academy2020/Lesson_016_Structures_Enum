using System;

// Boxing і UnBoxing.

namespace Boxing
{
    struct MyStruct //: ValueType
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct my = new MyStruct();

            // Упаковка (Boxing).
            ValueType boxed = my;

            // Розпакування об'єкта (UnBoxing).
            MyStruct unBoxed = (MyStruct)boxed;

            // Delay.
            Console.ReadKey();
        }
    }
}