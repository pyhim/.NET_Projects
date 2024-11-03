namespace Inheritance;

public class Microwave : Device
{
    public Microwave() : base("Microwave", "Heats up the food") {}

    public override void Sound()
    {
        Console.WriteLine("*microwave sound*");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Describe()
    {
        Console.WriteLine(Description);
    }
}