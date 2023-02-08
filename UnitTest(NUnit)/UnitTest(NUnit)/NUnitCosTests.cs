using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitCosTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(0, 1)]
        public void ReturnCosOfIntNumber(int number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Cos(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(1.0472, 0.5)]
        [TestCase(4.18879, -0.5)]
        public void ReturnCosOfDoubleNumber(double number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Cos(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [Test]
        [TestCase("1.0472", "0.5")]
        [TestCase("0", "1")]
        public void ReturnCosOfStringNumber(string number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Cos(number);

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
