using System;
using System.IO;
using System.Collections.Generic;

class Goal
{
    public virtual string makeAgoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string goaltitle = Console.ReadLine();
        Console.WriteLine("What is a short discription of your goal?");
        string desrciption = Console.ReadLine();
        Console.WriteLine("How many points is your goal worth?");
        int points = int.Parse(Console.ReadLine());
        return $"{goaltitle}#{desrciption}#{points}";
    }
    public virtual void writetofile(List<string> thebits, string filePath)
    {
        foreach (string bit in thebits)
        {
            System.IO.File.AppendAllText(filePath ,bit);
        }

    }
    public virtual string readfromfile(string filePath)
    {
        string textFromFile = System.IO.File.ReadAllText(filePath);
        return te;
    }
} 