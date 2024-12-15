namespace LINQ_T;

public class FullName
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public class Company
{
    public string Name { get; init; }
    public DateTime DateOfCreation { get; init; }
    public string BusinessProfile { get; init; }
    public string Address { get; init; }
    public FullName CEOName { get; init; }
    public int NumberOfEmployees { get; init; }
    public Employee[] Employees { get; set; }

    public Company(string name, DateTime dateOfCreation, string businessProfile, string address, FullName ceoName,
        int numberOfEmployees)
    {
        Name = name;
        DateOfCreation = dateOfCreation;
        BusinessProfile = businessProfile;
        Address = address;
        CEOName = ceoName;
        NumberOfEmployees = numberOfEmployees;
    }

    public override string ToString()
    {
        return $"{Name} {DateOfCreation} {BusinessProfile} {Address} {CEOName} {NumberOfEmployees}";
    }
}