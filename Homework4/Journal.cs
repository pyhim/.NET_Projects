namespace Homework4;

public class Journal
{
    private string _name;
    private string _foundedDate;
    private string _description;
    private string _telephone;
    private string _email;

    public Journal(string name, string foundedDate, string description, string telephone, string email)
    {
        Name = name;
        FoundedDate = foundedDate;
        Description = description;
        Telephone = telephone;
        Email = email;
    }

    public void Input()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();
        Console.Write("Enter founded date: ");
        FoundedDate = Console.ReadLine();
        Console.Write("Enter description: ");
        Description = Console.ReadLine();
        Console.Write("Enter telephone: ");
        Telephone = Console.ReadLine();
        Console.Write("Enter email: ");
        Email = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Name: {Name}\nDate of founding: {FoundedDate}\nDescription: {Description}\nTelephone: {Telephone}" +
               $"\nEmail: {Email}";
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string FoundedDate
    {
        get => _foundedDate;
        set => _foundedDate = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Description
    {
        get => _description;
        set => _description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Telephone
    {
        get => _telephone;
        set => _telephone = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Email
    {
        get => _email;
        set => _email = value ?? throw new ArgumentNullException(nameof(value));
    }
}