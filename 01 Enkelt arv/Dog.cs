using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enkelt_arv
{
    class Dog : Mammal
    {
        public Dog(int age, string breed)
            : base(age)
        {
            this.Breed = breed;
            //_age = 2;       // Går inte, för Mammal._age är private
        }

        public string Breed { get; set; }

        public void WagTail()
        {
            Console.WriteLine("Viftar på svansen...");
        }
    }
}
