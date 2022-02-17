using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Interfaces
{
    public interface ICheckNumbers
    {
        public List<int> CheckNegatives(List<int> numbers);
        public void NegativeNumbers(string negativeNumbers);
    }
}
