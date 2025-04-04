abstract class Room
{
    int _playerRoomChoice = 1;
    int _numberOfWaysToLeave = 1;
    
    // Parameterless constructor
    public Room()
    {
    }
    // Constructor with parameters
    public Room(int playerRoomChoice, int numberOfWaysToLeave)
    {
        _playerRoomChoice = playerRoomChoice;
        _numberOfWaysToLeave = numberOfWaysToLeave;
    }

    // Getter and Setter for _playerRoomChoice
    public int PlayerRoomChoice
    {
        get { return _playerRoomChoice; }
        set { _playerRoomChoice = value; }
    }

    // Getter and Setter for _numberOfWaysToLeave
    public int NumberOfWaysToLeave
    {
        get { return _numberOfWaysToLeave; }
        set { _numberOfWaysToLeave = value; }
    }
    public static int NextRoomRandom(int lastRoomType)
    {
            // chat helped me with this bit as it was too bulky before
            int[] allRooms = { 1, 2, 3, 4, 5 };
            // Filter out the lastRoomType from the list of all rooms
            int[] availableRooms = allRooms.Where(room => room != lastRoomType).ToArray();
            // Create a Random object
            Random random = new Random();
            // DunGenerate a random index within the bounds of the available rooms
            int randomIndex = random.Next(availableRooms.Length);
            return availableRooms[randomIndex];

    }
    protected static int DisplayRoomChoices(int c1 ,int c2 = 0,int c3=0)
    {   
        Console.WriteLine($"{Prompt.RoomHints(c1)}");
        Console.WriteLine($"Go to {c1}? "); //delete these lines once its working

        if(c2 != 0)
        {
            Console.WriteLine($"{Prompt.RoomHints(c2)}");
            Console.WriteLine($"Go to {c2}? "); //delete these lines once its working
        }
        if(c3 != 0)
        {
            Console.WriteLine($"{Prompt.RoomHints(c3)}");
            Console.WriteLine($"Go to {c3}? "); //delete these lines once its working
        }
        int choice;
    
        choice = int.Parse(Console.ReadLine());        
        switch(choice){
            case 1:
                choice = c1;            
                break;
            case 2:
                choice = c2;
                break;
            case 3:
                choice = c3;
                break;
            
        }
        return choice;
    }
    public virtual int TimeToLeave(int currentRoom)
    {
        // room discription prompt
        // room 
        Random random = new Random();
        // int howMany = random.Next(1,3);
        int playersChoice = 1;
        int[] ToDecideHowManyOptionsToGiveThePlayer = { 1, 2, 2, 2, 2, 2, 3, 3 };
        int howMany = random.Next(ToDecideHowManyOptionsToGiveThePlayer.Length);
        switch(howMany)
        {
            case 1:
                int choice1 = Room.NextRoomRandom(currentRoom);
                playersChoice = Room.DisplayRoomChoices(choice1);
                break;
            case 2:
                choice1 = Room.NextRoomRandom(currentRoom);
                int choice2 = Room.NextRoomRandom(currentRoom);
                playersChoice = Room.DisplayRoomChoices(choice1,choice2);
                break;
            case 3:
                choice1 = Room.NextRoomRandom(currentRoom);
                choice2 = Room.NextRoomRandom(currentRoom);
                int choice3 = Room.NextRoomRandom(currentRoom);
                playersChoice = Room.DisplayRoomChoices(choice1,choice2,choice3);
                break;
        }

        return playersChoice; // i need to return the players room choice
    }   
}