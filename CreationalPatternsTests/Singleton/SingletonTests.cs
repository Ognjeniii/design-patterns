using CreationalPatterns.Singleton;

namespace CreationalPatternsTests.Singleton
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
            Assert.AreEqual(first.SomeValue, second.SomeValue);
            second.SomeValue++;
            Assert.AreEqual(first.SomeValue, second.SomeValue);
        }
    }
}