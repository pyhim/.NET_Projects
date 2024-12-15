namespace LINQ_T;

internal class Run
{
    public static void Main(string[] args)
    {
        Company[] companies =
        [
            new Company("Apple", DateTime.Parse("01/01/1990"), "IT", "California", new FullName("Tim", "Cook"), 5000),
            new Company("Microsoft", DateTime.Parse("04/04/1975"), "IT", "Washington", new FullName("Satya", "Nadella"),
                221000),
            new Company("Google", DateTime.Parse("09/04/1998"), "IT", "California", new FullName("Sundar", "Pichai"),
                250),
            new Company("Tesla", DateTime.Parse("07/01/2003"), "Automotive", "Texas", new FullName("Elon", "Musk"),
                127000),
            new Company("Amazon", DateTime.Parse("07/05/1994"), "Marketing", "Washington",
                new FullName("Andy", "White"), 50),
            new Company("Meta Food", DateTime.Parse("02/04/2004"), "Social Media", "California",
                new FullName("Mark", "Zuckerberg"), 66000),
            new Company("Samsung", DateTime.Parse("03/01/1938"), "Electronics", "Seoul",
                new FullName("Han", "Jong-Hee"), 287000),
            new Company("IBM White", DateTime.Parse("06/16/1911"), "IT", "New York", new FullName("Arvind", "White"),
                310000),
            new Company("Sony", DateTime.Parse("05/07/1946"), "Electronics", "Tokyo",
                new FullName("Kenichiro", "Yoshida"), 108900),
            new Company("BMW", DateTime.Parse("03/07/1916"), "Automotive", "London", new FullName("Oliver", "Zipse"),
                133000)
        ];

        companies[0].Employees =
        [
            new Employee("John", "Doe", "Software Engineer", "123-456-7890", "john.doe@apple.com", 120000),
            new Employee("Jane", "Smith", "UX Designer", "234-567-8901", "jane.smith@apple.com", 95000)
        ];

        companies[1].Employees =
        [
            new Employee("Emily", "Johnson", "Cloud Engineer", "345-678-9012", "emily.johnson@microsoft.com", 130000),
            new Employee("Michael", "Brown", "Product Manager", "456-789-0123", "michael.brown@microsoft.com", 150000)
        ];

        companies[2].Employees =
        [
            new Employee("Chris", "Davis", "AI Specialist", "567-890-1234", "chris.davis@google.com", 140000),
            new Employee("Sara", "Wilson", "Data Analyst", "678-901-2345", "sara.wilson@google.com", 115000),
            new Employee("Ethan", "Moore", "DevOps Engineer", "789-012-3456", "ethan.moore@google.com", 125000)
        ];

        companies[3].Employees =
        [
            new Employee("Olivia", "Taylor", "Battery Specialist", "890-123-4567", "olivia.taylor@tesla.com", 110000),
            new Employee("Liam", "Anderson", "Mechanical Engineer", "901-234-5678", "liam.anderson@tesla.com", 105000)
        ];

        companies[4].Employees =
        [
            new Employee("Sophia", "Martin", "Logistics Manager", "123-345-5678", "sophia.martin@amazon.com", 125000),
            new Employee("Mason", "Lee", "Warehouse Supervisor", "234-456-6789", "mason.lee@amazon.com", 80000)
        ];

        companies[5].Employees =
        [
            new Employee("Isabella", "Perez", "Social Media Manager", "345-567-7890", "isabella.perez@meta.com", 90000),
            new Employee("Jacob", "White", "Software Engineer", "456-678-8901", "jacob.white@meta.com", 115000),
            new Employee("Mia", "Harris", "HR Specialist", "567-789-9012", "dia.harris@meta.com", 75000)
        ];

        companies[6].Employees =
        [
            new Employee("Ella", "Young", "Electronics Engineer", "678-890-1234", "ella.young@samsung.com", 120000),
            new Employee("William", "King", "Product Tester", "789-901-2345", "william.king@samsung.com", 80000),
            new Employee("Ava", "Garcia", "Marketing Manager", "890-012-3456", "ava.garcia@samsung.com", 95000)
        ];

        companies[7].Employees =
        [
            new Employee("Lionel", "Martinez", "Data Scientist", "901-123-4567", "lionel.martinez@ibm.com", 135000),
            new Employee("Amelia", "Clark", "Technical Writer", "012-234-5678", "amelia.clark@ibm.com", 70000)
        ];

        companies[8].Employees =
        [
            new Employee("Alexander", "Rodriguez", "Firmware Engineer", "123-456-7890", "alexander.rodriguez@sony.com",
                125000),
            new Employee("Charlotte", "Lewis", "Graphic Designer", "234-567-8901", "charlotte.lewis@sony.com", 85000)
        ];

        companies[9].Employees =
        [
            new Employee("Diniel", "Walker", "Engine Designer", "345-678-9012", "daniel.walker@bmw.com", 115000),
            new Employee("Emily", "Hall", "Supply Chain Analyst", "456-789-0123", "emily.hall@bmw.com", 95000)
        ];


        var generalInfo =
            from c in companies
            select
                $"{c.Name}, {c.DateOfCreation}, {c.BusinessProfile}, {c.Address}, {c.CEOName}, {c.NumberOfEmployees}";

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
        
        var employeesSpecificCompany = 
            from c in companies
            where c.Name.Equals("Apple")
            select c.Employees;
        
        Console.WriteLine("All employees from Apple:");
        foreach (var e in employeesSpecificCompany) Console.WriteLine(e);
        Console.WriteLine();
        
        var employeesSalaryThreshold =
            from c in companies
            from e in c.Employees
            where e.Salary > 120000 
            select e;
        
        Console.WriteLine("Employees with salary more than 120000:");
        foreach (var e in employeesSalaryThreshold) Console.WriteLine(e);
        Console.WriteLine();

        var employeesManagers =
            from c in companies
            from e in c.Employees
            where e.Job.Contains("Manager")
            select e;
        
        Console.WriteLine("Employees managers:");
        foreach (var e in employeesManagers) Console.WriteLine(e);
        Console.WriteLine();
        
        var employees23PhoneNumber = 
            from c in companies
            from e in c.Employees
            where e.PhoneNumber.StartsWith("23")
            select e;
        
        Console.WriteLine("Employees with phone number start with 23:");
        foreach (var e in employees23PhoneNumber) Console.WriteLine(e);
        Console.WriteLine();
        
        var employeesNamesDi = 
            from c in companies
            from e in c.Employees
            where e.Name.FirstName.StartsWith("Di")
            select e;
        
        Console.WriteLine("Employees names starts with di:");
        foreach (var e in employeesNamesDi) Console.WriteLine(e);
        Console.WriteLine();

        var employeesNameLionel =
            from c in companies
            from e in c.Employees
            where e.Name.FirstName.Equals("Lionel")
            select e;
        
        Console.WriteLine("Employees names lionel:");
        foreach (var e in employeesNameLionel) Console.WriteLine(e);
        Console.WriteLine();
    }
}