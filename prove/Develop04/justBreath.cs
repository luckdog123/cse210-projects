class JustBreath : AnimateConsole
{
    int _lengthOfActivity = 0;
    private string _openingLine = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _breathIn = "Breathe in...";
    private string _breathOut = "Breathe out...";
    private string _end = "Good job! You're done!";
    int _breathintake = 0;
    int _breathouttake = 0;

    // constructor
    public JustBreath(int lengthOfActivity, int breathintake = 5, int breathouttake = 5) : base(5 , 500 , "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _lengthOfActivity = lengthOfActivity;
        _breathintake = breathintake;
        _breathouttake = breathouttake;
    }
    
    public void openyourmouth()
    {
        
        Console.WriteLine(DisplayCommonMesg());
        Console.Clear();
        Console.WriteLine("How long would you like to do this activity?");
        _lengthOfActivity = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start! Exhale all the air out of your lungs.");
        SetFramesForCountdown(3);
        Animate();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_lengthOfActivity);
        while (DateTime.Now <= end)
        {
            SetFPS(1000);
            Console.WriteLine(_breathIn);
            SetFramesForCountdown(_breathintake);
            Animate();
            Console.WriteLine(_breathOut);
            SetFramesForCountdown(_breathouttake);
            Animate();
        }
        Console.WriteLine(_end);
        Thread.Sleep(2000);
        Console.Clear();
    }

}