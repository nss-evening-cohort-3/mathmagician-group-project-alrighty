using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddNumTests
    {
        [TestMethod]
        public void OddEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            OddNum oddCommand = new OddNum(); // What I want to be able to do

            //Assert
            Assert.IsNotNull(oddCommand);

        }

        [TestMethod]
        public void OddSequenceOfNumbers()
        {
            //Arrange
            OddNum my_odd = new OddNum();
            //Act
            List<int> NumberSequence = my_odd.OddSequence(6);
            List<int> ExpectedSequence = new List<int> { 1, 3, 5, 7, 9, 11 };
            //Assert
            Assert.AreEqual(ExpectedSequence.Count, NumberSequence.Count);
            CollectionAssert.AreEqual(ExpectedSequence, NumberSequence);
        }
    }
}
