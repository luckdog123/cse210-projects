
class Menu
{
    public static void MenuStuffAndThings()
    {
        int userinput = 33;
        List<string> goalsToBeSaved = new List<string>{};  
          
        while (userinput != 6)
        {
            // Console.Clear();
            Console.WriteLine("1. Make a new goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit :(");
            userinput = int.Parse(Console.ReadLine());
            // string commonFileName = ""; add this feature in at the end for convience for the user and to get 100%
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
                    // Goal.ListGoals(Goal.theFactory(Goal.theFactoryPart2(goalsToBeSaved)));
                    break;
                case 3:
                    Console.WriteLine("What file are we saveing the goals to?");
                    string userfile = Console.ReadLine();
                    List<string> emotionalgrowth = Goal.goalToStrings(Goal.theFactory(userfile));
                    goalsToBeSaved.AddRange(emotionalgrowth);
                    Goal.writetofile(goalsToBeSaved , userfile);
                    
                    break;
                case 4:
                    Console.WriteLine("What file are Loading your goals from?");
                    List<Goal> goodluckcharlieborwn = Goal.theFactory(Console.ReadLine());
                    foreach(Goal goal in goodluckcharlieborwn)
                    {
                        goal.DisplayGoals();
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