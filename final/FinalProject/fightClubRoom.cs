class FightClub : Room
{
    public int YoullNeedHands()
    {
        Console.WriteLine("First rule of fight club is you dont talk about fight club ");
        Console.WriteLine("Second rule of fight club is you dont talk about fight club ");
        
        Console.ReadLine();
        return TimeToLeave(3);
    }    
}