using System.Drawing;
using System.Net.NetworkInformation;

public class Circle : Shape {
    private double _radius;

    public Circle (string color, double radius) 
    : base (color) {
        _radius = radius;
    }

    public override double GetArea() {
        double pi = Math.PI;
        double sqr = Math.Pow(_radius, 2);
        return Math.Round(pi * sqr,2);
    }
}


