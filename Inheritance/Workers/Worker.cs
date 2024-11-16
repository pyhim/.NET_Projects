namespace Inheritance.Workers;

public abstract class Worker
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    protected double Salary { get; set; }

    protected Worker(double salary)
    {
        Salary = salary;
    }
    
    public abstract void Print();
}