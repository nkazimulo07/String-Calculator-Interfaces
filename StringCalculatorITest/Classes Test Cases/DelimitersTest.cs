using NUnit.Framework;
using StringCalculatorI;
using StringCalculatorI.Models;

namespace StringCalculatorKataTest
{
    public class DelimitersTest
    {
        private Delimiters delimiters;

        [SetUp]
        public void Setup()
        {
            delimiters = new Delimiters();
        }

        [Test]
        public void WhenStringWithMultipleDelimiter_UsingGetMultipleDelimeters_ResultsReturnsArrayOfDelimiters()
        {
            // arrange
            const string input = "[*][%][:][;]";
            string[] expected = { "*", "%", ":", ";" };

            // act 
            var results = delimiters.GetMultipleDelimiters(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}
