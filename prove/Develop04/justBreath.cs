class JustBreath : AnimateConsole
{
    int _lengthOfActivity = 0;
    private string _breathIn = "Breathe in...";
    private string _breathOut = "Breathe out...";
    private string _end = "Good job! You're done!";
    int _breathintake = 0;
    int _breathouttake = 0;

    // constructor
    public JustBreath(int lengthOfActivity, int breathintake = 5, int breathouttake = 5) : base(5 , 500 , "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _lengthOfActivity = lengthOfActivity;
        _breathintake = breathintake;
        _breathouttake = breathouttake;
    }
    
    public void openyourmouth()
    {
        Console.Clear();
        Console.WriteLine(DisplayCommonMesg());
        Console.WriteLine();
        _lengthOfActivity = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start! Exhale all the air out of your lungs.");
        SetFramesForSpinny(5);
        Animate();
        SetFramesForCountdown(10);
        Animate();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_lengthOfActivity);
        while (DateTime.Now <= end)
        {
            
            Console.WriteLine(_breathIn);
            SetFramesForCountdown(_breathintake);
            Animate();
            Console.WriteLine(_breathOut);
            SetFramesForCountdown(_breathouttake);
            Animate();
        }
        Console.WriteLine($"Wow! You just did a { _lengthOfActivity } second breathing exercise!");
        SetFramesForSpinny(3);
        Animate();
        Console.Clear();
    }

}