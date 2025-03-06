using System;
using System.Collections.Generic;

class Prompts
{
    // private int _refNumber;

   

    Dictionary<int, string> journalPrompts = new Dictionary<int, string>
    {
        { 1, "What was the best food that you ate today?" },
        { 2, "What was the happiest moment of today?" },
        { 3, "How did you see the hand of God today?" },
        { 4, "What was the strongest emotion that you felt today?" },
        { 5, "Describe the moment that you laughed the hardest" },
        { 6, "What was the best rock climb that you sent or tried today?" },
        { 7, "What were you most grateful for today?" },
        { 8, "What frustrated you the most from today?" },
        { 9, "What is something that you learned about yourself or someone else today?" },
        { 10, "How could you repent from today?" }
    };

    //  public Prompts(int num)
    // {
    //     _refNumber = num;
    // }
     public string GetPrompt(int num)
    {
        return journalPrompts[num];  
    }
}
   

