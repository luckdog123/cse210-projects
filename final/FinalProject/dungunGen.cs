class DungenGen 
{
    // public List<int> 
    private int _dunLength = 10;
    
    public static int RandomizeDunLength()
    {
        int[] dunLength = { 8,9,10,10,10,12,13,15,17};
        // Create a Random object
        Random random = new Random();
        // Generate a random index within the bounds of the array
        int randomIndex = random.Next(dunLength.Length);
        // Access the element at the random index
        return dunLength[randomIndex];
    }

    public static int MakeARoom(int lastRoomType , int customRoom=10)
    {
        if(customRoom < 6)
        {
            Room.roomFabrication(customRoom);
            return customRoom;
        }
        // chat helped me with this bit as it was too much before
        int[] allRooms = { 1, 2, 3, 4, 5 };
        // Filter out the lastRoomType from the list of all rooms
        int[] availableRooms = allRooms.Where(room => room != lastRoomType).ToArray();
        
        // Create a Random object
        Random random = new Random();
        // Generate a random index within the bounds of the available rooms
        int randomIndex = random.Next(availableRooms.Length);
        
        // Get the selected room and fabricate it
        int selectedRoom = availableRooms[randomIndex];
        Room.roomFabrication(selectedRoom);
        
        return selectedRoom;
    }
}