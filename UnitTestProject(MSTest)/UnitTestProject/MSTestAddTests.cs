using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestAddTests
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void TestInitialize()
        {
           testCalc= new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DataRow(8, 6, 14)]
        [DataRow(-36, 3, -33)]
        public void ReturnSumOfIntNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            // act
            double actualResult = testCalc.Add(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(4.7, 5.1, 9.8)]
        [DataRow(-3.6, -2.1, -5.7)]
        public void ReturnSumOfDoubleNumbers(double firstNumber, double secondNumber, double expectedResult)
        {
            // act
            double actualResult = testCalc.Add(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("8", "16", "24")]
        [DataRow("12", "-2", "10")]
        public void ReturnSumOfStringNumbers(string firstNumber, string secondNumber, string expectedResult)
        {
            // act
            double actualResult = testCalc.Add(firstNumber, secondNumber);

            // assert
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            testCalc=null;
        }
    }
}
