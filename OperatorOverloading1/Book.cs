using System.Collections;

namespace OperatorOverloading1;

public class Book : IComparable, IComparer, ICloneable
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

    public int CompareTo(object? obj)
    {
        if (obj is not Book other) throw new ArgumentException("Object is not a Book");
        
        return Title.CompareTo(other.Title);
    }

    public int Compare(object? x, object? y)
    {
        if (x is not Book other) throw new ArgumentException("Object is not a Book");
        if (y is not string criteria) throw new ArgumentException("Criteria is not a string");

        if (y.Equals("title"))
        {
            return Title.CompareTo(other.Title);
        } 
        if (y.Equals("author"))
        {
            return Author.CompareTo(other.Author);
        }
        if (y.Equals("pages"))
        {
            return Pages.CompareTo(other.Pages);
        }
        if (y.Equals("date"))
        {
            return PublishDate.CompareTo(other.PublishDate);
        }

        throw new InvalidOperationException("Unknown criteria");
    }

    public object Clone()
    {
        return new Book(Title, Author, Pages, PublishDate);
    }
}