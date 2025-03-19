using System;

class Program
{
    static void Main(string[] args)
    {
        // List<string> frame = new List<string>();
        // frame.Add("10");
        // frame.Add("20");
        // frame.Add("30");
        // frame.Add("40");
        
        // // AnimateConsole ac = new AnimateConsole(10, frame, 600);
        // // ac.Animate();
        // AnimateConsole ac2 = new AnimateConsole(18, 500);
        // ac2.SetFramesForSpinny();
        // ac2.Animate();

        // menu stuff and things
        string userInput = "";
        while (userInput != "4")
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. List Activity");
            Console.WriteLine("4. Quit");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Breathing Activity");
                JustBreath jb = new JustBreath(10, 5, 5);
                jb.openyourmouth();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Reflection Activity");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("List Activity");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            
        }
     }
}