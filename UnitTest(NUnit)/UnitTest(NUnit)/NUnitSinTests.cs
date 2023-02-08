using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitSinTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(0, 0)]
        public void ReturnSinOfIntNumber(int number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Sin(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(1.2, 0.932)]
        [TestCase(2.7, 0.427)]
        public void ReturnSinOfDoubleNumber(double number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Sin(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        [TestCase("1.5708", "1")]
        [TestCase("0", "0")]
        public void ReturnSinOfStringNumber(string number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Sin(number);

            // assert
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.1);
        }

        [TearDown]
        public void TestTearDown()
        {
            testCalc = null;
        }
    }
}
