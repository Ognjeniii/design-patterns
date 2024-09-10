using BehavioralPatterns.Strategy.HeroesExample.Heroes.Interfaces;
using BehavioralPatterns.Strategy.HeroesExample.SuperPowers;
using BehavioralPatterns.Strategy.HeroesExample.SuperPowers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.HeroesExample.Heroes.Base
{
    public abstract class HeroBase : IHero
    {
        private ISuperPower _power;

        protected HeroBase() : this(new RegularJoe())
        {
        }

        protected HeroBase(ISuperPower power)
        {
            _power = power;
        }

        public string DoHeroStuff() => _power.ExercisePower();

        public void ChangeSuperPower(ISuperPower power)
        {
            _power = power;
        }
    }
}
