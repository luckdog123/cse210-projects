class TreasureRoom : Room
{
    public int ChestMonster()
    {
        // Console.WriteLine("You might find somthing usful here ");
        Console.WriteLine("You see a treasure chest in the corner of the room. It looks old and dusty, as you break it open you see at the bottom there is a Mace inside. You grab the mace and look to see where youll go next. \n Press enter to continue");

        BeatemUpCombat.SavePlayerWeaponToFile(1);
        Console.ReadLine();
        Console.Clear();
        return TimeToLeave(4);
    }    
}