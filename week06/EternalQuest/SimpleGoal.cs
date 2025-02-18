//Subclass of Goal superclass
using System;

public class SimpleGoal : Goal
{
    //New Member Variable
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    //Methods

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}