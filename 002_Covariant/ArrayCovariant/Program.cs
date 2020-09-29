using System;

// Коваріантність не може бути застосована до масивів елементів структурних типів.

namespace ArrayCovariant
{
    public interface IAnimal
    {
        void Voice();
    }

    public struct Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Gav-Gav");
        }
    }

    class Program
    {
        static void Main()
        {
            // 1
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            //IAnimal [] animal = dogs; // Коваріантність.
            // dogs = array; // Контрваріантність.
            ValueType i = new Int32() as ValueType;

            // 2
            int[] vector = new int[3] { 1, 2, 3 };
            //object [] array = vector; // Коваріантність


            // Затримка.
            Console.ReadKey();
        }
    }
}