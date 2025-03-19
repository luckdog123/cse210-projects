class AnimateConsole
{
    private float _animationLength = 0;
    private List<string> _frames = new List<string>();
    private int _frameRate;

    public AnimateConsole(float animationLength, List<string> frames, int frameRate)
    {
        _animationLength = animationLength;
        _frames = frames;
        _frameRate = frameRate;
    }
    public AnimateConsole(float animationLength, int frameRate)
    {
        _animationLength = animationLength;
        _frameRate = frameRate;
    }
        
    public void Animate()
    {
        int i = 0;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_animationLength);
        while (DateTime.Now < end)
        {
            Console.Write(_frames[i]);
            Thread.Sleep(_frameRate);
            Console.Write("\b\b  \b\b");
            if (i >= _frames.Count)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
    }
}