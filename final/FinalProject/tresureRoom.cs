class TreasureRoom : Room
{
    public int ChestMonster()
    {
        Console.WriteLine("You mIght find somthing usful here ");
        Console.ReadLine();
        return TimeToLeave(4);
    }    
}