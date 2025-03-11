using System;

class Fraction
{
    private int numerator;
    private int denominator;
    
    public void Display()
    {
        Console.WriteLine($"Here it is again: {numerator}/{denominator}");
        Console.WriteLine("And here it is as a decimal: " + (double)numerator/denominator);
        Console.WriteLine("And here it is as a percentage: " + (double)numerator/denominator * 100 + "%");
    }

    public void Getuserinput(){

        Console.WriteLine("Enter your fraction:");
        string userInput = Console.ReadLine();
        string[] fraction = userInput.Split("/");
        numerator = int.Parse(fraction[0]);
        denominator = int.Parse(fraction[1]);

        }



}