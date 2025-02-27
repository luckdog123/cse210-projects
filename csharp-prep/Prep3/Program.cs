using System;

class Program
{
    static void Main(string[] args)
    {
        string hint = "No hint yet";
        string go_again = "YES";
        do{
            
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 67);
            Console.WriteLine("Welcome to the Magic number game guess a number between 1 and 67. A whole number.");

            Console.WriteLine($"Now guess again you guess needs to be {hint}");
        } while (go_again == "YES");
    }
}