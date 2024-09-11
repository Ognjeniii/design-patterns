using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.Strategy.AnimalsExample.Base;

namespace BehavioralPatterns.Strategy.AnimalsExample
{
    public class Bird : Animal
    {
        public Bird() : base()
        {
            Sound = "Tweet";
            flyingType = new ItFlys();
        }
    }
}
