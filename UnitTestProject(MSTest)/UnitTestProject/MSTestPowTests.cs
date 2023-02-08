using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestPowTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(14, 2, 196)]
        [DataRow(6, 0, 1)]
        public void ReturnPowerOfIntNumber(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Pow(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(6.25, 0.5, 2.5)]
        [DataRow(1.2, -0.5, 1.44)]
        public void ReturnPowerOfDoubleNumber(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Pow(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("3", "7", "2187")]
        [DataRow("5", "1", "5")]
        public void ReturnPowerOfStringNumber(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Pow(firstNumber, secondNumber);

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

