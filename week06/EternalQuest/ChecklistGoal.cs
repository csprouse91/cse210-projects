//Subclass of Goal superclass
using System;

public class ChecklistGoal : Goal
{
    //New Member Variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //Methods
    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + " - " + _amountCompleted + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetDetailsString()} - {_amountCompleted} - {_target} - {_bonus}";
    }
}