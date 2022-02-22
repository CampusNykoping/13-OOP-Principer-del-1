using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enkelt_arv
{
    class Program
    {
        public static void Main()
        {
            Dog dog1 = new Dog(5, "Labrador");

            dog1.WagTail();
            dog1.Sleep();
            dog1.Age = 6;
            Console.WriteLine(dog1.Breed);
        }
    }
}
