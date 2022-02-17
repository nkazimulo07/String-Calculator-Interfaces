using StringCalculatorI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Models
{
    public class ConvertNumbers : IConvertNumbers
    {
        private CheckNumbers _checkNumbers;

        public ConvertNumbers()
        {
            _checkNumbers = new CheckNumbers();
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
