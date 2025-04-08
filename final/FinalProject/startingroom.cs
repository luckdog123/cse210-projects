class StartingRoom : Room
{
    public int YoureFinnalyAwake()
    {
        // Console.Clear();
        Console.WriteLine("You wake up with a pounding headache, and a strange feeling of dread. You look around and see that you are in a dark room with no windows. You can hear the sound of dripping water in the distance. You have no idea how you got here, but you know you need to get out. \n Press enter to continue");
        Console.ReadLine();
        return TimeToLeave(10);
    }
}