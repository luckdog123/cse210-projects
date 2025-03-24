using System.Runtime.InteropServices;

class Triangle : Shape
{
    private double side1;
    private double side2;
    private string color;
    public Triangle(double s, double s2,string c){
        color = c;
        side1 = s;
        side2 = s2;
    }
    public override double getArea(){
        double area = side1 * side2 ;
        // Console.WriteLine( $"{side1} , {side2}" );
        // Console.WriteLine(area);
        return area/2;
    }
    public override string whatColor(){
        return color;
    }
    public override string GetType()
    {
        return "triangle";
    }
    
 }