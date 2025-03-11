using System;

class Fraction
{   
    private int numerator;
    private int denominator;
    
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fraction(int WholeNumber)
    {
        numerator = WholeNumber;
        denominator = 1;
    }

    public Fraction(int Numerator, int Denominator)
    {
        numerator = Numerator;
        denominator = Denominator;
    }

    public int GetNumerator()
    {
        return numerator;
    }

    public int getDenominator()
    {
        return denominator;
    }

    public void Display()
    {
        Console.WriteLine($"Here it is again: {numerator}/{denominator}");
        Console.WriteLine("And here it is as a decimal: " + (double)numerator/denominator);
        Console.WriteLine("And here it is as a percentage: " + (double)numerator/denominator * 100 + "%");
    }

    public void Getuserinput()
    {

        Console.WriteLine("Enter your fraction:");
        string userInput = Console.ReadLine();
        string[] fraction = userInput.Split("/");
        numerator = int.Parse(fraction[0]);
        denominator = int.Parse(fraction[1]);

    }

    public string GetFractString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimal()
    {
        return (double)numerator/denominator;
    }

    
    
}