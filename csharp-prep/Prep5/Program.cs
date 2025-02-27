using System;

class Program
{
    static void Main(string[] args)
    {
        static float SquareDaNum(float favoritNumber){
            return favoritNumber * favoritNumber;   
        }
        static string getDaName(){
            Console.WriteLine("Hello stranger! Welcome to the program!!");
            Console.WriteLine("Now its time for us to get to know you what is your name?");
            string name  = Console.ReadLine();
            return name;
        } 
        static float getDaFavoriteNumber(){
            Console.WriteLine("What is your favortie number?");
            float favNum = float.Parse(Console.ReadLine());  
            return SquareDaNum(favNum);                      
        }
        static void finalState(string nam , float favnumnum){
            Console.WriteLine($"{nam} your favorite number squared is {favnumnum}.");
        }
        static void daFunction(){
            string nam = getDaName();
            float favnumnum = getDaFavoriteNumber();
            finalState(nam , favnumnum);
        }
        daFunction();
    }
}