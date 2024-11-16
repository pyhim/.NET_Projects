namespace Inheritance.Devices;

public class Ship : Device
{
    public Ship() : base("Ship", "Sails through the sea") {}

    public override void Sound()
    {
        Console.WriteLine("*ship horn*");
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