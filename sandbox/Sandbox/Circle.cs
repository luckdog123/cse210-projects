


class Circle : Shape

{
    private double radius;

    public void SetRadius(double r){
        radius = r;
    }

    public override double getArea(){
        double area = Math.PI * radius * radius;
        return area;
    }
}