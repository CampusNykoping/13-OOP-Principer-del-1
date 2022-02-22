using System;

namespace _03_Övning_1
{
    internal class Student : Person
    {          

        internal void ShowAge()
        {
        Console.WriteLine("Jag är {0} år gammal", base.Age);
        }

        internal void Study()
        {
            Console.WriteLine("Jag studerar");
        }
    }
}