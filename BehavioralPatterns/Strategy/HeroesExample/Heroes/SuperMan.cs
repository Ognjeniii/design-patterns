using BehavioralPatterns.Strategy.HeroesExample.Heroes.Base;
using BehavioralPatterns.Strategy.HeroesExample.SuperPowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.HeroesExample.Heroes
{
    public class SuperMan : HeroBase
    {
        public SuperMan() : base(new Fly())
        {
        }
    }
}
