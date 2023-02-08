using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitSqrtTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(36, 6)]
        [TestCase(625, 25)]
        public void ReturnSquareRootOfIntNumber(int number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Sqrt(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(12.96, 3.6)]
        [TestCase(6.25, 2.5)]
        public void ReturnSquareRootOfDoubleNumber(double number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Sqrt(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [Test]
        [TestCase("49", "7")]
        [TestCase("144", "12")]
        public void ReturnSquareRootOfStringNumber(string number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Sqrt(number);

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
