class TreasureRoom : Room
{
    public int TheresNothingHere()
    {
        Console.WriteLine("You mIght find somthing usful here ");
        Console.ReadLine();
        return TimeToLeave(4);
    }    
}