//Subclass of Shape Superclass
using System;

public class Square : Shape
{
    //New Member Variables
    private float _side;

    //Constructor
    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    //Override method to calculate area
    public override float GetArea()
    {
        return _side * _side;
    }
}