using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitMultiplyTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(150, 0, 0)]
        [TestCase(-6, 6, -36)]
        public void ReturnMultiplicationResultOfIntNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Multiply(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(30.3, 1.5, 45.45)]
        [TestCase(1.1, -1.5, -1.65)]
        public void ReturnMultiplicationResultOfDoubleNumbers(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Multiply(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }

        [Test]
        [TestCase("38", "2", "76")]
        [TestCase("12", "-12", "-144")]
        public void ReturnMultiplicationResultOfStringNumbers(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Multiply(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber));

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
