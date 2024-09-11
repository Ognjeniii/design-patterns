using BehavioralPatterns.Strategy.AnimalsExample.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.AnimalsExample
{
    public class ItFlys : Flys
    {
        public string fly()
        {
            return "Flying high.";
        }
    }
}
