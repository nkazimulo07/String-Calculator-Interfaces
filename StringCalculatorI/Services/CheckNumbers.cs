using StringCalculatorI.Interfaces;

namespace StringCalculatorI.Models
{
    public class CheckNumbers : ICheckNumbers
    {
        private CheckNumbersGreaterThanOneThousand _checkNumbersGreaterThanOneThousand;

        public CheckNumbers()
        {
            _checkNumbersGreaterThanOneThousand = new CheckNumbersGreaterThanOneThousand();
        }

        public List<int> CheckNegatives(List<int> numbers)
        {
            var negativeNumbers = "";

            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbers += number + " ";
                }
            }

            if (negativeNumbers != "")
            {
                NegativeNumbers(negativeNumbers);
            }

            return _checkNumbersGreaterThanOneThousand.GetNumbersLessThanOneThousand(numbers);
        }

        public void NegativeNumbers(string negativeNumbers)
        {
            throw new Exception("negatives not allowed:  " + negativeNumbers);
        }
    }
}
