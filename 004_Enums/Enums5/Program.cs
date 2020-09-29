using System;
using System.Text;

// Перерахування. Отримання інформації про тип елементів перерахування.

namespace Enums
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            EnumType digit = EnumType.Ten;

            // Enum.GetUnderlyingType () - показує тип, який використовується для представлення
            // числових значень елементів перерахування.
            Type @enum = digit.GetType();

            Console.Write("1. Перерахування {0} складається з елементів типу:", @enum.Name);

            Type @const = Enum.GetUnderlyingType(@enum);

            Console.WriteLine(@const);

            // оператор typeof - повертає екземпляр класу System.Type, який містить інформацію
            // про той тип, який був переданий як аргумент даного оператора.

            Console.Write( "2. Перерахування EnumType складається з елементів типу:");

            Console.WriteLine(Enum.GetUnderlyingType (typeof (EnumType)));

            // Delay.
            Console.ReadKey();
        }
}
}