namespace Homework3;

public class City
{
    private string name;
    private string countryName;
    private string telephoneCode;
    private string[] regionsNames;
    private int population;

    public City(string name, string countryName, string telephoneCode, string[] regionsNames, int population)
    {
        this.name = name;
        this.countryName = countryName;
        this.telephoneCode = telephoneCode;
        this.regionsNames = regionsNames;
        this.population = population;
    }

    public void Input()
    {
        Console.Write("Enter name: ");
        this.name = Console.ReadLine();
        Console.Write("Enter country name: ");
        this.countryName = Console.ReadLine();
        Console.Write("Enter telephone code: ");
        this.telephoneCode = Console.ReadLine();
        Console.Write("Enter regions names: ");
        this.regionsNames = Console.ReadLine().Split(" ").ToArray();
        Console.Write("Enter population: ");
        this.population = Convert.ToInt32(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Country: {countryName}");
        Console.WriteLine($"Telephone code: {telephoneCode}");
        Console.WriteLine($"Regions names: {string.Join(", ", regionsNames)}");
        Console.WriteLine($"Population: {population}");
    }

    public string getName()
    {
        return this.name;
    }

    public string getCountryName()
    {
        return this.countryName;
    }

    public string getTelephoneCode()
    {
        return this.telephoneCode;
    }

    public string[] getRegionsNames()
    {
        return this.regionsNames;
    }

    public int getPopulation()
    {
        return this.population;
    }

    public void setPopulation(int population)
    {
        this.population = population;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setCountryName(string countryName)
    {
        this.countryName = countryName;
    }

    public void setTelephoneCode(string telephoneCode)
    {
        this.telephoneCode = telephoneCode;
    }

    public void setRegionsNames(string[] regionsNames)
    {
        this.regionsNames = regionsNames;
    }
}