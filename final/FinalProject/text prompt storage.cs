class Prompt
{
    // this is where all the prompts and the logic for getting the prompts will be housed

    private static string[] _toRoom1 = // empty room hints 
    {
        "The door is old and dusty but you can't hear anything behind it.",
        "You think you hear something slithering behind the door but you're not sure.",
        "It smells like something has been rotting behind the door for a while.",
    };
    private static string[] _toRoom2 = // combat room hints
    {
        "You can hear a growling sound coming from behind the door.",
        "There's omminous scratches along the base of the door and the door knob.",
        "You see a thick green gas seeping out from under the door.",
    };
    private static string[] _toRoom3 = // trap room hints
    {
        "The door is glass, and is overgrown with vines and moss.",
        "The door has a large 'pick me!' sign on it.",
        "Through a crack in the door you can see a bird watching you expectantly."
    };
    private static string[] _toRoom4 = // treasure room hints
    {
        "The door is made of pure gold with a crystal door knob.",
        "You can make out strange symbols and runes etched into the wood on the door.",
        "A bland door with a 'no soliciting' sign stabled onto it."
    };
    private static string[] _toRoom5 =  //Dog room hints
    {
        "This door has a large doggy door.",
        "Rather than a door, there is a small tunnel you can squeeze through.",
        "The words 'beware of dog' is carved into the rotting wood."
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