class AnimateConsole
{
    private float _animationLength = 0;
    private List<string> _frames = new List<string>();
    private int _frameRate;
    private string _message = "";
    private List<string> _framesForSpinny = new List<string>()
    {
        "|",
        "/",
        "-",
        "\\"
    };
    private List<string> _framesPeriod = new List<string>(){
        "."
    };
    private List<string> _coundown = new List<string>()
    {
        
    };
    public void SetFramesForCountdown(int countDown)
    {
        _coundown.Clear();
        for (int i = countDown; i > 0; i--)
        {
            _coundown.Add(i.ToString());
        }
    }
    public void SetFramesForSpinny()
    {
         _frames = _framesForSpinny;
    }
    public void SetFramesPeriod()
    {
        _frames = _framesPeriod;
    }
    public AnimateConsole()
    {
    }
    public AnimateConsole(float animationLength, List<string> frames, int frameRate, string message)
    {
        _animationLength = animationLength;
        _frames = frames;
        _frameRate = frameRate;
        _message = message;
    }
    // Constructor
    public AnimateConsole(float animationLength, int frameRate , string message)
    {
        _animationLength = animationLength;
        _frameRate = frameRate;
        _message = message;
    }
    
        
    public void Animate()
    {
        int i = 0;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_animationLength);
        while (DateTime.Now <= end)
        {
            Console.Write(_frames[i]);
            Thread.Sleep(_frameRate);
            Console.Write("\b\b  \b\b");
            i++;
            if (i >= _frames.Count)
            {
                i = 0;
            }
        }
    }
    public string DisplayCommonMesg()
    {   
        string commonMessage = $"This activity will help you {_message}. ";
        return commonMessage;
    }

    public string PickingRanQuests(string[] questions)
    {
        Random random = new Random();
        int index = random.Next(questions.Length);
        return questions[index];
    }


}