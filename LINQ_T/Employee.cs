namespace LINQ_T;

public class Employee
{
    public FullName Name { get; init; }
    public string Job { get; init; }
    public string PhoneNumber { get; init; }
    public string Email { get; init; }
    public double Salary { get; init; }

    public Employee(string firstName, string lastName, string job, string phoneNumber, string email, double salary)
    {
        Name = new FullName(firstName, lastName);
        Job = job;
        PhoneNumber = phoneNumber;
        Email = email;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Name: {Name} Job: {Job} Phone: {PhoneNumber} Email: {Email} Salary: {Salary}";
    }
}