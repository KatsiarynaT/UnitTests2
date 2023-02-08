using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitIsNegativeTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(150, false)]
        [TestCase(-6, true)]
        [TestCase(0, false)]
        public void DetectNegativeIntNumber(int number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isNegative(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(20.3, false)]
        [TestCase(-116.68, true)]
        public void DetectNegativeDoubleNumber(double number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isNegative(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("2", false)]
        [TestCase("-85", true)]
        public void DetectNegativeStringNumber(string number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isNegative(number);

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

