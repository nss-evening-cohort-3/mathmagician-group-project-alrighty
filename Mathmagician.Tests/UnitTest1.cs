using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass] // <- annotation; series of code that applies additional functionality to whatever it's attached to
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ThisShouldFail()
        {
            // Arrange

            // Act 

            // Assert
            Assert.Fail();
        }
    }
}
