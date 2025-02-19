//Subclass of Goal superclass
using System;
using System.IO;

public class ChecklistGoal : Goal
{
    //New Member Variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor
    public ChecklistGoal(string name, string description, string points, int bonus, int target, int amount = 0) : base(name, description, points)
    {
        _amountCompleted = amount;
        _target = target;
        _bonus = bonus;
    }

    //Methods
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points = (int.Parse(_points) + _bonus).ToString();//Used AI to generate this line of code
        }
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + " - " + _amountCompleted + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetDetailsString()} - {_bonus} - {_amountCompleted} - {_target}";
    }
}