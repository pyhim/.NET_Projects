namespace Homework4;

public class Shop
{
    private string _name;
    private string _address;
    private string _description;
    private string _email;

    public Shop(string name, string address, string description, string email)
    {
        Name = name;
        Address = address;
        Description = description;
        Email = email;
    }

    public void Input()
    {
        Console.Write("Enter your name: ");
        Name = Console.ReadLine();
        Console.Write("Enter your address: ");
        Address = Console.ReadLine();
        Console.Write("Enter your description: ");
        Description = Console.ReadLine();
        Console.Write("Enter your email: ");
        Email = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Name: {Name}, Address: {Address}, Description: {Description}, Email: {Email}";
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Address
    {
        get => _address;
        set => _address = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Description
    {
        get => _description;
        set => _description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Email
    {
        get => _email;
        set => _email = value ?? throw new ArgumentNullException(nameof(value));
    }
}