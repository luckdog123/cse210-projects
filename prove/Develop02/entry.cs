using System;

class Entry
{ 
    private string UserEntry;
    private string DaPrompt;
    private string DidYouWorkOut;
    private string WorkOutRutine;
    private string DateStuffs
    {
        get
        {
            DateTime theCurrentTime = DateTime.Now;
            return theCurrentTime.ToShortDateString();
        }
    }
    public void SetWorkOutRutine(string workOutRutine){
        WorkOutRutine = workOutRutine;
    }
    public void SetDidYouWorkOut(string didYouWorkOut){
        DidYouWorkOut = didYouWorkOut;
    }
     public void SetUserEntry(string userEntry)
    {
        UserEntry = userEntry;
    }    
    public void savePromptEntry(string prompt)
    {
        DaPrompt = prompt;
    }
    public void DisplayEntry()
    {
        if (DidYouWorkOut == "yes"){
            Console.WriteLine($"Date: {DateStuffs} Prompt: {DaPrompt} Entry: {UserEntry}\nWorkout Stats: {WorkOutRutine}");
        }
        else
        {
            Console.WriteLine($"Date: {DateStuffs} Prompt: {DaPrompt} Entry: {UserEntry}");
        }
    }
    public void writeToFile()
    {
        Console.WriteLine("Enter the file path to save to: ");
        string filePath = Console.ReadLine();
        if (DidYouWorkOut == "yes")
        {
            string textToWrite = $"Date: {DateStuffs} Prompt: {DaPrompt} Entry: {UserEntry}\nWorkout Stats: {WorkOutRutine}\n";
            System.IO.File.AppendAllText(filePath,textToWrite);
        }
        else
        {
            string textToWrite = $"Date: {DateStuffs} Prompt: {DaPrompt} Entry: {UserEntry}\n";
            System.IO.File.AppendAllText(filePath,textToWrite);
        }
    }

    public void readFromFile()    {
        Console.WriteLine("Enter the file path to read from: ");
        string filePath = Console.ReadLine();
        string textFromFile = System.IO.File.ReadAllText(filePath);
        Console.WriteLine(textFromFile);
    }
}