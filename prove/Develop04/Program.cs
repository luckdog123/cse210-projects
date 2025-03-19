using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> frame = new List<string>();
        frame.Add("10");
        frame.Add("20");
        frame.Add("30");
        frame.Add("40");
        
        // AnimateConsole ac = new AnimateConsole(10, frame, 3000);
        // ac.Animate();
        AnimateConsole ac2 = new AnimateConsole(18, 500);
        ac2.SetFramesForSpinny();
        ac2.Animate();
    }
}