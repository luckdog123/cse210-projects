class Goal
{
    public virtual string makeAgoal()
    {
        Console.WriteLine("What is the name of your goal?");
        Console.ReadLine();
        Console.WriteLine("What is a short discription of your goal?");
        Console.ReadLine();
        Console.WriteLine("How many points is your goal worth?");
        Console.ReadLine();
        return $"somthings wrong champ";
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