namespace ExceptionHandling;

public class Calculator
{
    public Calculator()
    {
        Console.Write("Please enter a number: ");
        var input = Convert.ToInt64(Console.ReadLine());
        
        if (input > int.MaxValue)
        {
            throw new ArgumentException("The input is too large to fit the calculator");
        }
        var number = (int)input;
        
        Console.Write("Please enter a desirable base conversion: ");
        var toBase = Convert.ToInt32(Console.ReadLine());
        
        var result = Convert.ToString(number, toBase);
        Console.WriteLine($"{number} in {toBase} base is: {result}");
    }
}