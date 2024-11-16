namespace Inheritance.MusicalInstruments;

public class Violin : MusicalInstrument
{
    public int Strings { get; set; }
    
    public Violin() : base("Violin", "A string-family, small instrument")
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
        Console.WriteLine("The violin was first known in 16th-century Italy, with some further modifications occurring" +
                          " in the 18th and 19th centuries to give the instrument a more powerful sound and projection." +
                          " In Europe, it served as the basis for the development of other stringed instruments used in" +
                          " Western classical music, such as the viola.");
    }
}