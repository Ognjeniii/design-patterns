using BehavioralPatterns.Strategy.HeroesExample.Heroes.Interfaces;
using BehavioralPatterns.Strategy.HeroesExample.Heroes;
using BehavioralPatterns.Strategy.HeroesExample.SuperPowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsTest
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void ShouldReturnSuperPower()
        {
            IHero spiderMan = new SpiderMan();
            Assert.AreEqual(new WeaveWeb().ExercisePower(), spiderMan.DoHeroStuff());
            IHero superMan = new SuperMan();
            Assert.AreEqual(new Fly().ExercisePower(), superMan.DoHeroStuff());
            IHero batMan = new BatMan();
            Assert.AreEqual(new Fight().ExercisePower(), batMan.DoHeroStuff());
        }

        [TestMethod]
        public void ShouldReturnChangedSuperPower()
        {
            IHero spiderMan = new SpiderMan();
            Assert.AreEqual(new WeaveWeb().ExercisePower(), spiderMan.DoHeroStuff());
            spiderMan.ChangeSuperPower(new Fight());
            Assert.AreEqual(new Fight().ExercisePower(), spiderMan.DoHeroStuff());
            spiderMan.ChangeSuperPower(new Fly());
            Assert.AreEqual(new Fly().ExercisePower(), spiderMan.DoHeroStuff());
        }
    }
}
