using StringCalculatorI.Interfaces;

namespace StringCalculatorI.Models
{
    public class GetNumbers : IGetNumbers
    {
        private IConvertNumbers _convertNumbers;
        private IDelimiters _delimiters;

        public GetNumbers(IConvertNumbers convertNumbers, IDelimiters delimiters)
        {
           _convertNumbers = convertNumbers;
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

            return _convertNumbers.ConvertStringArrayToIntList(result);
        }
    }
}
