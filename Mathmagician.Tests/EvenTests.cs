using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Even evenCommand = new Even();

            //Assert
            Assert.IsNotNull(evenCommand);
        }

        [TestMethod]
        public void EvenInitialNumberTest()
        {
            //Arrange
            Even my_even = new Even();
            //Act
            int ResultingEven = my_even.FirstEven();
            //Assert
            Assert.AreEqual(2, ResultingEven);
        }

        [TestMethod]
        public void NextEven()
        {
            //Arrange
            Even my_even = new Even();
            //Act
            int NextEven = my_even.FollowingEven(4);
            //Assert
            Assert.AreEqual(4, NextEven);
        }

        [TestMethod]
        public void EvenSequenceOfNumbers()
        {
            //Arrange
            Even my_even = new Even();
            //Act
            List<int> EvenNumberSequence = my_even.EvenSequence(6);
            List<int> EvenExpectedSequence = new List<int> { 2, 4, 6, 8, 10, 12 };
            //Assert
            Assert.AreEqual(EvenExpectedSequence.Count, EvenNumberSequence.Count);
            CollectionAssert.AreEqual(EvenExpectedSequence, EvenNumberSequence);
        }
    }
}
