namespace Inheritance.Workers;

public class Engineer : Worker
{
    public Engineer() : base(55000)
    {

    }

    public override void Print()
    {
        Console.WriteLine("I'm an engineer. My task is to develop big systems.");
    }
}