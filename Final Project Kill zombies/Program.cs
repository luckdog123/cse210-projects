using System;

class Player
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
    public int Ammo { get; set; } = 10;
    public string Weapon { get; set; } = "Pistol";

    public Player(string name)
    {
        Name = name;
    }

    public void Attack(Zombie zombie)
    {
        if (Ammo > 0)
        {
            Ammo--;
            Random rand = new Random();
            int damage = rand.Next(20, 50);
            zombie.Health -= damage;
            Console.WriteLine($"{Name} shot the zombie for {damage} damage!");
        }
        else
        {
            Console.WriteLine("Out of ammo! You need to reload!");
        }
    }

    public void Reload()
    {
        Ammo = 10;
        Console.WriteLine("You reloaded your weapon!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} took {damage} damage! Health: {Health}");
    }
}

class Zombie
{
    public int Health { get; set; }

    public Zombie()
    {
        Random rand = new Random();
        Health = rand.Next(50, 100);
    }

    public void Attack(Player player)
    {
        Random rand = new Random();
        int damage = rand.Next(10, 30);
        player.TakeDamage(damage);
        Console.WriteLine("The zombie attacked!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Zombie Survival!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Player player = new Player(name);

        while (player.Health > 0)
        {
            Console.WriteLine("\nA zombie appears!");
            Zombie zombie = new Zombie();

            while (zombie.Health > 0)
            {
                Console.Write("\nChoose action: [A]ttack, [R]un, [L]oad Ammo: ");
                string action = Console.ReadLine().ToLower();

                if (action == "a")
                {
                    player.Attack(zombie);
                    if (zombie.Health > 0)
                        zombie.Attack(player);
                }
                else if (action == "r")
                {
                    Console.WriteLine("You ran away!");
                    break;
                }
                else if (action == "l")
                {
                    player.Reload();
                }
                else
                {
                    Console.WriteLine("Invalid action!");
                }
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("Game Over! You were eaten by zombies...");
                break;
            }

            Console.WriteLine($"Zombie defeated! {player.Name}'s Health: {player.Health}, Ammo: {player.Ammo}");
        }

        Console.WriteLine("Thanks for playing!");
    }
}
