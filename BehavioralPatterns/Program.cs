using BehavioralPatterns.Strategy.AnimalsExample;
using BehavioralPatterns.Strategy.AnimalsExample.Base;

namespace BehavioralPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal zuca = new Dog();
            Animal mica = new Bird();

            Console.WriteLine("Dog: " + zuca.tryToFly());
            Console.WriteLine("Bird: " + mica.tryToFly());

            zuca.setFlyingAbility(new ItFlys());
            Console.WriteLine("Dog: " + zuca.tryToFly());
        }
    }
}