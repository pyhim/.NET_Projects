namespace Inheritance.Workers;

public class Manager : Worker
{
    public Manager() : base(65000)
    {
        
    }

    public override void Print()
    {
        Console.WriteLine("I'm manager. My task is to manage my employees and to " +
                          "resolve conflicts");
    }
}