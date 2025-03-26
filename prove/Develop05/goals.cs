class Goal
{
    public virtual string makeAgoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string goaltitle = Console.ReadLine();
        Console.WriteLine("What is a short discription of your goal?");
        string desrciption = Console.ReadLine();
        Console.WriteLine("How many points is your goal worth?");
        int points = int.Parse(Console.ReadLine());
        return $"{goaltitle}#{desrciption}#{points}";
    }
    public virtual string writetofile()
    {
        return $"stuff";
    }
    public virtual string readfromfile()
    {
        return $"stuff";
    }
} 