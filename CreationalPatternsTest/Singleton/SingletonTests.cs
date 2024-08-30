using CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsTest.Singleton
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void ShouldCreateJustOneInstance()
        {
            MySingletonClass first = MySingletonClass.Instance;
            MySingletonClass second = MySingletonClass.Instance;
            Assert.AreSame(first, second);
            first.SomeValue++;
            Assert.Equals(second, first);
            second.SomeValue++;
            Assert.Equals(first, second);
        }
    }
}
