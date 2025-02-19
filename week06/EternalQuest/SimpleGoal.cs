//Subclass of Goal superclass
using System;

public class SimpleGoal : Goal
{
    //New Member Variable
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string name, string description, string points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    //Methods

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earened {_points} points!");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetDetailsString()} - {_isComplete}";
    }
}