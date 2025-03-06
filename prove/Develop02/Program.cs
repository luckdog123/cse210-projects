using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        string menu_input = "five";
        while (menu_input != "5"){
            
            Console.WriteLine("1. Write a new entry :)");
            Console.WriteLine("2. Read an old entry.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.WriteLine("5. Quit");
            menu_input = Console.ReadLine();
            if (menu_input == "1"){
                Console.WriteLine("why mee");
            }
            else if (menu_input == "2"){
                Console.WriteLine("why mee");
            }
            else if (menu_input == "3"){
                Console.WriteLine("why mee");
            }
            else if (menu_input == "4"){
                Console.WriteLine("why mee");
            }
            else if (menu_input == "5"){
                Console.WriteLine("Bye!");
            }
            


        }
        
    }
}