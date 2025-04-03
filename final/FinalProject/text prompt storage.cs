class Prompt
{
    // this is where all the prompts and the logic for getting the prompts will be housed

    private static string[] _toRoom1 = 
    {
        "1this is a hint that the next room might be empty",
        "1this is the second",
        "1and the third"
    };
    private static string[] _toRoom2 = 
    {
        "2this is a hint that the next room might be empty",
        "2this is the second",
        "2and the third"
    };
    private static string[] _toRoom3 = 
    {
        "3this is a hint that the next room might be empty",
        "3this is the second",
        "3and the third"
    };
    private static string[] _toRoom4 = 
    {
        "4this is a hint that the next room might be empty",
        "4this is the second",
        "4and the third"
    };
    private static string[] _toRoom5 = 
    {
        "5this is a hint that the next room might be empty",
        "5this is the second",
        "5and the third"
    };
    public static string RoomHints(int NextPossibleRoom)
    {
        
        switch(NextPossibleRoom)
        {
            case 1:
                Random random = new Random();
                int promtChoice = random.Next(1, _toRoom1.Length);
                
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
        return roomHint;
    }
}