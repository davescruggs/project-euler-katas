using System;
using ConsolePrimeFactorOf600851475143;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePrimeFactors.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFindLargestPrimeFactorOf9()
        {
            long testNumber = 9;
            long result = PrimeSieve.findLargestPrimeFactor(testNumber);
            long expected = 3;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFindLargestPrimeFactorOf12()
        {
            long testNumber = 12;
            long result = PrimeSieve.findLargestPrimeFactor(testNumber);
            long expected = 3;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFindLargestPrimeFactorOf25()
        {
            long testNumber = 25;
            long result = PrimeSieve.findLargestPrimeFactor(testNumber);
            long expected = 5;
            Assert.AreEqual(expected, result);
        }

        [TestMethod,ExpectedException(typeof(System.InvalidOperationException))]
        public void TestFindLargestPrimeFactorOf11()
        {
            long testNumber = 11;
            long result = PrimeSieve.findLargestPrimeFactor(testNumber);
        }

        [TestMethod]
        public void TestFindLargestPrimeFactorOf7245()
        {
            long testNumber = 7245;
            long result = PrimeSieve.findLargestPrimeFactor(testNumber);
            long expected = 23;
            Assert.AreEqual(expected, result);
        }


         
        [TestMethod]
        public void TestFindLargestPrimeFactorOf600851475143()
        {
            long testNumber = 600851475143;
            long result = PrimeSieve.findLargestPrimeFactor(testNumber);
            long expected = 6857;
            Assert.AreEqual(expected, result);
        }
    }
}
