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
    protected virtual void DisplayRoomChoices(int choice1 ,int c2 = 0,int c3=0)
    {   
        Console.WriteLine();

        if(c2 != 0)
        {
            Console.WriteLine();
        }
        if(c3 != 0)
        {
            Console.WriteLine();
        }
    }
    
}