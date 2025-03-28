using System;
using System.IO;
using System.Collections.Generic;

class Goal
{
    private int _points = 0;
    private string _goaltitle = "";
    private string _goalDesription = "";
    private bool _done;
    
    // private string _
    public Goal(int points, string goaltitle , string goalDesription)
    {
        _points = points;
        _goaltitle = goaltitle; 
        _goalDesription = goalDesription;
     

    }
    public Goal(int points, string goaltitle , string goalDesription, bool done)
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
    public virtual string makeAgoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string goaltitle = Console.ReadLine();
        Console.WriteLine("What is a short discription of your goal?");
        string desrciption = Console.ReadLine();
        Console.WriteLine("How many points is your goal worth?");
        int points = int.Parse(Console.ReadLine());
        return $"{goaltitle}#{desrciption}#{points}#0";
    }
    public static void writetofile(List<string> thebits, string filePath)
    {
        System.IO.File.WriteAllText(filePath , "");   
        foreach (string bit in thebits)
        {
            System.IO.File.AppendAllText(filePath ,bit);
        }
    }
    // public virtual bool GetDone(){return _done;}
    public virtual Goal foodProcessing(string food)
    {
        
        
        string[] halfcooked = food.Split("#");
        string Goaltitle = halfcooked[1];
        string Desrciption = halfcooked[2];
        int Points = int.Parse(halfcooked[3]);
        bool done;
        if (halfcooked[4] == "0")
        {
            done = false;
        }
        else
        {
            done = true;
        }
        return new Goal(Points ,Desrciption , Goaltitle);
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
            foreach(string goalline in unProcessedFood)
            {
                foreach(char i in goalline)
                {
                    if(i == 0)
                    {
                        Goal stuff = new Goal();
                        processedFood.Add(stuff.foodProcessing(goalline));
                    }
                    else if(i == 1)
                    {
                        Eternalgoal eternalgoal = new Eternalgoal();
                        processedFood.Add(eternalgoal.foodProcessing(goalline));
                    }
                    else if(i == 2)
                    {
                        ChecklistGoals checklistGoals = new ChecklistGoals();
                        processedFood.Add(checklistGoals.foodProcessing(goalline));
                    }
                    break;
        
                }

            }
            return processedFood;
    }


    public virtual void DisplayGoals(Goal goal, bool arewedone=false)
    {

    }


    
}