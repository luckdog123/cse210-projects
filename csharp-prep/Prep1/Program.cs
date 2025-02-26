using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine("Now what is your last name?");
        string last_name = Console.ReadLine();

        Console.WriteLine($"This is your name, {first_name.ToUpper()} {last_name}.");
    }
}