using StringCalculatorI.Interfaces;

namespace StringCalculatorI.Services
{
    public class CheckNumbers : ICheckNumbers
    {
        
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

            return CheckNumbersGreaterThanOneThousand(numbers);
        }

        public void NegativeNumbers(string negativeNumbers)
        {
            throw new Exception("negatives not allowed:  " + negativeNumbers);
        }

        public List<int> CheckNumbersGreaterThanOneThousand(List<int> convectedNumbers)
        {
            var numbersLessThanOneThousand = new List<int>();

            foreach (int number in convectedNumbers)
            {
                if (number < 1000)
                {
                    numbersLessThanOneThousand.Add(number);
                }
            }

            return numbersLessThanOneThousand;
        }
    }
}
