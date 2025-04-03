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
        int selectedRoom = 0;
        switch(whereWeGoing)
        {
            case 1:
                EmptyRoom emptyRoom = new EmptyRoom();
                selectedRoom = emptyRoom.TheresNothingHere();
                break;
            case 2:
                Console.WriteLine("this is the 2nd choice");
                break;
            case 3:
            Console.WriteLine("this is the 3rd choice");
                break;
            case 4:
            Console.WriteLine("this is the 4th choice");
                break;
            case 5:
            Console.WriteLine("this is the 5th choice");
                break;
        }



        return selectedRoom;
    }
}