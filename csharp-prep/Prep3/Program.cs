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
            Console.WriteLine($"The magic number is {magic_number}");
            int user_guess = int.Parse(Console.ReadLine());
            while(user_guess != magic_number){
                if (user_guess < magic_number){
                    Console.WriteLine($"Now guess again you guess needs to be HIGHER");
                    user_guess = int.Parse(Console.ReadLine());
                }
                else if (user_guess > magic_number){
                    Console.WriteLine($"Now guess again you guess needs to be LOWER");
                    user_guess = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Congrats!!! You found the magic number!!!! Do you want to play again?");
            go_again = Console.ReadLine().ToUpper();
            ;
        } while (go_again == "YES");
    }
}