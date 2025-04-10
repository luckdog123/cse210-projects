class DunGen 
{ 
    private int _nextRoom = 10;
    
    public DunGen(){}
    // public List<int> 
    private int _dunLength = 10;
    public int GetNextRoom()
    {
        return _nextRoom;
    }

    public static int RandomizeDunLength()
    {
        int[] dunLength = { 8,9,10,10,10,12,13,15,17};
        // Create a Random object
        Random random = new Random();
        // DunGenerate a random index within the bounds of the array
        int randomIndex = random.Next(dunLength.Length);
        // Access the element at the random index
        return dunLength[randomIndex];
    }

    public int MakeARoom(int lastRoomType , int nextRoomChoice=10)
    {
        int whereWeGoing = 0;
        if(nextRoomChoice < 6)
        {
            whereWeGoing = nextRoomChoice;
        }
        else
        {
            whereWeGoing = Room.NextRoomRandom(lastRoomType); 
        }
        int selectedRoom = 0;
        // where we going is the room type we are going to
        // whereWeGoing is still equaling 0 so we need to fix that
        if (whereWeGoing == 1)
        {
            // Console.WriteLine("this is an empty room");
            EmptyRoom emptyRoom = new EmptyRoom();
             _nextRoom = emptyRoom.TheresNothingHere();
        }
        else if (whereWeGoing == 2)
        {
            // Console.WriteLine("this is a combat room");
            FightClub combatRoom = new FightClub();
             _nextRoom = combatRoom.YoullNeedHands();
            // selectedRoom = 2;
        }
        else if (whereWeGoing == 3)
        {
            // Console.WriteLine("this is a trap room");
            TrapRoom trapRoom = new TrapRoom();
             _nextRoom = trapRoom.ItsATrap();
        }
        else if (whereWeGoing == 4)
        {
            // Console.WriteLine("this is a treasure room");
            TreasureRoom treasureRoom = new TreasureRoom();
             _nextRoom = treasureRoom.ChestMonster();
        }
        else if (whereWeGoing == 5)
        {
            // Console.WriteLine("this is the find a friend room");
            DogRoom dogRoom = new DogRoom();
             _nextRoom = dogRoom.WhosAGoodBoy();
        }


        return selectedRoom;
    }
}