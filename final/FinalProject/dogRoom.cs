class DogRoom : Room
{
    public int WhosAGoodBoy()
    {
        Console.WriteLine("You see a dog do you pet it? (y/n)");
        Console.ReadLine();
        return TimeToLeave(5);
    }    
}