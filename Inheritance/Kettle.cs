namespace Inheritance;

public class Kettle : Device
{
    public Kettle() : base("Kettle", "Boils water") {}

    public override void Sound()
    {
        Console.WriteLine("*kettle whistle*");
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