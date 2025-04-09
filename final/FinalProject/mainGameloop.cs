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
             DunGen play = new DunGen();

        while(roomNumber <= dunLength)
        {
            
            if(roomNumber == 0){
                // do the startin room else do the normal thing
                StartingRoom start = new StartingRoom();
                nextRoomChoice = start.YoureFinnalyAwake();
                roomNumber ++;
            }
            else if (roomNumber == dunLength-1){
                // boss fight time baby
                BossRoom boss = new BossRoom();
                int bossResult = BossRoom.BossFight();
                if (bossResult == 0)
                {
                    Console.WriteLine("You have been defeated by the boss. You feel a sense of despair as you realize that you have failed. Whomp whomp. \n Press enter to exit the game.");
                    Console.ReadLine();
                    return;
                }
                else if (bossResult == 1)
                {
                    Console.WriteLine("You won!! ");
                    Console.ReadLine();
                }
                roomNumber ++;
            }
            else if(roomNumber == dunLength){
                // final room
                
                roomNumber ++;
            }
            else
            {
                // the normal part of the game
               
                play.MakeARoom((roomType[roomType.Count - 1]), nextRoomChoice);
                
                nextRoomChoice = play.GetNextRoom(); // Get the next room type
                Console.WriteLine(nextRoomChoice);
                roomType.Add(nextRoomChoice);
                roomNumber ++;


                 // the normal part of the game
//                 DunGen play = new DunGen();
//                 // Get the player's choice from TimeToLeave, and store it in nextRoomChoice
//                 nextRoomChoice = Room.TimeToLeave(roomType[roomType.Count - 1]);
//                 int actualRoomType = DunGen.MakeARoom((roomType[roomType.Count - 1]), nextRoomChoice);
//                 roomType.Add(actualRoomType); // Add the *actual* room type
//                 roomNumber++;
            }
            
        }
    } 
}
// class GameLoop
// {

//     public static void MainGameLoop()
//     {
//         int roomNumber = 0;
//         int dunLength = DunGen.RandomizeDunLength();
//         List<int> roomType = new List<int>();
//         roomType.Add(10);
//         int nextRoomChoice = 10; // Start with a default value
//         // This is what drives the whole game
//         while (roomNumber <= dunLength)
//         {

//             if (roomNumber == 0)
//             {
//                 // do the startin room else do the normal thing
//                 StartingRoom start = new StartingRoom();
//                 start.YoureFinnalyAwake();
//                 roomNumber++;
//             }
//             else if (roomNumber == dunLength - 1)
//             {
//                 // boss fight time baby
//                 BossRoom boss = new BossRoom();
//                 int bossResult = BossRoom.BossFight();
//                 if (bossResult == 0)
//                 {
//                     Console.WriteLine("You have been defeated by the boss. You feel a sense of despair as you realize that you have failed. Whomp whomp. \n Press enter to exit the game.");
//                     Console.ReadLine();
//                     return;
//                 }
//                 else if (bossResult == 1)
//                 {
//                     Console.WriteLine("You won!! ");
//                     Console.ReadLine();
//                 }
//                 roomNumber++;
//             }
//             else if (roomNumber == dunLength)
//             {
//                 // final room

//                 roomNumber++;
//             }
//             else
//             {
//                 // the normal part of the game
//                 DunGen play = new DunGen();
//                 // Get the player's choice from TimeToLeave, and store it in nextRoomChoice
//                 nextRoomChoice = Room.TimeToLeave(roomType[roomType.Count - 1]);
//                 int actualRoomType = DunGen.MakeARoom((roomType[roomType.Count - 1]), nextRoomChoice);
//                 roomType.Add(actualRoomType); // Add the *actual* room type
//                 roomNumber++;
//             }

//         }
//     }
