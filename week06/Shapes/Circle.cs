//Subclass for Shape superclass
using System;

public class Circle : Shape
{
    //New Member Variables
    private float _radius;

    //Constructor
    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    //Override method
    public override float GetArea()
    {
        return (float)Math.Round(Math.PI * (_radius * _radius), 2);
    }
}