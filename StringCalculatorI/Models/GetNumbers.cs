using StringCalculatorI.Interfaces;

namespace StringCalculatorI.Models
{
    public class GetNumbers : IGetNumbers
    {
        private ConvertNumbers _convertNumbers;
        private Delimiters _delimiters;

        public GetNumbers()
        {
            _convertNumbers = new ConvertNumbers();
            _delimiters = new Delimiters();
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
