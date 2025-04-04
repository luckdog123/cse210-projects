class GameLoop
{

    public static void MainGameLoop()
    {
        int roomNumber = 0;
        int dunLength = DunGen.RandomizeDunLength();
        List<int> roomType = new List<int>(); 
        roomType.Add(10);
        int nextRoomChoice = 10;
        // This is what drives the whole game
        while(roomNumber <= dunLength)
        {
            
            if(roomNumber == 0){
                // do the startin room else do the normal thing
                StartingRoom start = new StartingRoom();
                start.YoureFinnalyAwake();
                roomNumber ++;
            }
            else if (roomNumber == dunLength-1){
                // boss fight time baby
                roomNumber ++;
            }
            else if(roomNumber == dunLength){
                // final room
                roomNumber ++;
            }
            else
            {
                // the normal part of the game
                DunGen play = new DunGen();
                DunGen.MakeARoom((roomType[roomType.Count - 1]), nextRoomChoice);
                roomType.Add(nextRoomChoice);
                // nextRoomChoice = play.GetNextRoom(); why did i do this?
                roomNumber ++;
            }
            
        }
    } 
}