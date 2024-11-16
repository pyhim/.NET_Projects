namespace Inheritance.MusicalInstruments;

public class Ukulele : MusicalInstrument
{
    public int Strings { get; set; }
    
    public Ukulele() : base("Ukulele", "A string-family, very small instrument")
    {
        
    }

    public override void Sound()
    {
        Console.WriteLine("Violin sound");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }

    public override void History()
    {
        Console.WriteLine("Developed in the 1880s, the ukulele is based on several small, guitar-like instruments of" +
                          " Portuguese origin, the machete, cavaquinho, timple, and rajão, introduced to the Hawaiian" +
                          " Islands by Portuguese immigrants from Madeira, the Azores, and Cape Verde.");
    }
}