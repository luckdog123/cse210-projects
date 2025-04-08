
class BossRoom 
{
    public static int BossFight()
    {
        Console.WriteLine("You enter a room that is dark and foreboding. The air is thick with tension, and you can feel the weight of something powerful lurking in the shadows. As you step further into the room, a figure emerges from the darkness. It's a boss, and it's ready to fight.");
        Console.WriteLine("Press enter to continue");
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