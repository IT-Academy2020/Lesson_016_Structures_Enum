using System;

// Boxing і UnBoxing.

namespace Boxing
{
    interface IInterface
    {
        void Method();
    }

    struct MyStruct : IInterface
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
            MyStruct my;
            my.Method();
            // Упаковка (Boxing).
            IInterface boxed = my;

            boxed.Method();

            // Розпакування об'єкта (UnBoxing).
            MyStruct unBoxed = (MyStruct)boxed;

            // Delay.
            Console.ReadKey();
        }
    }
}