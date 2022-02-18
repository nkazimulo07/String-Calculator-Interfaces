using NUnit.Framework;
using StringCalculatorI.Models;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class CheckNumbersTest
    {
        private CheckNumbers _checkNumbers;

        [SetUp]
        public void Setup()
        {
        
            _checkNumbers = new CheckNumbers();
        }

        [Test]
        public void WhenIntList_UsingCheckNegatives_ResultsReturnsException()
        {
            var input = new List<int> {  8, 16, -1 };
            Assert.Throws<System.Exception>(() => _checkNumbers.CheckNegatives(input));
        }

        [Test]
        public void WhenListOfNumbersAndOneIsGreaterThanOneThousand_UsingCheckNumbersGreaterThanOneThousand_ResultsReturnsList()
        {
            // arrange
            var input = new List<int>() { 1000, 200, 7000, 10 };
            var expected = new List<int> { 200, 10 };

            // act 
            var results = _checkNumbers.CheckNumbersGreaterThanOneThousand(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}
