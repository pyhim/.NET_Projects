namespace Lesson.Delegates;

public class ArithmeticApp
{
    delegate bool CheckNumber(int number);
    
    public ArithmeticApp()
    {
        CheckNumber[] checkNumber = [IsEven, IsOdd, IsPrime, IsFibonacci];
        string[] names = ["is even", "is odd", "is prime", "is fibonacci"];
        
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        // Зіп метод був використан на уроці з вашого дозволу
        foreach ((CheckNumber checker, string name) in checkNumber.Zip(names, (x, y) => (x, y)))
        {
            if (checker(number))
            {
                Console.WriteLine($"The number {name}");
            }
        }
    }

    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    private static bool IsPrime(int number)
    {
        switch (number)
        {
            case <= 1:
                return false;
            case 2:
                return true;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        
        return true;
    }

    private static bool IsPerfectSquare(int number)
    {
        int sqrt = (int)Math.Sqrt(number);
        return sqrt * sqrt == number;
    }

    private static bool IsFibonacci(int number)
    {
        return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
    }
}