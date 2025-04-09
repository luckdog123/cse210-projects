class DogRoom : Room
{
    public int WhosAGoodBoy()
    {
        Console.WriteLine("You see a dog. Do you pet it? (y/n)");
        string input = Console.ReadLine()?.ToLower();

        if (input == "y")
        {
            Console.WriteLine("The dog wags its tail happily. You feel a sense of joy. After you pet the dog it walks throug a hole in the wall. Unfortunately you cant follow it. \n Press enter to continue");
        }
        else if (input == "n")
        {
            Console.WriteLine("The dog looks disappointed and you feel sad becasue your a terrible person. He was a very good boy and you justt ignored him. \n Press enter to continue");
            Console.WriteLine("You look around for a way out and see...");
        }
        else
        {
            Console.WriteLine("The dog tilts its head in confusion. Please answer with 'y' or 'n'.");
        }
        Console.ReadLine();
        Console.Clear();
        return TimeToLeave(5);
    }    
}