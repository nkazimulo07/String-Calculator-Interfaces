namespace StringCalculatorI.Interfaces
{
    public interface IGetNumbers
    {
        public List<int> GetListOfNumber(string numbers);
        public List<int> ConvertStringArrayToIntList(string[] numbers);
    }
}
