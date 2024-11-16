namespace OperatorOverloading1;

class Run
{
    public static void Main(string[] args)
    {
        var books1 = new Library([
            new Book("Book1", "Steven Hawking", 65, DateTime.Parse("10/10/2010")),
            new Book("Book2", "Someone someone", 255, DateTime.Parse("10/01/1999")),
            new Book("Book3", "Another one", 134, DateTime.Parse("05/20/2017")),
        ]);
        var books2 = new Library([
            new Book("Book89", "Steven King", 665, DateTime.Parse("04/02/2000")),
            new Book("Book12", "Someone one", 25, DateTime.Parse("01/19/1989")),
            new Book("Book44", "Another someone", 234, DateTime.Parse("05/20/2017")),
        ]);

        var books2Enumerator = books2.GetEnumerator();
        foreach (Book book in books1)
        {
            books2Enumerator.MoveNext();
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Compare(books2Enumerator.Current, "author"));
        }
    }
}