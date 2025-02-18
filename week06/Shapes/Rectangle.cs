//Subclass of Shape Superclass
using System;

public class Rectangle : Shape
{
    //New Member Variables
    private float _length;
    private float _width;

    //Constructor
    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //Override method
    public override float GetArea()
    {
        return _length * _width;
    }
}