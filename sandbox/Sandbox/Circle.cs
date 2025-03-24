


class Circle : Shape

{
    private double radius;
    private string color;

    public void SetRadius(double r){
        radius = r;
    }

    public Circle(double r,string c){
        color = c;
        radius = r;
    }
    public override double getArea(){
        double area = Math.PI * radius * radius;
        return area;
    }
    public override string GetType()
    {
        return "circle";
    }
    public override string whatColor(){
        return color;
    }
}