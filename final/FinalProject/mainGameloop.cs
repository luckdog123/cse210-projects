class GameLoop
{

    public static void MainGameLoop()
    {
        int roomNumber = 0;
        int dunLength = DungenGen.RandomizeDunLength();
        List<int> roomType = new List<int>(); 
        // This is what drives the whole game
        while(roomNumber <= dunLength)
        {
            if(roomNumber == 0){
                // do the startin room else do the normal thing
            }
            else if (roomNumber == dunLength-1){
                // boss fight time baby
            }
            else
            {
                // the normal part of the game
                roomType.Add(DungenGen.MakeARoom((roomType[roomType.Count - 1])));
            }
            
        }
    } 
}