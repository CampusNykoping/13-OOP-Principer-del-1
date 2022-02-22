using System;
using System.Text;

namespace _02_Arv_och_åtkomst
{
    class Creature
    {
        public bool HasSpine { get; set; }
        protected string Name { get; private set; }
        public Creature(bool spine)
        {
            HasSpine = spine;
        }
        private void Talk()
        {
            Console.WriteLine("Jag är en varelse");
        }
        protected void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
    class Mammal : Creature
    {
        public int Age { get; set; }
        public Mammal(int age)
            :base(true)
        {
            this.Age = age;
        }

        //Talk();    // Funkar inte
        //this.Name = "Rex";  // Funkar inte
    }
    class Dog : Mammal
    {
        public Dog(int age, string breed)
            : base(age)
        {
            this.Breed = breed;
            //this.Name = "Standardnamn";     // Funkar inte ty Creature.Name har private set
        }
        public string Breed { get; private set; }
        //Talk(); // Funkar inte
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog joe = new Dog(5, "Schäfer");
            Console.WriteLine(joe.ToSt ring());
            //joe.Walk(); // Funkar inte ty protected
            //joe.Talk();     // Funkar inte ty private
            //joe.Name = "Rex";   // Funkar inte ty Creature.Name har private set
            //joe.Breed = "Labrador"; // Funkar inte ty Dog.Brteed har private set
        }
    }
}
