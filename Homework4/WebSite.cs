namespace Homework4;

public class WebSite
{
    private string _name;
    private string _URL;
    private string _description;
    private string _IP;

    public WebSite(string name, string url, string description, string ip)
    {
        Name = name;
        URL = url;
        Description = description;
        IP = ip;
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public void Input()
    {
        Console.Write("Enter URL: ");
        URL = Console.ReadLine();
        Console.Write("Enter IP: ");
        IP = Console.ReadLine();
        Console.Write("Enter Description: ");
        Description = Console.ReadLine();
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Name: {Name}\nURL: {URL}\nDescription: {Description}\nIP: {IP}";
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string URL
    {
        get => _URL;
        set => _URL = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Description
    {
        get => _description;
        set => _description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string IP
    {
        get => _IP;
        set => _IP = value ?? throw new ArgumentNullException(nameof(value));
    }
}