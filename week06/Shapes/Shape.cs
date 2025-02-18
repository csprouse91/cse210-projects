//Superclass Shape
using System;

public class Shape
{
    //Member variable
    private string _color;

    //Getter and Setter for _color
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }


    //Constructor
    public Shape(string color)
    {
        _color = color;
    }

    //Virtual method to calculate area
    public virtual float GetArea()
    {
        return 0;
    }
}