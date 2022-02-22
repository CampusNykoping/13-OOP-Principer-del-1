using System;

namespace _05_Gränssnitt
{
    interface IAnimal
    {
        void Sound();
    }
    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Hunden säger Vov!");
        }
    }
    class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Katten säger Mjau!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            myDog.Sound();
            myCat.Sound();
        }
    }
}
