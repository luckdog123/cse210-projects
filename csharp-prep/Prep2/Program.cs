using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the grade calculator! Today we will find out if your going to fail your class. What % do you have in your class?");
        int i_see_youre_drinking_two_percent = int.Parse(Console.ReadLine());
        string grade_letter = "A";
        string sign = "";
        int sign_logic = i_see_youre_drinking_two_percent % 10;
        if (sign_logic <= 3){
            sign = "-";
        }
        else if (sign_logic >= 7){
            sign = "+";
        }
        else{
            sign = " ";
        }
        if (i_see_youre_drinking_two_percent >= 90){
            grade_letter = "A";
            if (sign == "+"){
                sign = " ";
            }
        } 
        else if (i_see_youre_drinking_two_percent >= 80){
            grade_letter = "B";
        }
        else if (i_see_youre_drinking_two_percent >= 70){
            grade_letter = "C";
        }
        else if (i_see_youre_drinking_two_percent >= 60){
            grade_letter = "D";
        }
        else if (i_see_youre_drinking_two_percent < 60){
            grade_letter = "F";
            sign = "";
        }
        if (i_see_youre_drinking_two_percent >= 70)
        {
            Console.WriteLine($"Congrats! you are passing the class keep up the good work! Your letter grade is {grade_letter}{sign}");
        }
        else{
                        Console.WriteLine($"Welp you better pull it together you are not passing your class. whmop whomp. This is your current grade. {grade_letter}{sign}");

        } 
    }
}