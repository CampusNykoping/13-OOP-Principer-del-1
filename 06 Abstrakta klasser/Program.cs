using System;

namespace _06_Abstrakta_klasser
{
    public abstract class Animal : IComparable<Animal>
    {
        // Abstrakta metoder
        public abstract string GetName();
        public abstract int Speed { get; }

        // Konkret (icke-abstrakt) metod
        public override string ToString()
        {
            return "Jag är en " + this.GetName();
        }

        // Interfacemetoden
        public int CompareTo(Animal other)
        {
            return this.Speed.CompareTo(other.Speed);
        }        
    }
    public class Turtle : Animal
    {
        public override string GetName()
        {
            return "turtle";
        }

        public override int Speed { get { return 1; } }
    }

    public class Cheetah : Animal
    {
        public override string GetName()
        {
            return "cheetah";
        }

        public override int Speed { get { return 100; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var skoldpadda = new Turtle();
            var gepard = new Cheetah();

            Console.WriteLine(skoldpadda + " Jag springer i {0} km/h", skoldpadda.Speed);
            Console.WriteLine(gepard + " Jag springer i {0} km/h", gepard.Speed);
        }
    }
}
