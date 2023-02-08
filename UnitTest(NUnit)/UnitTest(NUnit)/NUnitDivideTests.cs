using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitDivideTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(50, 5, 10)]
        [TestCase(-36, 6, -6)]
        public void ReturnDivisionResultOfIntNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Divide(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(30.3, 1.5, 20.2)]
        [TestCase(-45.45, -1.5, 30.3)]
        public void ReturnDivisionResultOfDoubleNumbers(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Divide(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("38", "2", "19")]
        [TestCase("12", "-12", "-1")]
        public void ReturnDivisionResultOfStringNumbers(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Divide(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber));

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

