namespace ExceptionHandling;

public class Run
{
    public static void Main(string[] args)
    {
        // var calc = new Calculator();

        var foreignPassport1 = new ForeignPassport("31242143", "John", "Smith", "USA", DateTime.Parse("10/14/2006"));
        var foreignPassport2 = new ForeignPassport("31242143", "Joh+-n", "Smit3h", "USA", DateTime.Parse("10/14/2006"));
    }
}