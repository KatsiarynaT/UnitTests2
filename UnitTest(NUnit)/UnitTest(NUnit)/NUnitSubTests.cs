using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitSubTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(9, 6, 3)]
        [TestCase(-8, -6, -2)]
        public void ReturnDifferenceOfIntNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Sub(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(9.2, 6.3, 2.9)]
        [TestCase(-81.6, 1.3, -82.9)]
        public void ReturnDifferenceOfDoubleNumbers(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Sub(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [Test]
        [TestCase("9", "6", "3")]
        [TestCase("-8", "-6", "-2")]
        public void ReturnDifferenceOfStringNumbers(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Sub(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TearDown]
        public void TestTearDown() 
        {
            testCalc = null;
        }
    }
}