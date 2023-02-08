using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitAddTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(19, 6, 25)]
        [TestCase(-8, -6, -14)]
        public void ReturnSumOfIntNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Add(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(9.2, 6.3, 15.5)]
        [TestCase(-81.6, 1.3, -80.3)]
        public void ReturnSumOfDoubleNumbers(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Add(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [Test]
        [TestCase("91", "5", "96")]
        [TestCase("-8", "-61", "-69")]
        public void ReturnSumOfStringNumbers(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Add(firstNumber, secondNumber);

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