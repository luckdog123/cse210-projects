class JustBreath : AnimateConsole
{
    int _lengthOfActivity = 0;
    private string _openingLine = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _breathIn = "Breathe in...";
    private string _breathOut = "Breathe out...";
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
        
        DisplayCommonMesg();
        SetFramesForSpinny();
        Animate();
        
    }

}