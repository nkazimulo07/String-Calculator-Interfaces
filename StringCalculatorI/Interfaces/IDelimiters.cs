namespace StringCalculatorI.Interfaces
{
    public interface IDelimiters
    {
        public List<string> GetDelimiter(string numbers);
        public List<string> GetMultipleDelimiters(string delimiter);
    }
}
