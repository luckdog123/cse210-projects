class ChecklistGoals : Goal
{
    public override string makeAgoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string goaltitle = Console.ReadLine();
        Console.WriteLine("What is a short discription of your goal?");
        string desrciption = Console.ReadLine();
        Console.WriteLine("How many times would you like to work on your goal?");
        int amount = Console.Read();
        Console.WriteLine("How many points is progress on your goal worth?");
        int smallpoints = Console.Read();
        Console.WriteLine("How many points should you get when you finish your goal?");
        int bigpoints = Console.Read();
        return $"2#{goaltitle}#{desrciption}#0#{amount}#{smallpoints}#{bigpoints}";
    }
} 