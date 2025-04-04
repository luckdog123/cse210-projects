class TrapRoom : Room
{
    public int ItsATrap()
    {
        Console.WriteLine("This is a trap room");
        Console.ReadLine();
        return TimeToLeave(2);
    }    
}