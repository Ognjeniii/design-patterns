using BehavioralPatterns.Strategy.HeroesExample.Heroes.Base;
using BehavioralPatterns.Strategy.HeroesExample.SuperPowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.HeroesExample.Heroes
{
    public class BatMan : HeroBase
    {
        public BatMan() : base(new Fight())
        {
        }
    }
}
