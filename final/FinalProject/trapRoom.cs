class TrapRoom : Room
{
    public int ItsATrap()
    {
        Console.WriteLine("This is a trap room");
        BeatemUpCombat.Minus15PlayerHealthToFile(BeatemUpCombat.GetPlayerHealth());
        Console.ReadLine();
        return TimeToLeave(2);
    }    
}