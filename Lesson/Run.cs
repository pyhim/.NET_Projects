using Lesson.ArrayIOutput;

namespace Lesson;

internal class Run
{
    public static void Main(string[] args)
    {
        var f1 = new Fraction(6, 5);
        var f2 = new Fraction(4, 5);
        
        Console.WriteLine(f1 + f2);
        Console.WriteLine(f1 - f2);
        Console.WriteLine(f1 * f2);
        Console.WriteLine(f1 / f2);
    }
}