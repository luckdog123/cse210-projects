
class Menu
{
    public static void MenuStuffAndThings()
    {
        int userinput = 33;

        while (userinput != 6)
        {
            Console.Clear();
            Console.WriteLine("1. Make a new goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit :(");
            userinput = int.Parse(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Make a basic goal\n2. Make a eternal goal\n3. Make a checklist goal");
                    userinput = int.Parse(Console.ReadLine());

                    switch (userinput)
                    {
                        case 1:
                            var basicgoal = new Goal();
                            Console.Clear();
                            string tempvar = $"0#{basicgoal.makeAgoal()}#0";
                            // Console.ReadLine();
                            break;
                        case 2:
                            var eternal = new Eternalgoal();
                            Console.Clear();
                            eternal.makeAgoal();
                            break;
                        case 3:
                            var checklists = new ChecklistGoals();
                            Console.Clear();
                            checklists.makeAgoal();
                            break;
                        default:
                            Console.WriteLine("\nInvalid input. Please enter a number between 1 and 6.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadLine();
                            break;
                    }
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
                        Console.WriteLine("\nGoodbye!");
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