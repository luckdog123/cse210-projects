using System;
using System.IO;

// ai was used to generate this code
// Enemy types
public enum EnemyType
{
    Grunt,
    Brute,
    Assassin,
    Boss
}

public class Enemy
{
    public EnemyType Type { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public Enemy(EnemyType type)
    {
        Type = type;
        switch (type)
        {
            case EnemyType.Grunt:
                Health = 50;
                AttackPower = 5;
                Defense = 2;
                break;
            case EnemyType.Brute:
                Health = 80;
                AttackPower = 10;
                Defense = 5;
                break;
            case EnemyType.Assassin:
                Health = 60;
                AttackPower = 15;
                Defense = 3;
                break;
            case EnemyType.Boss:
                Health = 150;
                AttackPower = 20;
                Defense = 10;
                break;
            default:
                throw new ArgumentException("Invalid enemy type");
        }
    }
    
    
}

class BeatemUpCombat
{
    public static EnemyType ChooseRandomEnemyType()
    {
        Array enemyTypes = Enum.GetValues(typeof(EnemyType));
        Random random = new Random();
        EnemyType randomEnemy;

        do
        {
            randomEnemy = (EnemyType)enemyTypes.GetValue(random.Next(enemyTypes.Length));
        } while (randomEnemy == EnemyType.Boss);

        return randomEnemy;
    }
    // Properties
    public int PlayerHealth { get; set; }
    public int PlayerAttackPower { get; set; }
    public int PlayerDefense { get; set; }
    public bool HasWeapon { get; set; }
    public Enemy CurrentEnemy { get; set; }

    // Enum for weapon types
    public enum WeaponType
    {
        Gun,
        Mace,
        TableLeg
    }

    // Constructor
    public BeatemUpCombat()
    {
        PlayerHealth = 100; // Default player health
        PlayerAttackPower = 10; // Default player attack power
        PlayerDefense = 5; // Default player defense
        HasWeapon = false; // Default player does not have a weapon
        CurrentEnemy = new Enemy(ChooseRandomEnemyType()); // Initialize the enemy with a random enemy type
        LoadPlayerHealthFromFile(); // Load player health from file during initialization
    }

    // Methods for combat setup
    public void ResetCombat() // use this for the boss fight
    {
        PlayerHealth = 100; // Default player health
        PlayerAttackPower = 10; // Default player attack power
        PlayerDefense = 5; // Default player defense
        HasWeapon = false; // Default player does not have a weapon
        CurrentEnemy = new Enemy(EnemyType.Boss); // Initialize the enemy
    }

