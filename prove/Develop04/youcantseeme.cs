class ReflectionActivity : AnimateConsole
{
    public ReflectionActivity() : base(5, 1000, "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    private List<string> _openingPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"
    };

    public List<string> _questionPrompts = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void dastuff() // this is the main function
  { 
    // I'm not sure what I'm supposed to do here
    // I'm just going to call the base class constructor
    // and then call the Animate function
    Console.Clear();
    Console.WriteLine(DisplayCommonMesg());
    int activityduration = int.Parse(Console.ReadLine());
    
    
        Console.WriteLine(); // I'm not sure why this is here
        Console.WriteLine("Here is your prompt:");
        Console.WriteLine(PickingRanQuestions(_openingPrompts));
        Console.WriteLine();
        Console.WriteLine("Think about each question. A new one will appear every 7 seconds.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(activityduration);
        // Console.Clear();
        // Console.WriteLine("Here is your prompt:");

        while (DateTime.Now <= end)
        {

            Console.WriteLine(PickingRanQuestions(_questionPrompts));

            SetFramesForSpinny(7);
            Animate();

        }
        Console.WriteLine("Great job! You have completed the reflection activity.");
        Console.WriteLine("Press enter to return to the main menu.");
        Console.ReadLine();
        Console.Clear();
  }
}