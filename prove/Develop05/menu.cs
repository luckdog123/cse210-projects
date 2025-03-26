
class Menu
{
    public static void menuStuffAndThings()
    {
        int userinput = 33;

        while (userinput != 6)
        {
            // Console.Clear();
            Console.WriteLine("1.\n2.\n3.\n4.\n5.\n6. Quit :(");
            userinput = int.Parse(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                 case 6:
                        Console.WriteLine("\nExiting the application. Goodbye!");
                        break;
                default:
                    Console.WriteLine("\nInvalid input. Please enter a number between 1 and 6.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    break;
            }
                

        }

    }
} 