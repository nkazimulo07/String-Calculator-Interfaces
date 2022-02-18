using NUnit.Framework;
using StringCalculatorI.Services;

namespace StringCalculatorKataTest
{
    public class DelimitersTest
    {
        private Delimiters _delimiters;

        [SetUp]
        public void Setup()
        {
            _delimiters = new Delimiters();
        }

        [Test]
        public void WhenStringWithMultipleDelimiter_UsingGetMultipleDelimeters_ResultsReturnsArrayOfDelimiters()
        {
            // arrange
            const string input = "[*][%][:][;]";
            string[] expected = { "*", "%", ":", ";" };

            // act 
            var results = _delimiters.GetMultipleDelimiters(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}
