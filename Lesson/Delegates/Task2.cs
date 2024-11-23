namespace Lesson.Delegates;

public class Task2
{
    private delegate void Show();

    private delegate double Calculate(double first, double second);

    public Task2()
    {
        Show[] showMethods = [ShowTimeNow, ShowDate, ShowDayOfTheWeek];
        Calculate[] calculateMethods = [SquareOfTriangle, SquareOfRectangle];

        foreach (Show method in showMethods)
        {
            method();
        }

        foreach (Calculate method in calculateMethods)
        {
            Console.WriteLine(method(9, 15));
        }
    }

    private static void ShowTimeNow()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }

    private static void ShowDate()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }

    private static void ShowDayOfTheWeek()
    {
        Console.WriteLine(DateTime.Now.DayOfWeek);
    }

    private static double SquareOfTriangle(double _base, double height)
    {
        return _base / 2 * height;
    }

    private static double SquareOfRectangle(double width, double height)
    {
        return width * height;
    }
}