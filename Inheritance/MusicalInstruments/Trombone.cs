namespace Inheritance.MusicalInstruments;

public class Trombone : MusicalInstrument
{
    public double Weight { get; set; }
    
    public Trombone() : base("Trombone", "Brass family instrument")
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
        Console.WriteLine("While the invention of the early trombone, or sackbut, cannot be traced to one individual" +
                          " or with certainty to a specific location, it is thought to have been invented in Belgium" +
                          " around 1450. The sackbut was created to emulate the sound of a trumpet while " +
                          "playing lower notes.");
    }
}