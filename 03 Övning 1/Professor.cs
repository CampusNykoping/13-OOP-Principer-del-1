using System;

namespace _03_Övning_1
{
    internal class Professor : Person
    {
        public string Name { get; set; }
        public Professor(int age, string name) : base(age)
        {
            //base.Age = age;
            Name = name;
        }
        internal void Teach()
        {
            Console.WriteLine("Jag undervisar");
        }
    }
}