class Prompt
{
    // this is where all the prompts and the logic for getting the prompts will be housed

    private static string[] _toRoom1 = // empty room hints 
    {
        "The door is old and dusty but you can't hear anything behind it",
        "You think you hear something slithering behind the door but your not sure",
        "It smells like something has been rotting behind the door for a while",
    };
    private static string[] _toRoom2 = // combat room hints
    {
        "2this is a hint that the next room might be empty",
        "2this is the second",
        "2and the third"
    };
    private static string[] _toRoom3 = // trap room hints
    {
        "3this is a hint that the next room might be empty",
        "3this is the second",
        "3and the third"
    };
    private static string[] _toRoom4 = // treasure room hints
    {
        "4this is a hint that the next room might be empty",
        "4this is the second",
        "4and the third"
    };
    private static string[] _toRoom5 =  //Dog room hints
    {
        "5this is a hint that the next room might be empty",
        "5this is the second",
        "5and the third"
    };
    public static string RoomHints(int NextPossibleRoom)
    {
        string roomHint = "If youre reading this somthing didnt work right line 37 text prompt storage";
        Random random = new Random();
        int promtChoice = random.Next(1, _toRoom1.Length);
        switch(NextPossibleRoom)
        {
            case 1:
                roomHint =_toRoom1[promtChoice];
                break;
            case 2:
                roomHint =_toRoom2[promtChoice];
                break;
            case 3:
                roomHint =_toRoom3[promtChoice];
                break;
            case 4:
                roomHint =_toRoom4[promtChoice];
                break;
            case 5:
                roomHint =_toRoom5[promtChoice];
                break;
        }
        return roomHint;
    }
}