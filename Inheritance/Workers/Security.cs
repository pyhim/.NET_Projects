namespace Inheritance.Workers;

public class Security : Worker
{
    public Security() : base(4500)
    {
        
    }

    public override void Print()
    {
        Console.WriteLine("I'm security. My task is to protect property and people.");
    }
}