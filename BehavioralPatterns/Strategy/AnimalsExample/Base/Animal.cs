using BehavioralPatterns.Strategy.AnimalsExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.AnimalsExample.Base
{
    public class Animal
    {
        protected string Name { get; set; }
        protected double High { get; set; }
        protected int Weight { get; set; }
        protected string FavFood { get; set; }
        protected double Speed { get; set; }
        protected string Sound { get; set; }

        public Flys flyingType; // this is the point of the strategy pattern. This can be modified (fly or cant fly) in runtime, based on Animal subclass type.

        // This is bad, bcs we never want to add any methods to super class. We need to separate what is different between sub classes and super classes.
        //public void fly()
        //{
        //    Console.WriteLine("I'm flying.");
        //}

        public string tryToFly()
        {
            return flyingType.fly();
        }

        public void setFlyingAbility(Flys newFlyType)
        {
            flyingType = newFlyType;
        }
    }
}
