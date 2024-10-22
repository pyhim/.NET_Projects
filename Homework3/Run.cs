namespace Homework3;

internal class Run
{
    static void Main(string[] args)
    {
        // var city = new City(
        //     "London",
        //     "England",
        //     "+12311",
        //     ["dasd", "fsdfsdf", "fdsfgr"],
        //     2000000
        // );
        //
        // city.Print();
        // city.Input();
        // city.Print();
        
        // var employee = new Employee(
        //     "John", "Doe", "Smith", DateTime.Parse("04.04.1994"),
        //     "+1234413422", "fdsfsdf@gmail.com", "Manager", "Manages something"
        // );
        //
        // employee.Print();
        // employee.Input();
        // employee.Print();

        var plane1 = new Plane("Boeing 737", "Boeing Company", "04/29/2019", "Civil");
        var plane2 = new Plane("Boeing 737", "Boeing Company", DateTime.Parse("04/29/2020"), "Civil");

        plane1.Print();
        plane2.Print();
    }
}