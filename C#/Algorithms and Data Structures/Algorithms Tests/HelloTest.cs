using Algorithms;
using NUnit.Framework;

namespace Algorithms_Tests
{
    public class HelloTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        /*
         * Test Method Name
         * MethodName_Senario_ExpectedResults
         */
        public void InvokeHelloTest_OnCall_HelloAlgorithmsDataStructures()
        {
            // Act.

            // Arrange.

            // Assert.
            Assert.AreEqual(HelloAlgorithms.Hello(), "Hello, Algorithms!");
        }
    }
}