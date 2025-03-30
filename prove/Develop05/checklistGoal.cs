class ChecklistGoals : Goal
{
    private string _goalTitle;
    private string _description;
    private int _currentProgress;
    private int _targetAmount;
    private int _smallPoints;
    private int _bigPoints;

    public ChecklistGoals(string goalTitle, string description, int targetAmount, int smallPoints, int bigPoints, int currentProgress)
    {
        _goalTitle = goalTitle;
        _description = description;
        _currentProgress = currentProgress; // Initialize progress to 0
        _targetAmount = targetAmount;
        _smallPoints = smallPoints;
        _bigPoints = bigPoints;
    }

    public ChecklistGoals()
    {
        _goalTitle = "";
        _description = "";
        _currentProgress = 0;
        _targetAmount = 0;
        _smallPoints = 0;
        _bigPoints = 0;
    }
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