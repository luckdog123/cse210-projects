class Menu
{
    public static void menuStuffAndThings()
    {
        int userinput = Console.Read();
        while (userinput != 6)
        {
            switch(userinput)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("Bye!!!!");
                    break;
            }
                

        }

    }
} 