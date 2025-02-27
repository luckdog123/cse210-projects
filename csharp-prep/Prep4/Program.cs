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
        foreach (int i in lystsTM){
            Console.Write(i + " ");
        }
        
    }
}