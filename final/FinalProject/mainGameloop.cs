class GameLoop
{

    public static void MainGameLoop()
    {
        int roomNumber = 0;
        int dunLength = DunGen.RandomizeDunLength();
        List<int> roomType = new List<int>(); 
        int nextRoomChoice = 10;
        // This is what drives the whole game
        while(roomNumber <= dunLength)
        {
            
            if(roomNumber == 0){
                // do the startin room else do the normal thing
            }
            else if (roomNumber == dunLength-1){
                // boss fight time baby
            }
            else if(roomNumber == dunLength){
                // final room
            }
            else
            {
                // the normal part of the game
                DunGen play = new DunGen();
                roomType.Add(DunGen.MakeARoom((roomType[roomType.Count - 1]), nextRoomChoice));
                nextRoomChoice = play.GetNextRoom();
            }
            
        }
    } 
}