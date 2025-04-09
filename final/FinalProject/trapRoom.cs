class TrapRoom : Room
{
    public int ItsATrap()
    {
        Random random = new Random();
        int randomIndex = random.Next(0,2);
        Console.WriteLine($"{Prompt._trapRoom[randomIndex]}");
        BeatemUpCombat.Minus15PlayerHealthToFile(BeatemUpCombat.GetPlayerHealth());
        Console.WriteLine($"Your health is now:{BeatemUpCombat.GetPlayerHealth()}");
        Console.ReadLine();
        return TimeToLeave(2);
    }    
}