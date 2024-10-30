namespace OperatorOverloading1;

public class MathematicalMatrix
{
    private int[,] _matrix;

    public int Rows => _matrix.GetLength(0);
    public int Columns => _matrix.GetLength(1);
    public int this[int row, int column]
    {
        get => _matrix[row, column];
        set => _matrix[row, column] = value;
    }

    public MathematicalMatrix(int rows, int columns, bool randInit = false)
    {
        _matrix = new int[rows, columns];

        if (randInit) return;

        var rand = new Random();
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                _matrix[row, col] = rand.Next(1, 20);
            }
        }
    }

    public MathematicalMatrix(int[,] matrix)
    {
        _matrix = matrix;
    }

    public void Print()
    {
        Console.WriteLine("{");
        
        for (int row = 0; row < _matrix.GetLength(0); row++)
        {
            for (int col = 0; col < _matrix.GetLength(1); col++)
            {
                Console.Write(_matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("}");
    }

    public void Input()
    {
        for (int row = 0; row < _matrix.GetLength(0); row++)
        {
            for (int col = 0; col < _matrix.GetLength(1); col++)
            {
                Console.Write($"Enter a number to [{row}, {col}]: ");
                _matrix[row, col] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    private int CompareElements(Func<int, int, bool> comparator)
    {
        int result = _matrix[0, 0];

        for (int row = 0; row < _matrix.GetLength(0); row++)
        {
            for (int col = 0; col < _matrix.GetLength(1); col++)
            {
                if (comparator(result, _matrix[row, col]))
                {
                    result = _matrix[row, col];
                }
            }
        }
        
        return result;
    }

    public int Max()
    {
        return CompareElements((x, y) => x < y);
    }
    
    public int Min()
    {
        return CompareElements((x, y) => x > y);
    }

    internal static bool CheckForEqualSize(MathematicalMatrix matrix, MathematicalMatrix otherMatrix)
    {
        if (otherMatrix.Rows != matrix.Rows || otherMatrix.Columns != matrix.Columns)
        {
            throw new InvalidOperationException("Matrix sizes do not match");
        }
        
        return true;
    }

    internal static MathematicalMatrix UniteMatrices(
        MathematicalMatrix a,
        MathematicalMatrix b,
        Func<int, int, int> unifier)
    {
        CheckForEqualSize(a, b);
        
        var c = new MathematicalMatrix(a.Rows, a.Columns);
        
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < a.Columns; col++)
            {
                c[row, col] = unifier(a[row, col], b[row, col]);
            }
        }
        
        return c;
    }

    public static MathematicalMatrix operator +(MathematicalMatrix a, MathematicalMatrix b)
    {
        return UniteMatrices(a, b, (x, y) => x + y);
    }

    public static MathematicalMatrix operator -(MathematicalMatrix a, MathematicalMatrix b)
    {
        return UniteMatrices(a, b, (x, y) => x - y);
    }

    // TODO: Finish operator*
    public static MathematicalMatrix operator *(MathematicalMatrix a, MathematicalMatrix b)
    {
        CheckForEqualSize(a, b);
        
        var c = new MathematicalMatrix(a.Rows, a.Columns);
        
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < a.Columns; col++)
            {
                c[row, col] = 0;

                for (int k = 0; k < a.Columns; k++)
                {
                    c[row, col] += a[row, k] * b[k, col];
                }
            }
        }
        
        return c;
    }

    public static MathematicalMatrix operator *(MathematicalMatrix a, int number)
    {
        var c = new MathematicalMatrix(a.Rows, a.Columns);
        
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < a.Columns; col++)
            {
                c[row, col] = a[row, col] * number;
            }
        }
        
        return c;
    }

    public static bool operator ==(MathematicalMatrix a, MathematicalMatrix b)
    {
        try
        {
            CheckForEqualSize(a, b);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Matrices do not match by their size");
            return false;
        }

        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < a.Columns; col++)
            {
                if (a[row, col] != b[row, col])
                {
                    return false;
                }
            }
        }
        
        return true;
    }

    public static bool operator !=(MathematicalMatrix a, MathematicalMatrix b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        return ToString() == obj?.ToString();
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
}