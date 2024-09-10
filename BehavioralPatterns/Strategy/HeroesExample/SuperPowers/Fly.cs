using BehavioralPatterns.Strategy.HeroesExample.SuperPowers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.HeroesExample.SuperPowers
{
    public class Fly : ISuperPower
    {
        public string ExercisePower() => "Up, Up, and Away!";
    }
}
