using NUnit.Framework;
using StringCalculatorI;
using StringCalculatorI.Models;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class CheckNumbersTest
    {
        private CheckNumbers _checkNegativeNumbers;

        [SetUp]
        public void Setup()
        {
            _checkNegativeNumbers = new CheckNumbers();
        }

        [Test]
        public void WhenIntList_UsingCheckNegatives_ResultsReturnsException()
        {
            var input = new List<int> {  8, 16, -1 };
            Assert.Throws<System.Exception>(() => _checkNegativeNumbers.CheckNegatives(input));
        }
    }
}
