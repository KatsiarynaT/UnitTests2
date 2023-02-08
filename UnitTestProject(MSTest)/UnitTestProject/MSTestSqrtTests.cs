using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestSqrtTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(36, 6)]
        [DataRow(625, 25)]
        public void ReturnSquareRootOfIntNumber(int number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Sqrt(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(12.96, 3.6)]
        [DataRow(6.25, 2.5)]
        public void ReturnSquareRootOfDoubleNumber(double number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Sqrt(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestMethod]
        [DataRow("49", "7")]
        [DataRow("144", "12")]
        public void ReturnSquareRootOfStringNumber(string number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Sqrt(number);

            // assert
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            testCalc = null;
        }
    }
}


