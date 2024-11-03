namespace ExceptionHandling;

public class ForeignPassport
{
    private string _number;
    private string _firstName;
    private string _lastName;
    private string _country;

    public string Number
    {
        get => _number;
        set
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c)) throw new ArgumentException("Invalid input");
            }
            _number = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public string FirstName
    {
        get => _firstName;
        set 
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c)) throw new ArgumentException("Invalid input");
            }
            _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c)) throw new ArgumentException("Invalid input");
            }
            _lastName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public string Country
    {
        get => _country;
        set
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c)) throw new ArgumentException("Invalid input");
            }
            _country = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public DateTime DateOfIssue { get; set; }

    public ForeignPassport(string number, string firstName, string lastName, string country, DateTime dateOfIssue)
    {
        Number = number;
        FirstName = firstName;
        LastName = lastName;
        Country = country;
        DateOfIssue = dateOfIssue;
    }
}