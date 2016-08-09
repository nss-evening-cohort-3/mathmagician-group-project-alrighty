using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Fibonacci fibonacciCommand = new Fibonacci(); // What I want to be able to do

            //Assert
            Assert.IsNotNull(fibonacciCommand);

        }

        [TestMethod]
        public void fibonacciInitialNumberTest()
        {
            //Arrange
            Fibonacci my_fibonacci = new Fibonacci();
            //Act
            int ResultingNumber = my_fibonacci.FirstNumber();
            //Assert
            Assert.AreEqual(1, ResultingNumber);
        }

        [TestMethod]
        public void NextFibonacciNum()
        {
            //Arrange
            Fibonacci my_fibonacci = new Fibonacci();
            //Act
            int NextNumber = my_fibonacci.FollowingNumber(5);
            //Assert
            Assert.AreEqual(8, NextNumber);
        }

        [TestMethod]
        public void FibonacciSequenceOfNumbers()
        {
            //Arrange
            Fibonacci my_fibonacci = new Fibonacci();
            //Act
            List<int> NumberSequence = my_fibonacci.Sequence(6);
            List<int> ExpectedSequence = new List<int> { 1, 1, 3, 5, 8, 13 };
            //Assert
            Assert.AreEqual(ExpectedSequence.Count, NumberSequence.Count);
            CollectionAssert.AreEqual(NumberSequence, ExpectedSequence);
        }
    }
}
