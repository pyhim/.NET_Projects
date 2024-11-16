namespace Inheritance.Devices;

public class Car : Device
{
    public Car() : base("Car", "Terrestrial vehicle") {}

    public override void Sound()
    {
        Console.WriteLine("*motor sounds*");
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