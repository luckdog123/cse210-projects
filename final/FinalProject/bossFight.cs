
class BossRoom 
{
    public static int BossFight()
    {
        Console.WriteLine("As you enter this room you immediatly see a hukling figure in the corner. It looks like a giant troll. You feel a sense of dread. But you also notice that there is a metal door behind it that looks like it is in better repair than the rest of the place. You also soo what apears to be a access key hung on a lanyard around the trolls neck.  \n Press enter to continue");
        // Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        BeatemUpCombat combat = new BeatemUpCombat();
        bool combatResult = combat.BossFight();
        if (combatResult == true)
        {
            return 1;
            // return TimeToLeave(3);
        }
        else
        {
            return 0;
            // return TimeToLeave(3);
        }
    }
}