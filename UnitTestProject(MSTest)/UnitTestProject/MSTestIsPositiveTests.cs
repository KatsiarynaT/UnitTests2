using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestIsPositiveTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(150,true)]
        [DataRow(-6, false)]
        [DataRow(0, false)]
        public void DetectPositiveIntNumber(int number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isPositive(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(20.3, true)]
        [DataRow(-116.68, false)]
        public void DetectPositiveDoubleNumber(double number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isPositive(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("2", true)]
        [DataRow("-85", false)]
        public void DetectPositiveStringNumber(string number, bool expectedResult)
        {
            // act
            bool actualResult = testCalc.isPositive(number);

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

