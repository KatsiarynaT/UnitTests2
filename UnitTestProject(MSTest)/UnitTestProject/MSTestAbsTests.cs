using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestAbsTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(15, 15)]
        [DataRow(-36, 36)]
        public void ReturnAbsoluteOfIntNumber(int number, int expectedResult)
        {
            // act
            double actualResult = testCalc.Abs(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(9.9, 9.9)]
        [DataRow(-3.6, 3.6)]
        public void ReturnAbsoluteOfDoubleNumber(double number, double expectedResult)
        {
            // act
            double actualResult = testCalc.Abs(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("-9", "9")]
        [DataRow("26", "26")]
        public void ReturnAbsoluteOfStringNumber(string number, string expectedResult)
        {
            // act
            double actualResult = testCalc.Abs(number);

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
