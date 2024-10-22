namespace Homework3;

public class Plane
{
    private string _name;
    private string _manufacturer;
    private string _type;

    public Plane(string name, string manufacturer, DateTime releaseDate, string type)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
        Type = type;
    }
    
    public Plane(string name, string manufacturer, string releaseDate, string type)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = DateTime.Parse(releaseDate);
        Type = type;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Manufacturer
    {
        get => _manufacturer;
        set => _manufacturer = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime ReleaseDate { get; set; }

    public string Type
    {
        get => _type;
        set => _type = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Release Date: {ReleaseDate}");
    }

    public void Input()
    {
        Console.Write("Enter plane name: ");
        Name = Console.ReadLine();
        Console.Write("Enter plane manufacturer: ");
        Manufacturer = Console.ReadLine();
        Console.Write("Enter plane type: ");
        Type = Console.ReadLine();
        Console.Write("Enter plane release date: ");
        ReleaseDate = DateTime.Parse(Console.ReadLine());
    }
}