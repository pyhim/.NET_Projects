namespace LINQ_T;

internal class Run
{
    public static void Main(string[] args)
    {
        Company[] companies = [
            new Company("Apple", DateTime.Parse("01/01/1990"), "IT", "California", new FullName("Tim", "Cook"), 5000),
            new Company("Microsoft", DateTime.Parse("04/04/1975"), "IT", "Washington", new FullName("Satya", "Nadella"), 221000),
            new Company("Google", DateTime.Parse("09/04/1998"), "IT", "California", new FullName("Sundar", "Pichai"), 250),
            new Company("Tesla", DateTime.Parse("07/01/2003"), "Automotive", "Texas", new FullName("Elon", "Musk"), 127000),
            new Company("Amazon", DateTime.Parse("07/05/1994"), "Marketing", "Washington", new FullName("Andy", "White"), 50),
            new Company("Meta Food", DateTime.Parse("02/04/2004"), "Social Media", "California", new FullName("Mark", "Zuckerberg"), 66000),
            new Company("Samsung", DateTime.Parse("03/01/1938"), "Electronics", "Seoul", new FullName("Han", "Jong-Hee"), 287000),
            new Company("IBM White", DateTime.Parse("06/16/1911"), "IT", "New York", new FullName("Arvind", "White"), 310000),
            new Company("Sony", DateTime.Parse("05/07/1946"), "Electronics", "Tokyo", new FullName("Kenichiro", "Yoshida"), 108900),
            new Company("BMW", DateTime.Parse("03/07/1916"), "Automotive", "London", new FullName("Oliver", "Zipse"), 133000)
        ];
        
        var generalInfo = 
            from c in companies 
            select $"{c.Name}, {c.DateOfCreation}, {c.BusinessProfile}, {c.Address}, {c.CEOName}, {c.NumberOfEmployees}";

        Console.WriteLine("General info:");
        foreach (string info in generalInfo) Console.WriteLine(info);
        Console.WriteLine();
        
        var foodCompanies =
            from c in companies
            where c.Name.Contains("Food")
            select c;

        Console.WriteLine("Food companies:");
        foreach (var c in foodCompanies) Console.WriteLine(c);
        Console.WriteLine();

        var marketingCompanies =
            from c in companies
            where c.BusinessProfile.Equals("Marketing")
            select c;

        Console.WriteLine("Marketing companies:");
        foreach (var c in marketingCompanies) Console.WriteLine(c);
        Console.WriteLine();
        
        var marketingAndItCompanies =
            from c in companies
            where c.BusinessProfile.Equals("Marketing") || c.BusinessProfile.Equals("IT")
            select c;
        
        Console.WriteLine("Marketing and IT companies:");
        foreach (var c in marketingAndItCompanies) Console.WriteLine(c);
        Console.WriteLine();
        
        var over100EmployeeCompanies =
            from c in companies
            where c.NumberOfEmployees > 100
            select c;
        
        Console.WriteLine("Over 100 employees companies:");
        foreach (var c in over100EmployeeCompanies) Console.WriteLine(c);
        Console.WriteLine();
        
        var hundredTo300Companies =
            from c in companies
            where c.NumberOfEmployees is > 100 and < 300
            select c;
        
        Console.WriteLine("From 100 to 300 employees companies:");
        foreach (var c in hundredTo300Companies) Console.WriteLine(c);
        Console.WriteLine();
        
        var inLondonCompanies = companies.Where(c => c.Address.Equals("London"));
        
        Console.WriteLine("London companies:");
        foreach (var c in inLondonCompanies) Console.WriteLine(c);
        Console.WriteLine();
        
        var whiteSurnameCompanies = companies.Where(c => c.CEOName.LastName.Equals("White"));
        
        Console.WriteLine("CEO surname White companies:");
        foreach (var c in whiteSurnameCompanies) Console.WriteLine(c);
        Console.WriteLine();
        
        var olderThan2YearsCompanies = companies.Where(c => c.DateOfCreation.Year - DateTime.Now.Year > 2);

        Console.WriteLine("Older than 2 years companies:");
        foreach (var c in olderThan2YearsCompanies) Console.WriteLine(c);
        Console.WriteLine();
        
        var blackNWhiteCompanies = 
            companies.Where(c => c.CEOName.LastName.Equals("White"));
        
        Console.WriteLine("Black n-white companies:");
        foreach (var c in blackNWhiteCompanies) Console.WriteLine(c);
    }
}