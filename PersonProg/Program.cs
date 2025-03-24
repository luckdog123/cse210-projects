// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        // System.Console.WriteLine("Hello, World!");
        // Person p1 = new Person("John", "Doe", 25);
        // Console.WriteLine(p1.DisplayPersonInfo());
        
        PoliceMan pm1 = new PoliceMan("Tazer", "Mall", "Cop", 35);
        // Console.WriteLine(pm1.DisplayPoliceManInfo());
        
        TimeLord dr1 = new TimeLord("Rory", "Dr", "Who", 1000);
        Console.WriteLine(dr1.GetName());
        Console.WriteLine(dr1.GetHobbies());


        pm1.SetHeight(76);
        Console.WriteLine(pm1.GetName());
        Console.WriteLine(pm1.GetHobbies());
    }
}