    private void LoadPlayerHealthFromFile()
    {
        string filePath = "player_health.txt";
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                if (int.TryParse(reader.ReadLine(), out int loadedHealth))
                {
                    PlayerHealth = loadedHealth;
                }
                else
                {
                    PlayerHealth = 100; // Default health
                }
            }
        }
        else
        {
            PlayerHealth = 100; // Default health
        }
    }
    public static int GetPlayerHealth()
    {
        string filePath = "player_health.txt";
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                if (int.TryParse(reader.ReadLine(), out int loadedHealth))
                {
                    return loadedHealth;
                }
                else
                {
                    return 100; // Default health
                }
            }
        }
        else
        {
            return 100; // Default health
        }
        // return ;
    }

    // Weapon-related methods
    public (WeaponType, int) GetWeapon(WeaponType weaponType)
    {
        switch (weaponType)
        {
            case WeaponType.Gun:
                return (WeaponType.Gun, 50); // Gun damage
            case WeaponType.Mace:
                return (WeaponType.Mace, 35); // Mace damage
            case WeaponType.TableLeg:
                return (WeaponType.TableLeg, 20); // Table leg damage
            default:
                throw new ArgumentException("Invalid weapon type");
        }
    }

    public bool PlayerHasWeapon()
    {
        return HasWeapon;
    }

    // Combat actions
    public void AttackEnemy(string weaponChoice = null)
    {
        while (true)
        {
            Console.WriteLine("Choose your attack: 1) Punch 2) Kick 3) Use Weapon");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You threw a punch!");
                    Random random = new Random();
                    PlayerAttackPower = random.Next(8, 13); // Punch damage range: 8 to 12
                    break;
                case "2":
                    Console.WriteLine("You delivered a kick!");
                    Random randomKick = new Random();
                    PlayerAttackPower = randomKick.Next(12, 18); // Kick damage range: 12 to 17
                    break;
                case "3":
                    if (weaponChoice == null)
                    {
                        Console.WriteLine("You don't have a weapon yet! Try again.");
                        continue; // Allow the player to try again
                    }
                    else
                    {
                        WeaponType selectedWeapon = weaponChoice switch
                        {
                            "1" => WeaponType.Gun,
                            "2" => WeaponType.Mace,
                            "3" => WeaponType.TableLeg,
                            _ => throw new ArgumentException("Invalid weapon choice! Try again.")
                        };

                        var weapon = GetWeapon(selectedWeapon);
                        Random randomWeapon = new Random();
                        PlayerAttackPower = selectedWeapon switch
                        {
                            WeaponType.Gun => randomWeapon.Next(45, 55), // Gun damage range: 45 to 54
                            WeaponType.Mace => randomWeapon.Next(30, 40), // Mace damage range: 30 to 39
                            WeaponType.TableLeg => randomWeapon.Next(18, 25), // Table leg damage range: 18 to 24
                            _ => weapon.Item2
                        };
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    continue; // Allow the player to try again
            }

            CurrentEnemy.Health -= PlayerAttackPower;
            Console.WriteLine($"You attacked the enemy! Enemy health is now: {CurrentEnemy.Health}");
            break; // Exit the loop after a successful attack
        }
    // End of AttackEnemy method

        CurrentEnemy.Health -= PlayerAttackPower;
        Console.WriteLine($"You attacked the enemy! Enemy health is now: {CurrentEnemy.Health}");
    }

    public void EnemyAttacksPlayer()
    {
        Console.WriteLine("The enemy is about to attack! Get ready to dodge!");
        Console.WriteLine("Press the correct key sequence to evade the attack!");
        Random random = new Random();

        // Generate a random key sequence for the player to press
        string[] keySequence = { "W", "A", "S", "D" };
        string sequenceToPress = string.Join(" ", keySequence.OrderBy(x => random.Next()).Take(3));
        Console.WriteLine($"Key sequence: {sequenceToPress}");

        Console.WriteLine("The enemy is preparing to attack...");
        System.Threading.Thread.Sleep(random.Next(500, 1200)); // Delay before attack

        Console.WriteLine("NOW! Enter the sequence:");
        var startTime = DateTime.Now;
        string playerInput = Console.ReadLine();
        var reactionTime = (DateTime.Now - startTime).TotalMilliseconds;

        const double desiredReactionTime = 500; // Desired reaction time in milliseconds
        const int maxDamage = 25; // Maximum damage if the player fails completely

        if (playerInput.ToUpper() == sequenceToPress)
        {
            if (reactionTime <= desiredReactionTime)
            {
                Console.WriteLine("Amazing! You dodged the attack with precision!");
            }
            else
            {
                double damageMultiplier = Math.Min((reactionTime - desiredReactionTime) / desiredReactionTime, 1.0);
                int damageTaken = (int)(CurrentEnemy.AttackPower + (maxDamage * damageMultiplier));
                PlayerHealth -= damageTaken;
                Console.WriteLine($"You dodged too slowly! You took {damageTaken} damage. Your health is now: {PlayerHealth}");
            }
        }
        else
        {
            Console.WriteLine("You failed to dodge the attack!");
            PlayerHealth -= maxDamage;
            Console.WriteLine($"The enemy attacked you! Your health is now: {PlayerHealth}");
        }
    }

    // Combat status and flow
    public void DisplayCombatStatus()
    {
        Console.WriteLine($"Player Health: {PlayerHealth}");
        Console.WriteLine($"Enemy Health: {CurrentEnemy.Health}");
    }

    public bool IsCombatOver()
    {
        return PlayerHealth <= 0 || CurrentEnemy.Health <= 0;
    }

    public bool StartCombat()
    {
        Console.WriteLine("Combat has started!");
        DisplayCombatStatus();

        while (!IsCombatOver())
        {
            Console.WriteLine("\nYour turn:");
            AttackEnemy();

            if (IsCombatOver())
            {
                Console.WriteLine("Combat is over!");
                break;
            }

            Console.WriteLine("\nEnemy's turn:");
            EnemyAttacksPlayer();

            if (IsCombatOver())
            {
                Console.WriteLine("Combat is over!");
                break;
            }

            DisplayCombatStatus();
        }

        SavePlayerHealthToFile();

        if (PlayerHealth <= 0)
        {
            Console.WriteLine("You have been defeated!");
            return false; // Indicate the player died
        }
        else if (CurrentEnemy.Health <= 0)
        {
            Console.WriteLine("You have defeated the enemy!");
            return true; // Indicate the player won
        }

        return false; // Default return value
    }

    private void SavePlayerHealthToFile()
    {
        string filePath = "player_health.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(PlayerHealth);
        }
    }
    public static void Minus15PlayerHealthToFile(int _PlayerHealth)
    {
        _PlayerHealth -= 15; // Reduce player health by 15
        string filePath = "player_health.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_PlayerHealth);
        }
    }

    public static void ResetPlayerHealthToFull()
    {
        string filePath = "player_health.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(100); // Reset health to full and save to file
        }
    }
    public bool BossFight()
    {
        Console.WriteLine("The final battle begins! Prepare to face the Boss!");

        // Reset combat for the boss fight
        ResetCombat();

        // Load player health from file
        PlayerHealth = GetPlayerHealth();

        // Display initial combat status
        DisplayCombatStatus();

        while (!IsCombatOver())
        {
            Console.WriteLine("\nYour turn:");
            AttackEnemy();

            if (IsCombatOver())
            {
                Console.WriteLine("Combat is over!");
                break;
            }

            Console.WriteLine("\nBoss's turn:");
            EnemyAttacksPlayer();

            if (IsCombatOver())
            {
                Console.WriteLine("Combat is over!");
                break;
            }

            DisplayCombatStatus();
        }

        SavePlayerHealthToFile();

        if (PlayerHealth <= 0)
        {
            Console.WriteLine("You have been defeated by the Boss!");
            return false; // Indicate the player died
        }
        else if (CurrentEnemy.Health <= 0)
        {
            Console.WriteLine("Congratulations! You have defeated the Boss and won the game!");
            return true; // Indicate the player won
        }

        return false; // Default return value to satisfy all code paths
    }
}
