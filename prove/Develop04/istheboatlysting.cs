class ListActivity : AnimateConsole
{
    private int _answerCount = 0;
    

    public ListActivity() : base(5, 700, "reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    private List<string> _prompts = new List<string>()
    {
        "Who are some of your personal heroes?",
        "When have you felt the Holy Ghost this month?",
        "Who are people that you have helped this week?",
        "What are personal strengths of yours?",
        "Who are people that you appreciate?"
    };
    

    public void MirriorMirrorOnTheWall()
    {
        Console.WriteLine(DisplayCommonMesg());
        int activityduration = int.Parse(Console.ReadLine());
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(activityduration);
        while (DateTime.Now <= end)
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Here is your prompt:");
            Console.WriteLine(PickingRanQuestions(_prompts));
            Console.WriteLine("Get ready to start!And remeber to hit enter after each answer.");
            // SetFPS(700);
            SetFramesForSpinny(5);
            Animate();
            
           while (DateTime.Now <= end)
           {
            Console.ReadLine();
            _answerCount++;
           }
        }
        Console.WriteLine($"Wow! You just listed {_answerCount} things!");
        SetFramesForSpinny(3);  
        Animate();
        Console.Clear();
        Console.WriteLine("Press enter to return to the main menu.");
        Console.ReadLine();
        Console.Clear();
    }
        

    // public ListActivity(string argument1, int argument2) : base(argument1, argument2)
    // {
    // }
}