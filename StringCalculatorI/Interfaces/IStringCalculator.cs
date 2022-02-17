using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Interfaces
{
    public interface IStringCalculator
    {
        public int Add(string number);
        public int SumOfNumbers(List<int> numbers);
    }
}
