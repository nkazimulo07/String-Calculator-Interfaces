namespace StringCalculatorI.Interfaces
{
    public interface ICheckNumbers
    {
        public List<int> CheckNegatives(List<int> numbers);
        public void NegativeNumbers(string negativeNumbers);
        public List<int> CheckNumbersGreaterThanOneThousand(List<int> convectedNumbers);
        
    }
}
