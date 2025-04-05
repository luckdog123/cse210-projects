class FightClub : Room
{
    public int YoullNeedHands()
    {
        
        Console.ReadLine();
        

        BeatemUpCombat combat = new BeatemUpCombat();
        bool combatResult = combat.StartCombat();
        if (combatResult == true)
        {
            Console.WriteLine("You have won the fight club ");
            Console.ReadLine();
            return TimeToLeave(3);
        }
        else
        {
            Console.WriteLine("You have lost the fight club ");
            Console.ReadLine();
            return TimeToLeave(3);
        }
        // return TimeToLeave(3);
    }    
}