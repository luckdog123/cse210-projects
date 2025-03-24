 class Square : Shape{
    private double side;
    private string color;

    public void SetSide(double s){
        side = s;
    }

    public Square(double s,string c){
        color = c;
        side = s;
    }
    public override double getArea(){
        double area = side * side;
        return area;
    }
    public override string GetType()
    {
        return "square";
    }
    public override string whatColor(){
        return color;
    }

}