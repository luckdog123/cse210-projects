using System;
using System.IO;
using System.Collections.Generic;

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

    public string GetEnemyDescription()
    {
        return Type switch
        {
            EnemyType.Grunt => "A weak and expendable enemy, often found in large numbers.",
            EnemyType.Brute => "A strong and tough enemy, capable of dealing heavy damage.",
            EnemyType.Assassin => "A swift and deadly enemy, specializing in quick attacks.",
            EnemyType.Boss => "The ultimate challenge, a powerful foe with immense strength.",
            _ => "An unknown enemy type."
        };
    }
}

public class BeatemUpCombat
{
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
        PlayerHealth = 100;
        PlayerAttackPower = 10;
        PlayerDefense = 5;
        HasWeapon = false;
        CurrentEnemy = new Enemy(ChooseRandomEnemyType());
        LoadPlayerHealthFromFile();
    }

    // Combat setup methods
    public void ResetCombat()
    {
        PlayerHealth = 100;
        PlayerAttackPower = 10;
        PlayerDefense = 5;
        HasWeapon = false;
        CurrentEnemy = new Enemy(EnemyType.Boss);
    }

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

    // File handling methods
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
                    PlayerHealth = 100;
                }
            }
        }
        else
        {
            PlayerHealth = 100;
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
            }
        }
        return 100;
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
        _PlayerHealth -= 15;
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
            writer.WriteLine(100);
        }
    }

    // Weapon-related methods
    public (WeaponType, int) GetWeapon(WeaponType weaponType)
    {
        return weaponType switch
        {
            WeaponType.Gun => (WeaponType.Gun, 50),
            WeaponType.Mace => (WeaponType.Mace, 35),
            WeaponType.TableLeg => (WeaponType.TableLeg, 20),
            _ => throw new ArgumentException("Invalid weapon type")
        };
    }

    public static void SavePlayerWeaponToFile(int weaponChoice)
    {
        string filePath = "player_weapons.txt";
        WeaponType weapon = weaponChoice switch
        {
            1 => WeaponType.Gun,
            2 => WeaponType.Mace,
            3 => WeaponType.TableLeg,
            _ => throw new ArgumentException("Invalid weapon choice!")
        };

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(weapon.ToString());
        }
    }

    public List<WeaponType> LoadPlayerWeaponsFromFile()
    {
        string filePath = "player_weapons.txt";
        List<WeaponType> weapons = new List<WeaponType>();

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Enum.TryParse(line, out WeaponType weapon))
                    {
                        weapons.Add(weapon);
                    }
                }
            }
        }

        return weapons;
    }

    public bool DoesPlayerHaveWeapon()
    {
        var weapons = LoadPlayerWeaponsFromFile();
        return weapons.Count > 0;
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
                    PlayerAttackPower = random.Next(8, 13);
                    break;
                case "2":
                    Console.WriteLine("You delivered a kick!");
                    Random randomKick = new Random();
                    PlayerAttackPower = randomKick.Next(12, 18);
                    break;
                case "3":
                    if (weaponChoice == null)
                    {
                        Console.WriteLine("You don't have a weapon yet! Try again.");
                        continue;
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
                            WeaponType.Gun => randomWeapon.Next(45, 55),
                            WeaponType.Mace => randomWeapon.Next(30, 40),
                            WeaponType.TableLeg => randomWeapon.Next(18, 25),
                            _ => weapon.Item2
                        };
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    continue;
            }

            CurrentEnemy.Health -= PlayerAttackPower;
            Console.WriteLine($"You attacked the enemy! Enemy health is now: {CurrentEnemy.Health}");
            break;
        }
    }

    public void EnemyAttacksPlayer()
    {
        Console.WriteLine("The enemy is about to attack! Get ready to dodge!");
        Console.WriteLine("Press the correct key to evade the attack!");
        Random random = new Random();

        string[] keys = { "W", "A", "S", "D" };
        string keyToPress = keys[random.Next(keys.Length)];
        Console.WriteLine($"Press the key: {keyToPress}");

        Console.WriteLine("The enemy is preparing to attack...");
        System.Threading.Thread.Sleep(random.Next(500, 1200));

        Console.WriteLine("NOW! Press the key:");
        var startTime = DateTime.Now;
        string playerInput = Console.ReadLine();
        var reactionTime = (DateTime.Now - startTime).TotalMilliseconds;

        const double desiredReactionTime = 1000;
        const int maxDamage = 25;

        if (playerInput.ToUpper() == keyToPress)
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
        DoesPlayerHaveWeapon();
        Console.WriteLine("As you walk into the room you are suddenly confronted. You unfortunately realize that you are not alone in this room.");
        Console.WriteLine($"Enemy Type: {CurrentEnemy.Type}");
        Console.WriteLine($"Enemy Description: {CurrentEnemy.GetEnemyDescription()}");
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
            return false;
        }
        else if (CurrentEnemy.Health <= 0)
        {
            Console.WriteLine("You have defeated the enemy!");
            return true;
        }

        return false;
    }

    public bool BossFight()
    {
        Console.WriteLine("The final battle begins! Prepare to face the Boss!");

        ResetCombat();
        PlayerHealth = GetPlayerHealth();
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
            return false;
        }
        else if (CurrentEnemy.Health <= 0)
        {
            Console.WriteLine("Congratulations! You have defeated the Boss and won the game!");
            return true;
        }

        return false;
    }
}
