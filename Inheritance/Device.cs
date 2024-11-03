namespace Inheritance;

public abstract class Device
{
    protected string Name { get; set; }

    protected string Description { get; set; }

    protected Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Sound();
    
    public abstract void Show();
    
    public abstract void Describe();
}