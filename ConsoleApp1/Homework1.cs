using System.ComponentModel;
using System.Text;

namespace ConsoleApp1;

class Homework1
{
    private static void Task7()
    {
        Console.Write("Enter the range of numbers: ");
        int[] input = (Console.ReadLine() ?? throw new ArgumentNullException())
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        
        if (input[0] > input[1])
        {
            (input[0], input[1]) = (input[1], input[0]);
        }

        int start = input[0];
        int stop = input[1];
        
        for (int i = start; i <= stop; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
    
    private static void Task6()
    {
        Console.Write("Enter to Celsius or to Fahrenheit (C/F): ");
        char choice = char.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        Console.Write("Enter degrees: ");
        double degrees = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

        switch (choice)
        {
            case 'C':
                Console.WriteLine($"Celsius: {(degrees - 32) / 1.8}");
                break;
            case 'F':
                Console.WriteLine($"Fahrenheit: {(degrees * 1.8) + 32}");
                break;
            default:
                Console.Error.WriteLine("Invalid choice.");
                break;
        }
        
    }
    
    private static void Task5()
    {
        Dictionary<int, string> months = [];
        months.Add(1, "Winter");
        months.Add(2, "Winter");
        months.Add(3, "Spring");
        months.Add(4, "Spring");
        months.Add(5, "Spring");
        months.Add(6, "Summer");
        months.Add(7, "Summer");
        months.Add(8, "Summer");
        months.Add(9, "Autumn");
        months.Add(10, "Autumn");
        months.Add(11, "Autumn");
        months.Add(12, "Winter");
        
        Console.Write("Enter the date in format dd.MM.yyyy: ");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        var converter = new DateTimeConverter();
        
        var convertedDate = (DateTime)converter.ConvertFromString(input)!;
        Console.Write(months.GetValueOrDefault(convertedDate.Month) + ' ' + convertedDate.DayOfWeek);
    }
    
    private static void Task4()
    {
        Console.Write("Enter a 6-digit number: ");
        string number = Console.ReadLine() ?? throw new ArgumentNullException();
        if (number.Length != 6) throw new ArgumentException("Invalid number");

        Console.Write("Enter positions to switch (separated by space): ");
        string[] positions = (Console.ReadLine() ?? throw new ArgumentNullException()).Split(' ');
        int[] positionArray = positions.Select(i => int.Parse(i) - 1).ToArray();
        
        var output = new StringBuilder(number);
        (output[positionArray[0]], output[positionArray[1]]) = (output[positionArray[1]], output[positionArray[0]]);
        
        Console.WriteLine(output);
    }
    
    private static void Task3()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        string[] numbers = input.Split(' ');
        
        var output = new StringBuilder();
        foreach (string i in numbers)
        {
            output.Append(i);
        }
        
        Console.WriteLine(output);
    }
    
    private static void Task2()
    {
        Console.Write("Enter a number: ");
        var number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a percentage: ");
        double percentage = Convert.ToDouble(Console.ReadLine()) / 100;
        
        Console.WriteLine($"Result: {number * percentage}");
    }
    
    private static void Task1()
    {
        Console.Write("Enter a number: ");
        var input = Convert.ToInt32(Console.ReadLine());

        if (input is < 0 or > 100)
        {
            Console.Error.WriteLine("Input must be between 1 and 100");
            return;
        }

        if (input % 3 == 0)
        {
            Console.WriteLine("Fizz");
        } 
        else if (input % 5 == 0)
        {
            Console.WriteLine("Buzz");
        } 
        else if (input % 3 == 0 || input % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");    
        }
        else
        {
            Console.WriteLine(input);
        }
    }
    
    public static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        //Task4();
        //Task5();
        //Task6();
        Task7();
    }
}