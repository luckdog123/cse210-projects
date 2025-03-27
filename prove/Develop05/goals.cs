using System;
using System.IO;
using System.Collections.Generic;

class Goal
{
    private int _points = 0;
    private string _goaltitle = "";
    private string _goalDesription = "";
    // private string _
    public Goal(int points, string goaltitle , string goalDesription)
    {
        _points = points;
        _goaltitle = goaltitle; 
        _goalDesription = goalDesription;
    }
    public Goal()
    {
        // Empty constructor
    }
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
        System.IO.File.WriteAllText(filePath , "\b");   
        foreach (string bit in thebits)
        {
            System.IO.File.AppendAllText(filePath ,bit);
        }
    }
    // public virtual string readfromfile(string filePath)
    // {
    //     foreach (string line in File.ReadLines(filePath))
    //         {
    //             Console.WriteLine(line);
    //             // Process the current line here
    //         }
    //     string textFromFile = System.IO.File.ReadAllText(filePath);
    //     return textFromFile;
    // }
} 