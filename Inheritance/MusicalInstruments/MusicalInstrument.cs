namespace Inheritance.MusicalInstruments;

public abstract class MusicalInstrument
{
    protected string Name { get; set; }
    protected string Description { get; set; }

    protected MusicalInstrument(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Sound();

    public abstract void Show();

    public abstract void Desc();

    public abstract void History();
}