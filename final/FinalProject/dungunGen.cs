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

    public static int MakeARoom(int lastRoomType , int nextRoomChoice=10)
    {
        int whereWeGoing = 0;
        if(nextRoomChoice < 6)
        {
            whereWeGoing = nextRoomChoice;
        }
        else
        {
            Room.NextRoomRandom(lastRoomType); 
        }

        switch(whereWeGoing)
        {
            case 1:
                EmptyRoom emptyRoom = new EmptyRoom();
                emptyRoom.TheresNothingHere(lastRoomType);
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



        return selectedRoom;
    }
}