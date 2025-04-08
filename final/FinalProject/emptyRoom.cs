class EmptyRoom : Room
{ 
    public int TheresNothingHere()
    {
        Console.WriteLine("You enter a room that is completely empty. There is nothing here but dust and cobwebs. You feel a sense of unease as you look around, but you know you need to keep moving. \n Press enter to continue");
        Console.ReadLine();
        return TimeToLeave(1);
    }    
}