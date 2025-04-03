class EmptyRoom : Room
{


    public int TheresNothingHere()
    {
        // room discription prompt
        // room 
        Random random = new Random();
        int howMany = random.Next(1,3);
        switch(howMany)
        {
            case 1:
                int choice1 = Room.NextRoomRandom(1);
                break;
            case 2:
                choice1 = Room.NextRoomRandom(1);
                int choice2 = Room.NextRoomRandom(1);
                break;
            case 3:
                choice1 = Room.NextRoomRandom(1);
                choice2 = Room.NextRoomRandom(1);
                int choice3 = Room.NextRoomRandom(1);
                break;
        }
        
        return 1; // i need to return the players room choice
    }    
}