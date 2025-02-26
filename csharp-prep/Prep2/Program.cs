using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the grade calculator! Today we will find out if your going to fail your class. What % do you have in your class?");
        int i_see_youre_drinking_two_percent = int.Parse(Console.ReadLine());
        string grade_letter = "A";
        int sign_logic = i_see_youre_drinking_two_percent % 10;
        if (sign_logic == 3){
            string sign = "-";
        }
        else if (sign_logic == 7){
            string sign = "+";
        }
        else{
            string sign = " ";
        }
         
        if (i_see_youre_drinking_two_percent <= 70)
        {
            Console.WriteLine($"Congrats! you are passing the class keep up the good work! Your letter grade is {grade_letter}{sign}");
        }
        else{
                        Console.WriteLine($"Welp you better pull it together you are not passing your class. whmop whomp. This is your current grade. {grade_letter}{sign}");

        } 
    }
}