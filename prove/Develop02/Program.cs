using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        string menu_input = "five";
         Prompts prompts = new Prompts();
        while (menu_input != "5"){
            
            Console.WriteLine("1. Write a new entry :)");


            Console.WriteLine("2. Read an old entry.");
            // Console.WriteLine("3.");
            // Console.WriteLine("4.");
            Console.WriteLine("5. Quit");
            menu_input = Console.ReadLine();
            if (menu_input == "1"){
                
                Random random = new Random();
                Entry entry = new Entry();

                int randomNumberInRange = random.Next(1, 10);
                string jornalPrompt = prompts.GetPrompt(randomNumberInRange);
                entry.savePromptEntry(jornalPrompt);
                
                Console.WriteLine($"The prompt is: {jornalPrompt}");
                Console.WriteLine("Enter your journal entry: ");
                entry.SetUserEntry(Console.ReadLine());

                // added workout stuff for more jornal stuff and things
                
                string workout = "no";
                Console.WriteLine("Did you work out today? yes or no?");
                workout = Console.ReadLine().ToLower();   

                if (workout == "yes")
                {
                    entry.SetDidYouWorkOut(workout);
                    Console.WriteLine("What was your workout routine?");
                    entry.SetWorkOutRutine(Console.ReadLine());
                }

                Console.WriteLine($"Is this what you want to add to your jornal? yes or no?");
                entry.DisplayEntry();


                string userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    entry.writeToFile();
                }
                else
                {
                    Console.WriteLine("Entry not saved.");
                }   
            }
            else if (menu_input == "2"){
                Entry entry = new Entry();
                entry.readFromFile();
            }
            else if (menu_input == "5"){
                Console.WriteLine("Bye!");
            }
            


        }
        
    }
}