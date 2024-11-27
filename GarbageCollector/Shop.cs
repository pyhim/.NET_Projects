namespace GarbageCollector;

public enum ShopType
{
    Grocery, Hardware, Clothing, Shoe
}

public class Shop : IDisposable
{
    public string Name { get; init; }
    public string Address { get; init; }
    public ShopType Type { get; init; }

    public Shop(string name, ShopType type, string address)
    {
        Name = name;
        Type = type;
        Address = address;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Address: {Address}, Type: {Type}");
    }

    public void Dispose()
    {
        Console.WriteLine("Disposing Shop");
    }

    ~Shop()
    {
        Console.WriteLine("Finalizing Shop");
    }
}