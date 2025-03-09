using System;

class Entry
{
    private string UserEntry;
    private string DaPrompt;


    private string DateStuffs
    {
        get
        {
            DateTime theCurrentTime = DateTime.Now;
            return theCurrentTime.ToShortDateString();
        }
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
        Console.WriteLine($"Date: {DateStuffs} Prompt: {DaPrompt} Entry: {UserEntry}");
    }
    public void writeToFile()
    {
        Console.WriteLine("Enter the file path to save to: ");
        string filePath = Console.ReadLine();
        string textToWrite = $"Date: {DateStuffs} Prompt: {DaPrompt} Entry: {UserEntry}";
        System.IO.File.WriteAllText(filePath, textToWrite);
    }
    public void readFromFile()
    {
        Console.WriteLine("Enter the file path to read from: ");
        string filePath = Console.ReadLine();
        string textFromFile = System.IO.File.ReadAllText(filePath);
        Console.WriteLine(textFromFile);
    }
}    