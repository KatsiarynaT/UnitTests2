using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectTests
{
    [TestClass]
    public class MSTestSinTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(0, 0)]
        public void ReturnSinOfIntNumber(int number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Sin(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(1.2, 0.932)]
        [DataRow(2.7, 0.427)]
        public void ReturnSinOfDoubleNumber(double number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Sin(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        [DataRow("1.5708", "1")]
        [DataRow("0", "0")]
        public void ReturnSinOfStringNumber(string number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Sin(number);

            // assert
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.1);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            testCalc = null;
        }
    }
}