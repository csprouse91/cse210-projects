using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        //Create a new Square object
        Square square = new Square("Blue", 5.5f);
        Console.WriteLine($"Square Color: {square.GetColor()}");//Blue
        Console.WriteLine($"Square Area: {square.GetArea()}");//30.25
        //Create a new Rectangle object
        Rectangle rectangle = new Rectangle("Red", 6.6f, 4.4f);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");//Red
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");//29.04
        //Create a new Circle object
        Circle circle = new Circle("Green", 2.7f);
        Console.WriteLine($"Circle Color: {circle.GetColor()}");//Green
        Console.WriteLine($"Circle Area: {circle.GetArea()}");//22.90


        //Create a list to hold shapes
        List<Shape> _shapes = [square, rectangle, circle];
        //Iterate through the list
        //Print the color and area of each shape
        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetColor() + " " + shape.GetArea());
        }

    }
}