using StringCalculatorI.Interfaces;

namespace StringCalculatorI.Models
{
    public class GetNumbers : IGetNumbers
    {
        private readonly ICheckNumbers _checkNumbers;
        private readonly IDelimiters _delimiters;

        public GetNumbers(ICheckNumbers checkNumbers, IDelimiters delimiters)
        {
            _checkNumbers = checkNumbers;
            _delimiters = delimiters;
        }

        public List<int> GetListOfNumber(string numbers)
        {
            var delimiters = _delimiters.GetDelimiter(numbers);

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(numbers.LastIndexOf('\n') + 1);
            }

            string[] result = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);

            return ConvertStringArrayToIntList(result);
        }

        public List<int> ConvertStringArrayToIntList(string[] numbers)
        {
            var result = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                result.Add(Convert.ToInt32(numbers[i]));
            }

            return _checkNumbers.CheckNegatives(result);
        }
    }
}
