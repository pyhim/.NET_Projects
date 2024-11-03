namespace Homework3;

public class City
{
    private string _name;
    private string _countryName;
    private string _telephoneCode;
    private string[] _regionsNames;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string CountryName
    {
        get => _countryName;
        set => _countryName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string TelephoneCode
    {
        get => _telephoneCode;
        set => _telephoneCode = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string[] RegionsNames
    {
        get => _regionsNames;
        set => _regionsNames = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Population { get; set; }

    public City(string name, string countryName, string telephoneCode, string[] regionsNames, int population)
    {
        Name = name;
        CountryName = countryName;
        TelephoneCode = telephoneCode;
        RegionsNames = regionsNames;
        Population = population;
    }

    public City(City other)
    {
        Name = other.Name;
        CountryName = other.CountryName;
        TelephoneCode = other.TelephoneCode;
        RegionsNames = other.RegionsNames;
        Population = other.Population;
    }

    public void Input()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();
        Console.Write("Enter country name: ");
        CountryName = Console.ReadLine();
        Console.Write("Enter telephone code: ");
        TelephoneCode = Console.ReadLine();
        Console.Write("Enter regions names: ");
        RegionsNames = Console.ReadLine().Split(" ").ToArray();
        Console.Write("Enter population: ");
        Population = Convert.ToInt32(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Country: {CountryName}");
        Console.WriteLine($"Telephone code: {TelephoneCode}");
        Console.WriteLine($"Regions names: {string.Join(", ", RegionsNames)}");
        Console.WriteLine($"Population: {Population}");
    }

    public static City operator -(City city, int population)
    {
        var result = new City(city);
        result.Population -= population;

        return result;
    }

    public static bool operator ==(City city1, City city2)
    {
        return city1.Population == city2.Population;
    }

    public static bool operator !=(City city1, City city2)
    {
        return city1.Population != city2.Population;
    }

    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }
}