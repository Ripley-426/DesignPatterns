using DesignPatterns.Examples.Lift;
using NUnit.Framework;

namespace ExamplesTests
{
    public class LiftShould
    {
        private Lift _lift;
        
        [SetUp]
        public void Setup()
        {
            _lift = new Lift();
        }

        [Test]
        public void GoUp()
        {
            //Assert.AreEqual();
        }
        
        [Test]
        public void GoDown()
        {
            Assert.Pass();
        }
        
        [Test]
        public void InvertStateAfterReachingUpperLevel()
        {
            Assert.Pass();
        }
        
        [Test]
        public void InvertStateAfterReachingLowerLevel()
        {
            Assert.Pass();
        }
    }
}