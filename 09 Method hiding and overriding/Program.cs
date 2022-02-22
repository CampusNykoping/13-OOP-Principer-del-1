using System;

namespace _09_Method_hiding_and_overriding
{
    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class print method");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Derived Class print method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();
        }
    }
}
