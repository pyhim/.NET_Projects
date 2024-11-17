namespace Lesson.ArrayIOutput;

internal class MyArray : IOutput, ICalc, IOutput2, ICalc2
{
    private int[] _array;
    
    public int[] Array => _array;

    public MyArray(int capacity)
    {
        _array = new int[capacity];
    }

    public MyArray(int[] array)
    {
        _array = array;
    }

    public void Show()
    {
        Console.Write('{');
        foreach (int i in Array)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine('}');
    }

    public void Show(string info)
    {
        Show();
        Console.WriteLine($"Info: {info}");
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        
        foreach (int i in Array)
        {
            if (i < valueToCompare) count++;
        }

        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;

        foreach (int i in Array)
        {
            if (i > valueToCompare) count++;
        }
        
        return count;
    }

    public void ShowEven()
    {
        foreach (int i in Array)
        {
            if (i % 2 == 0) Console.Write($"{i}, ");
        }
        
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        foreach (int i in Array)
        {
            if (i % 2 != 0) Console.Write($"{i}, ");
        }
        
        Console.WriteLine();
    }

    public int CountDistinct()
    {
        int counter, uniqueNumbers = 0;

        foreach (int i in Array)
        {
            counter = 0;
            
            foreach (int j in Array)
            {
                if (j == i) counter++;
            }
            
            if (counter == 1) uniqueNumbers++;
        }
        
        return uniqueNumbers;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;

        foreach (int i in Array)
        {
            if (i == valueToCompare) count++;
        }
        
        return count;
    }
}