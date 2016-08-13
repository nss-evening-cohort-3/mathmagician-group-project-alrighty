using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Integer integerCommand = new Integer(); // What I want to be able to do

            //Assert
            Assert.IsNotNull(integerCommand);

        }

        [TestMethod]
        public void IntegerInitialNumberTest()
        {
            //Arrange
            Integer my_int = new Integer();
            //Act
            int ResultingNumber = my_int.FirstNumber();
            //Assert
            Assert.AreEqual(1, ResultingNumber);
        }

        [TestMethod]
        public void NextInteger()
        {
            //Arrange
            Integer my_int = new Integer();
            //Act
            int NextNumber = my_int.FollowingNumber(3);
            //Assert
            Assert.AreEqual(4, NextNumber);
        }

        [TestMethod]
        public void IntegerSequenceOfNumbers()
        {
            //Arrange
            Integer my_int = new Integer();
            //Act
            List<int> NumberSequence = my_int.IntegerSequence(6);
            List<int> ExpectedSequence = new List<int> {1, 2, 3, 4, 5, 6};
            //Assert
            Assert.AreEqual(ExpectedSequence.Count, NumberSequence.Count);
        }
    }
}
