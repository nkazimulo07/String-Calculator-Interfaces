using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Interfaces
{
    public interface ICheckNumbersGreaterThanOneThousand
    {
        public List<int> GetNumbersLessThanOneThousand(List<int> convectedNumbers);
    }
}
