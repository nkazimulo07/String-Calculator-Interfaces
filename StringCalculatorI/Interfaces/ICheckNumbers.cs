namespace StringCalculatorI.Interfaces
{
    public interface ICheckNumbers
    {
         List<int> CheckNegatives(List<int> numbers);
         void NegativeNumbers(string negativeNumbers);
         List<int> CheckNumbersGreaterThanOneThousand(List<int> convectedNumbers);
        
    }
}
