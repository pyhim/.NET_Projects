namespace OperatorOverloading1;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public DateTime PublishDate { get; set; }

    public Book(string title, string author, int pages, DateTime publishDate)
    {
        Title = title;
        Author = author;
        Pages = pages;
        PublishDate = publishDate;
    }

    public Book()
    {
        Title = "Some title";
        Author = "Some author";
        Pages = 0;
        PublishDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Pages: {Pages}, Publish date: {PublishDate}";
    }
}