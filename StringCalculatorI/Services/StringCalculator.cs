using StringCalculatorI.Interfaces;

namespace StringCalculatorI
{
    public class StringCalculator : IStringCalculator
    {
        private IGetNumbers _getNumbers;

        public StringCalculator(IGetNumbers getNumbers)
        {
            _getNumbers = getNumbers;
        }

        public int Add(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;
            }

            var numbers = _getNumbers.GetListOfNumber(number);

            return SumOfNumbers(numbers);
        }

        public int SumOfNumbers(List<int> numbers)
        {
            return numbers.Sum();
        }
    }
}