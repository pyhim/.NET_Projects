namespace OperatorOverloading1;

class Run
{
    public static void Main(string[] args)
    {
        // var matrix1 = new MathematicalMatrix(4, 4);
        // var matrix2 = new MathematicalMatrix(4, 4);
        // matrix1.Print();
        // matrix2.Print();
        //
        // var matrix3 = matrix1 + matrix2;
        // matrix3.Print();
        // matrix3 = matrix1 - matrix2;
        // matrix3.Print();
        // matrix3 = matrix1 * matrix2;
        // matrix3.Print();
        // matrix3 = matrix1 * 2;
        // matrix3.Print();

        var books = new BookList();
        books.Print();
        books.Remove(3);
        books.Print();
    }
}