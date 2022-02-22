using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enkelt_arv
{
    public class Mammal
    {
        // Fält


        // Konstruktorer
        public Mammal(int age)
        {
            this.Age = age;
        }

        // Egenskaper
        //public int Age { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }


        // Metoder
        public void Sleep()
        {
            Console.WriteLine("Shhh! Jag sover!");
        }
    }
}
