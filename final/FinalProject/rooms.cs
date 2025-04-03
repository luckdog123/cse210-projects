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
        Console.WriteLine($"Go to {c1}? ");

        if(c2 != 0)
        {
            Console.WriteLine($"Go to {c2}? ");
        }
        if(c3 != 0)
        {
            Console.WriteLine($"Go to {c3}? ");
        }
        int choice;
        while (true)
        {
            Console.Write("What do you chose? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice)) // read more into "out" statments they are cool. Chat gave me this
            {
            break;
            }
            else
            {
            Console.WriteLine("That door doesn't exist try again.");
            }
        }
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
    
}