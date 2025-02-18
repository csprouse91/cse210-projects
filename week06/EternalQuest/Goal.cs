//Superclass for all goals
using System;

public abstract class Goal
{
    //Member variables
    private string _shortName;
    private string _description;
    private string _points;

    //Constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Methods
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return _shortName + " - " + _description + " - " + _points;
    }
    //Added GetName method 
    public string GetName()
    {
        return _shortName;
    }

    public abstract string GetStringRepresentation();

}