//Subclass of Goal superclass
using System;

public class EternalGoal : Goal
{
    //No New Member Variables

    //Constructor
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    //Methods
   
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetDetailsString()}";
    }


}