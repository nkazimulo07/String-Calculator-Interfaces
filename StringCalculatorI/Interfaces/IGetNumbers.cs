namespace StringCalculatorI.Interfaces
{
    public interface IGetNumbers
    {
         List<int> GetListOfNumber(string numbers);
         List<int> ConvertStringArrayToIntList(string[] numbers);
    }
}
