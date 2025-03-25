using System;

class Program
{
    static void Main(string[] args)
    {
       List <Shape> lysts = new List<Shape>
       {
              new Circle(5,"red"),
              new Circle(6,"blue"),
              new Triangle(3,4,"green"),
              new Triangle(5,6,"yellow"),
              new Square(4,"orange"),
              new Square(5,"purple")
       };
       
         foreach(Shape s in lysts){
            string type = s.GetType();
              Console.WriteLine($"The area of the {s.whatColor()} {s.GetType()} is {s.getArea()}.");
         }
    }
} 