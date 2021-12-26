using NUnit.Framework;
using Problems;

namespace ProblemsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(HelloProblems.Hello(), "Hello, Algo & Ds Problems!");
        }
    }
}