using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestIsNegativeTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(150, false)]
        [DataRow(-6, true)]
        [DataRow(0, false)]
        public void DetectNegativeIntNumber(int number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isNegative(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(20.3, false)]
        [DataRow(-116.68, true)]
        public void DetectNegativeDoubleNumber(double number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isNegative(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("2", false)]
        [DataRow("-85", true)]
        public void DetectNegativeStringNumber(string number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isNegative(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            testCalc = null;
        }
    }
}
