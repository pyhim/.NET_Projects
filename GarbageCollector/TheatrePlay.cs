namespace GarbageCollector;

public class FullName
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class TheatrePlay : IDisposable
{
    public FullName Author { get; init; }
    public string Name { get; init; }
    public string Genre { get; init; }
    public DateTime CreationDate { get; init; }

    public TheatrePlay(string authorFirstName, string authorLastName, string name, string genre, DateTime creationDate)
    {
        Author = new FullName(authorFirstName, authorLastName);
        Name = name;
        Genre = genre;
        CreationDate = creationDate;
    }

    public void Print()
    {
        Console.WriteLine($"Name of play: {Name}\nGenre: {Genre}\nCreation date: {CreationDate}\nAuthor: {Author}");
    }

    public void Dispose()
    {
        Console.WriteLine("TheatrePlay is disposing...");
    }

    ~TheatrePlay()
    {
        Console.WriteLine("TheatrePlay is finalizing...");
    }
}