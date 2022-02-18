using NUnit.Framework;
using StringCalculatorI;
using StringCalculatorI.Models;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class StringCalculatorKataTest
    {
        private StringCalculator _stringCalculator;

        [SetUp]
        public void Setup()
        {
            var checkNumbers = new CheckNumbers();
            var delimeter = new Delimiters();
            var getnumbers = new GetNumbers(checkNumbers, delimeter);
            _stringCalculator = new StringCalculator(getnumbers);
        }

        [Test]
        public void WhenPassingEmptyString_UsingAdd_ResultsReturnsZero()
        {
            // arrange
            const string input = "";
            const int expected = 0;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithOneNumber_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "1";
            const int expected = 1;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithTwoNumbers_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "1,2";
            const int expected = 3;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithNextLine_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "1,2\n3";
            const int expected = 6;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithMoreNumbers_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "1,2\n3,4,5";
            const int expected = 15;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenArrayOfIntegers_UsingSumOfNumbers_ResultsReturnsSum()
        {
            // arrange
            List<int> input = new List<int>() { 1, 2, 7 };
            const int expected = 10;

            // act 
            var results = _stringCalculator.SumOfNumbers(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithANewDelimiter_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "//;\n1;2";
            const int expected = 3;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenUsingSquareBracketAsADelimiter_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "//[\n1[2[10";
            const int expected = 13;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithNumberGreaterThanOneThousand_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "1000,2";
            const int expected = 2;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithDelimiterOfAnyLength_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "//***\n1***2***3";
            const int expected = 6;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenWithMultipleDelimiters_UsingAdd_ResultsReturnsSum()
        {
            // arrange
            const string input = "//[*][%]\n1*2%3";
            const int expected = 6;

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenStringWithNegativeNumber_UsingAdd_ResultsReturnsException()
        {
            Assert.Throws<System.Exception>(() => _stringCalculator.Add("1\n2,-3"));
        }

    }
}