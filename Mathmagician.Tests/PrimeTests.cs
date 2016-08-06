using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void PrimeEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Prime primeCommand = new Prime(); // What I want to be able to do

            //Assert
            Assert.IsNotNull(primeCommand);

        }

        [TestMethod]
        public void PrimeInitialNumberTest()
        {
            //Arrange
            Prime my_prime = new Prime();
            //Act
            int ResultingPrime = my_prime.FirstPrime();
            //Assert
            Assert.AreEqual(2, ResultingPrime);
        }

        [TestMethod]
        public void NextPrime()
        {
            //Arrange
            Prime my_prime = new Prime();
            //Act
            int NextPrime = my_prime.FollowingPrime(3);
            //Assert
            Assert.AreEqual(3, NextPrime);
        }

        [TestMethod]
        public void PrimeSequenceOfNumbers()
        {
            //Arrange
            Prime my_prime = new Prime();
            //Act
            List<int> PrimeNumberSequence = my_prime.Sequence(6);
            List<int> PrimeExpectedSequence = new List<int> { 2, 3, 5, 7, 11, 13 };
            //Assert
            Assert.AreEqual(PrimeExpectedSequence.Count, PrimeNumberSequence.Count);
        }
    }
}
