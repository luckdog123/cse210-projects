using System;


class Circle{
    private double radius;

    public void SetRadius(double r){
        radius = r;
    }

    public double getArea(){
        double area = Math.PI * radius * radius;
        return area;
    }
}