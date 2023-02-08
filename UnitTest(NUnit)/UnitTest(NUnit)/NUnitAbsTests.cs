using NUnit.Framework;
using System;

namespace UnitTest_NUnit_
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitAbsTests
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void TestSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [Test]
        [TestCase(115, 115)]
        [TestCase(-84, 84)]
        public void ReturnAbsoluteOfIntNumber(int Number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Abs(Number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(9.2, 9.2)]
        [TestCase(-81.6, 81.6)]
        public void ReturnAbsoluteOfDoubleNumber(double Number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Abs(Number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("91", "91")]
        [TestCase("-8", "8")]
        public void ReturnAbsoluteOfStringNumber(string Number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Abs(Number);

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