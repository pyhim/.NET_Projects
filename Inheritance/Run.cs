using Inheritance.Devices;

namespace Inheritance;

class Run
{
    public static void Main(string[] args)
    {
        Device[] devices = [ new Car(), new Kettle(), new Microwave(), new Ship() ];

        foreach (var d in devices)
        {
            d.Sound();
            d.Describe();
            d.Show();
            Console.WriteLine();
        }
    }
}