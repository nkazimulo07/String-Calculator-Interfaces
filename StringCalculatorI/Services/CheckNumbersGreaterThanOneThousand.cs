using StringCalculatorI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Models
{
    public class CheckNumbersGreaterThanOneThousand : ICheckNumbersGreaterThanOneThousand
    {
        public List<int> GetNumbersLessThanOneThousand(List<int> convectedNumbers)
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
