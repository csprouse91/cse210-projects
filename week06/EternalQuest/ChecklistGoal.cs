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
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amount) : base(name, description, points)
    {
        _amountCompleted = amount;
        _target = target;
        _bonus = bonus;
    }

    //Methods
    public override void RecordEvent()
    {
        int bonus = 0;
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            bonus = _bonus;
            Console.WriteLine($"Congratulations! You have earned {_points} points, and an additional {_bonus} bonus points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }


    }
    public override string GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return (_bonus + int.Parse(base.GetPoints())).ToString();//Change _points to int add together with _bonus then change back to string
        }
        else
        {
            return base.GetPoints();
        }
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
        return $"ChecklistGoal:{base.GetDetailsString()} - {_target} - {_bonus} - {_amountCompleted}";
    }
}