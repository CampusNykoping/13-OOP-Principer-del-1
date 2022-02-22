using System;

namespace _03_Övning_1
{
    internal class Person
    {
        private int _age;

        public Person() : this(30)
        {

        }
        public Person(int age)
        {
            _age = age;
        }
        public void Greet()
        {
            Console.WriteLine("Hej på dig!");
        }
        public void SetAge(int n)
        {
            _age = n;
        }
        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
}