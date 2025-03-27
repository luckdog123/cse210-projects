
class Menu
{
    public static void MenuStuffAndThings()
    {
        int userinput = 33;
        List<string> goalsToBeSaved = new List<string>{};  
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
                            goalsToBeSaved.Add($"0#{basicgoal.makeAgoal()}#0");
                            break;
                        case 2:
                            var eternal = new Eternalgoal();
                            Console.Clear();
                            goalsToBeSaved.Add(eternal.makeAgoal());
                            break;
                        case 3:
                            var checklists = new ChecklistGoals();
                            Console.Clear();
                            goalsToBeSaved.Add(checklists.makeAgoal());
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
                    List<Goal> processedFood = new List<Goal>();
                    List<string> unProcessedFood = new List<string>();

                    Console.WriteLine("Load goals");
                    Goal stuff = new Goal();
                    Console.WriteLine("What file are we reading your goals from?");
                    foreach (string line in File.ReadLines(Console.ReadLine()))
                    {
                        unProcessedFood.Add(line);
                    }
                    foreach(string goalline in unProcessedFood)
                    {
                        foreach(char i in goalline)
                        {
                            if(i == 0)
                            {

                            }
                            else if(i == 1)
                            {

                            }
                            else if(i == 2)
                            {

                            }
                            break;
                        }
                    }
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