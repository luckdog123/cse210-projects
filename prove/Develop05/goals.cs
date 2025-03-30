using System;
using System.IO;
using System.Collections.Generic;

class Goal
{
    private int _points;
    private string _goaltitle = "";
    private string _goalDesription = "";
    private bool _done;

    public Goal(int points, string goaltitle, string goalDesription)
    {
        _points = points;
        _goaltitle = goaltitle;
        _goalDesription = goalDesription;
    }

    public Goal(int points, string goaltitle, string goalDesription, bool done)
    {
        _points = points;
        _goaltitle = goaltitle;
        _goalDesription = goalDesription;
        _done = done;
    }

    public Goal()
    {
        // Empty constructor
    }

    public virtual void DisplayGoals()
    {
        string x = _done ? "X" : " "; // chat showed me a shorthand way for simple if else statments
        Console.WriteLine($"[{x}]  Goal Title: {_goaltitle} Goal Description: {_goalDesription} How many points when finished: {_points}");
    }
    public static void ListGoals(List<Goal> goalsToBeDisplayed)
    {
        foreach(Goal goal in goalsToBeDisplayed)
        {
            goal.DisplayGoals();
        }
    }
    public virtual string makeAgoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string goaltitle = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal?");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is your goal worth?");
        int points = int.Parse(Console.ReadLine());
        return $"{goaltitle}#{description}#{points}#0";
    }
    private string makeAbasicGoal()
    {
        int done = 0;
        if(_done == true){
            done = 1;
        }

        return $"0#{_goaltitle}#{_goalDesription}#{_points}#{done}";
    }

    public static void writetofile(List<string> thebits, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string bit in thebits)
            {
                writer.WriteLine(bit);
            }
        }
    }
    
    public virtual Goal foodProcessing(string food)
    {
        string[] halfcooked = food.Split("#");
        string Goaltitle = halfcooked[1];
        string Desrciption = halfcooked[2];
        int Points = int.Parse(halfcooked[3]);
        return new Goal(Points, Desrciption, Goaltitle);
    }

    public bool IsDone()
    {
        return _done;
    }

    public void MarkAsDone()
    {
        _done = true;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetGoalTitle()
    {
        return _goaltitle;
    }

    public string GetGoalDescription()
    {
        return _goalDesription;
    }

    public static List<Goal> theFactory(string filename)
    {
        List<Goal> processedFood = new List<Goal>();
        List<string> unProcessedFood = new List<string>();

        if (File.Exists(filename))
        {
            unProcessedFood.AddRange(File.ReadLines(filename));
        }
        else
        {
            Console.WriteLine($"Error: The file '{filename}' does not exist.");
        }
        return theFactoryPart2(unProcessedFood);
    }

    public static List<Goal> theFactoryPart2(List<string> rawFood)
    {
        List<Goal> processedFood = new List<Goal>();
        // List<string> unProcessedFood = new List<string>();
        foreach (string goalline in rawFood)
        {
            string[] whatsHappening = goalline.Split("#");

            int imsickofcomingupwithnewnamesforthings = int.Parse(whatsHappening[0]);

            if (imsickofcomingupwithnewnamesforthings == 0)
            {
                Goal stuff = new Goal();
                processedFood.Add(stuff.foodProcessing(goalline));
            }
            else if (imsickofcomingupwithnewnamesforthings == 1)
            {
                Eternalgoal eternalgoal = new Eternalgoal();
                processedFood.Add(eternalgoal.foodProcessing(goalline));
            }
            else if (imsickofcomingupwithnewnamesforthings == 2)
            {
                ChecklistGoals checklistGoals = new ChecklistGoals();
                processedFood.Add(checklistGoals.foodProcessing(goalline));
            }
        }

        return processedFood;
    }
    

    protected virtual string turnToString()
    {

        return $"{makeAbasicGoal()}";
    }
    public static List<string> goalToStrings(List<Goal> goals)
    {
        List<string> goalStrings = new List<string>();
        foreach (Goal smallGoal in goals){
            string stuff = smallGoal.turnToString();
            goalStrings.Add(stuff);
        }


        return goalStrings;
    }
    public int pointCalc()
    {
        
        return 1;
    }


}
