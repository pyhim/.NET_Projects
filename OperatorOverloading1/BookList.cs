namespace OperatorOverloading1;

public class BookList
{
    private Book?[] _books;
    
    public Book? this[int index] => _books[index];
    public int Length => 10;

    public BookList(Book?[] books)
    {
        _books = books;
    }

    public BookList()
    {
        _books = new Book[10];

        for (int i = 0; i < 10; i++)
        {
            _books[i] = new Book();
        }
    }

    public Book?[] ToArray()
    {
        return _books;
    }

    public void Add(Book book, int index) => _books[index] = book;
    
    public void Remove(int index) => _books[index] = null;

    public void Remove(Book book)
    {
        int index = IndexOf(book);
        if (index == -1) return;
        
        _books[index] = null;
    }
    
    public bool Check(Book book)
    {
        foreach (var b in _books)
        {
            if (book == b)
            {
                return true;
            }
        }

        return false;
    }

    public int IndexOf(Book book)
    {
        int i = 0;
        foreach (var b in _books)
        {
            if (b == book)
            {
                return i;
            }

            i++;
        }
        
        return -1;
    }

    public void Print()
    {
        foreach (var book in _books)
        {
            Console.WriteLine(book);
        }
    }

    public static BookList operator -(BookList books, Book book)
    {
        var newBookList = new BookList(books.ToArray());
        newBookList.Remove(book);
        
        return newBookList;
    }
    
    public static BookList operator +(BookList books, int index)
    {
        var newBookList = new BookList(books.ToArray());
        newBookList.Remove(index);
        
        return newBookList;
    }
}