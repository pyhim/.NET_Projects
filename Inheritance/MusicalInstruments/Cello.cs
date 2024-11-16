namespace Inheritance.MusicalInstruments;

public class Cello : MusicalInstrument
{
    public int Strings { get; set; }
    
    public Cello() : base("Cello", "A string-family, big instrument")
    {
        
    }

    public override void Sound()
    {
        Console.WriteLine("Cello sound");
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
        Console.WriteLine("The cello came to the limelight for the first time in northern Italy in 1550. It is a" +
                          " member of the violin family and was initially called bass violin. In Italy, it was called" +
                          " viola da braccio. Andrea Amati was the first person who got exposure for making the cello.");
    }
}