using System.Text;

namespace ConsoleApp1;

public class Homework2
{
    private static void Task4()
    {
        const string forbiddenWord = "die";
        const int forbiddenWordLength = 3;
        
        Console.WriteLine("Enter some text: ");

        var text = new StringBuilder((Console.ReadLine() ?? throw new ArgumentNullException()));
        var word = new StringBuilder();
        int statistics = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                word.Append(text[i]);
                continue;
            }
            if ((text[i] is ',' or '.' or ' ') && word.ToString() == forbiddenWord)
            {
                CensorWord(text, i - forbiddenWordLength);
                statistics++;
            }
            word.Clear();
        }
        
        Console.WriteLine(text.ToString(), $"Statistics: {statistics}");
        return;

        void CensorWord(StringBuilder textToChange, int wordIndex)
        {
            for (int i = wordIndex, count = 0; count < forbiddenWordLength; i++, count++)
            {
                textToChange[i] = '*';
            }
        }
    }
    
    private static void Task3()
    {
        Console.Write("Enter an equation (only + and - is supported): ");
        string equation = Console.ReadLine() ?? throw new ArgumentNullException();
        
        var splitEquation = new List<string>(15);
        var operandBuilder = new StringBuilder();
        foreach (char symbol in equation)
        {
            if (char.IsDigit(symbol) || symbol == '.')
            {
                operandBuilder.Append(symbol);
            }
            else if (symbol is '+' or '-')
            {
                splitEquation.Add(operandBuilder.ToString());
                splitEquation.Add(symbol.ToString());
                operandBuilder.Clear();
            }
        }
        splitEquation.Add(operandBuilder.ToString());
        operandBuilder.Clear();

        if (splitEquation.Count == 0)
        {
            throw new ArgumentException("Equation is empty or invalid");
        }

        var add = (double a, double b) => a + b;
        var operation = (double a, double b) => a - b; // subtraction
        var operationSymbol = "-";

        while (true)
        {
            int performedOperations = 0;
            for (int i = 0; i < splitEquation.Count; i++)
            {
                if (splitEquation[i] != operationSymbol) continue;
                
                double result = operation(double.Parse(splitEquation[i - 1]), double.Parse(splitEquation[i + 1]));
                splitEquation[i] = result.ToString();
                splitEquation.RemoveAt(i + 1);
                splitEquation.RemoveAt(i - 1);
                performedOperations++;
            }

            if (splitEquation.Count == 1) break;
            if (performedOperations == 0)
            {
                operation = add;
                operationSymbol = "+";
            }
        }
        
        Console.WriteLine($"Result: {splitEquation.First()}");
    }
    
    private static void Task2()
    {
        int[] minIndex = [0, 0], maxIndex = [0, 0];
        var matrix = new int[5, 5];

        var random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = random.Next(-100, 100);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] < matrix[minIndex[0], minIndex[1]])
                {
                    minIndex[0] = i;
                    minIndex[1] = j;
                }

                if (matrix[i, j] > matrix[maxIndex[0], maxIndex[1]])
                {
                    maxIndex[0] = i;
                    maxIndex[1] = j;
                }
            }
        }

        int sum = 0;
        for (int i = minIndex[0]; i <= maxIndex[0]; i++)
        {
            for (int j = minIndex[1]; i <= maxIndex[1] && i < 5; i++)
            {
                sum += matrix[i, j];
            }
        }
        
        Console.WriteLine(sum);
    }

    private static void Task1()
    {
        Console.Write("Enter 5 numbers dividing by spaces: ");
        double[] a = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        var b = new double[3,4];
        var random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                b[i, j] = random.Next(-100, 100);
            }
        }

        foreach (double i in a)
        {
            Console.Write(i + " ");
        }
        Console.Write("\n\n");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
        }

        double min = a[0], max = a[0], sum = 0, product = 1, evenSumA = 0, oddSumB = 0;
        foreach (double i in a)
        {
            if (i < min) min = i;
            if (i > max) max = i;
            if (i % 2 == 0) evenSumA += i;
            sum += i;
            product *= i;
        }

        foreach (double i in b)
        {
            if (i < min) min = i;
            if (i > max) max = i;
            if (i % 2 != 0) oddSumB += i;
            sum += i;
            product *= i;
        }
        
        Console.WriteLine(
            $"Min: {min}\nMax: {max}\nSum: {sum}\nProduct: {product}\n" +
            $"EvenSumA: {evenSumA}\nOddSumB: {oddSumB}"
        );
    }
    
    public static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        Task4();
    }
}