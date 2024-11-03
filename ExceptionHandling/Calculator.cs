namespace ExceptionHandling;

public class Calculator
{
    public Calculator()
    {
        Console.Write("Please enter a number: ");
        var number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter a desirable base conversion: ");
        var toBase = Convert.ToInt32(Console.ReadLine());

        var result = Convert.ToString(number, toBase);
        Console.WriteLine($"{number} in {toBase} base is: {result}");
    }
}