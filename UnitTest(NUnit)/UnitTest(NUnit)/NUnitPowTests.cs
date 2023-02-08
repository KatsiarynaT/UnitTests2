using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitPowTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(14, 2, 196)]
        [TestCase(6, 0, 1)]
        public void ReturnPowerOfIntNumber(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Pow(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(6.25, 0.5, 2.5)]
        [TestCase(1.2, -0.5, 1.44)]
        public void ReturnPowerOfDoubleNumber(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Pow(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("3", "7", "2187")]
        [TestCase("5", "1", "5")]
        public void ReturnPowerOfStringNumber(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Pow(firstNumber, secondNumber);

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
