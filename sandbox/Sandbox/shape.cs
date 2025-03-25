class Shape
{
    private string color;
    // public Shape(string c)
    // {
    //     color = c;
    // }
    public virtual double getArea()
    {
        return 0;
    }
    public virtual string whatColor()
    {
        return color;
    }
    public virtual string GetType(){
        return "A shape";
    }
    
} 