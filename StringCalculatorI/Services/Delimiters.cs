using StringCalculatorI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorI.Models
{
    public class Delimiters:IDelimiters

    {
        public List<string> GetDelimiter(string numbers)
        {
            var delimiters = new List<string> { ",", "\n" };

            if (numbers.StartsWith("//"))
            {
                var myDelimiter = numbers.Substring(2, numbers.IndexOf('\n') - 2);

                if (myDelimiter.Contains("[") && myDelimiter.Contains("]"))
                {
                    delimiters.AddRange(GetMultipleDelimiters(myDelimiter));
                }
                else
                {
                    delimiters.Add(myDelimiter);
                }
            }

            return delimiters;
        }

        public List<string> GetMultipleDelimiters(string delimiter)
        {
            char[] charsToTrim = { '[', ']' };
            string cleanDelimiter = delimiter.Trim(charsToTrim);
            string[] delimiters = cleanDelimiter.Split(new string[] { "][" }, StringSplitOptions.RemoveEmptyEntries);

            return delimiters.ToList();
        }
    }
}
