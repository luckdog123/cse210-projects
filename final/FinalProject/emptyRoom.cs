class EmptyRoom : Room
{
    public int TheresNothingHere()
    {
        Console.WriteLine("This is some fire flavor text ");
        Console.ReadLine();
        return TimeToLeave(1);
    }    
}