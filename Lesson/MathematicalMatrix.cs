using System.Linq.Expressions;

namespace Lesson;

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

    public MathematicalMatrix(int rows, int columns)
    {
        _matrix = new int[rows, columns];
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
            throw new ArgumentException("Matrix sizes do not match");
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
                c[row, col] = ;
            }
        }
        
        return c;
    }

    public static MathematicalMatrix operator *(MathematicalMatrix a, int number)
    {
        UniteMatrices(a, number, (x, y) => x * y);
    }
}