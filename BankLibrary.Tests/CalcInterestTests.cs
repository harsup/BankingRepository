using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingLibrary;

namespace BankLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            //Arrange
            int ExpectedResult = 1000;
            //Act
            ICalcInterest calc = new CalcInterest();
            int ActualResult = calc.Calculate(10000, 1, 10);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
