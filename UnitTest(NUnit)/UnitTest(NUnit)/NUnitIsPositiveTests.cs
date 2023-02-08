using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitIsPositiveTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(150, true)]
        [TestCase(-6, false)]
        [TestCase(0, false)]
        public void DetectPositiveIntNumber(int number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isPositive(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(20.3, true)]
        [TestCase(-116.68, false)]
        public void DetectPositiveDoubleNumber(double number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isPositive(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("2", true)]
        [TestCase("-85", false)]
        public void DetectPositiveStringNumber(string number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isPositive(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TestTearDown()
        {
            testCalc = null;
        }
    }
}
