using System;


class Cylinder
{
    private double height;

    private Circle c;

    public Cylinder(double h , Circle c){
        height = h; 
        circle = c;

    }

    double getVolume(){
        double volume = height * circle.GetArea();
        return volume;
    }

}

