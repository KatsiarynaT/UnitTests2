using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestCosTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(0, 1)]
        public void ReturnCosOfIntNumber(int number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Cos(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(1.0472, 0.5)]
        [DataRow(4.18879, -0.5)]
        public void ReturnCosOfDoubleNumber(double number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Cos(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestMethod]
        [DataRow("1.0472", "0.5")]
        [DataRow("0", "1")]
        public void ReturnCosOfStringNumber(string number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Cos(number);

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