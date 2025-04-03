class StartingRoom : Room
{
    public int YoureFinnalyAwake()
    {
        Console.WriteLine("This is some fire flavor text for the start of teh game ");
        Console.ReadLine();
        return TimeToLeave(10);
    }
}