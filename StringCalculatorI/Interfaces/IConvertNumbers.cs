using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Interfaces
{
    public interface IConvertNumbers
    {
        public List<int> ConvertStringArrayToIntList(string[] numbers);
    }
}
