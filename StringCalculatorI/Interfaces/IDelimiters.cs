using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Interfaces
{
    public interface IDelimiters
    {
        public List<string> GetDelimiter(string numbers);
        public List<string> GetMultipleDelimiters(string delimiter);
    }
}
