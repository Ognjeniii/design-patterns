using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.Strategy.AnimalsExample.Base;

namespace BehavioralPatterns.Strategy.AnimalsExample
{
    public class Dog : Animal
    {
        public void digHole()
        {
            Console.WriteLine("Dug a hole.");
        }

        public Dog() : base() 
        {
            Sound = "Bark";
            flyingType = new CantFly();
        }
    }
}
