//subclass of Activity 
using System;

public class RunningActivity : Activity
{
    private float _distance;//miles


    //Constructor
    public RunningActivity(DateTime date, float duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    //Getters
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()//miles per hour
    {
        return _distance / _duration * 60;
    }
    public override float GetPace()//minutes per mile
    {
        return _duration / _distance;
    }

    public override string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} Running ({_duration} min)-Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} min per mile");
    }
}