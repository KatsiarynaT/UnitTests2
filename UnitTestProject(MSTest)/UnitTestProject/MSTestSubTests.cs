using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestSubTest
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(18, 6, 12)]
        [DataRow(-36, 3, -39)]
        public void ReturnDifferenceOfIntNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Sub(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(14.7, 5.2, 9.5)]
        [DataRow(-3.6, -2.1, -1.5)]
        public void ReturnDifferenceOfDoubleNumbers(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Sub(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("38", "16", "22")]
        [DataRow("12", "-2", "14")]
        public void ReturnDifferenceOfStringNumbers(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Sub(firstNumber, secondNumber);

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
