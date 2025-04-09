class FightClub : Room
{
    public int YoullNeedHands()
    {
        
        // Console.ReadLine();
        

        BeatemUpCombat combat = new BeatemUpCombat();
        bool combatResult = combat.StartCombat();
        if (combatResult == true)
        {
            Console.WriteLine("Congrats youll live through at least one more room.");
            Console.ReadLine();
            Console.Clear();
            return TimeToLeave(3);
        }
        else
        {
            Console.WriteLine("haha noob");
            Console.ReadLine();
            Console.Clear();
            return TimeToLeave(3);
        }
        // return TimeToLeave(3);
        
    }    
}