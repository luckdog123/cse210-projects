using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
      //  List <Shape> lysts = new List<Shape>
      //  {
      //         new Circle(5,"red"),
      //         new Circle(6,"blue"),
      //         new Triangle(3,4,"green"),
      //         new Triangle(5,6,"yellow"),
      //         new Square(4,"orange"),
      //         new Square(5,"purple")
      //  };
       
      //    foreach(Shape s in lysts){
      //       string type = s.GetType();
      //         Console.WriteLine($"The area of the {s.whatColor()} {s.GetType()} is {s.getArea()}.");

      List<int> numbers = [1,2,3,4,5,6,7,8,9,10];
      List<int> evenNumbers = numbers.Where((x) => x % 2 == 0).ToList();
      foreach (int x in evenNumbers){
        Console.WriteLine(x);
      }
      // watch a video on how to use link or lambda functions!!!
    }
} 