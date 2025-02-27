using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> lystsTM = [];
        string user_input = "Go";

        Console.WriteLine("Hello welcome to the lystsTM. Please input the numbers you disire. Hit enter after each entry, and when you are done type 'DONE'.");
        do{
            user_input = Console.ReadLine();
            if (user_input != "DONE"){
                lystsTM.Add(int.Parse(user_input));
            }
        } while (user_input != "DONE");

        int total = 0;
        foreach(int num in lystsTM){
            total = total + num;
        }
        Console.WriteLine($"Here is the total {total}.");
        Console.WriteLine($"Here is the advrage value {total / lystsTM.Count}");
        
        // foreach (int i in lystsTM){
        //     Console.Write(i + " ");
        // }
        
    }
}