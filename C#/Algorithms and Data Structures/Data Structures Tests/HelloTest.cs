using Data_Structures;
using NUnit.Framework;

namespace Data_Structures_Tests
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
        public void InvokeHelloTest_OnCall_HelloDataStructures()
        {
            // Act.

            // Arrange.

            // Assert.
            Assert.AreEqual(HelloDataStructures.Hello(), "Hello, Data Structures!");
        }
    }
}