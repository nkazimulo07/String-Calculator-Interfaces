namespace StringCalculatorI.Interfaces
{
    public interface IDelimiters
    {
         List<string> GetDelimiter(string numbers);
         List<string> GetMultipleDelimiters(string delimiter);
    }
}
