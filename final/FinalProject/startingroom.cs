class StartingRoom : Room
{
    public int YoureFinnalyAwake()
    {
        Console.Clear();
        Console.WriteLine("To ineract with the game choose a number to pick which door you want to go through, and then press enter. Dodging will be a random key, then enter. Remember that dodging is timed. \n Press enter to continue");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("You wake up with a pounding headache, and a strange feeling of dread. You look around and see that you are in a dark room with no windows. You can hear the sound of dripping water in the distance. You have no idea how you got here, but you know you need to get out. You look around to see where you can go. \n Press enter to continue");
        Console.ReadLine();
        Console.Clear();
        return TimeToLeave(10);
    }
}