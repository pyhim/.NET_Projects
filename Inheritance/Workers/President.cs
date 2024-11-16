namespace Inheritance.Workers;

public class President : Worker
{
    public President() : base(100000)
    {
        
    }

    public override void Print()
    {
        Console.WriteLine("I'm a president. My task is to govern over my country.");
    }
}