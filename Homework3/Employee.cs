namespace Homework3;

public class Employee
{
    private string _firstName;
    private string _middleName;
    private string _lastName;
    private DateTime _dateOfBirth;
    private string _phoneNumber;
    private string _email;
    private string _title;
    private string _description;

    public Employee(
        string firstName, string middleName, string lastName, DateTime birthDate,
        string phoneNumber, string email, string title, string description
    )
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        DateOfBirth = birthDate;
        PhoneNumber = phoneNumber;
        Email = email;
        Title = title;
        Description = description;
    }

    public void Input()
    {
        Console.Write("Enter first name: ");
        FirstName = Console.ReadLine();
        Console.Write("Enter middle name: ");
        MiddleName = Console.ReadLine();
        Console.Write("Enter last name: ");
        LastName = Console.ReadLine();
        Console.Write("Enter birth date of birth: ");
        DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter phone number: ");
        PhoneNumber = Console.ReadLine();
        Console.Write("Enter email: ");
        Email = Console.ReadLine();
        Console.Write("Enter title: ");
        Title = Console.ReadLine();
        Console.Write("Enter description: ");
        Description = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine($"First name: {FirstName}");
        Console.WriteLine($"Middle name: {MiddleName}");
        Console.WriteLine($"Last name: {LastName}");
        Console.WriteLine($"Birth date of birth: {DateOfBirth.Date}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string MiddleName
    {
        get => _middleName;
        set => _middleName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Email
    {
        get => _email;
        set => _email = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Title
    {
        get => _title;
        set => _title = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Description
    {
        get => _description;
        set => _description = value ?? throw new ArgumentNullException(nameof(value));
    }
}