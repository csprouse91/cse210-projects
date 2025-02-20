//subclass of Activity
using System;

public class CyclingActivity : Activity
{
    private float _speed;//miles per hour

    //Constructor
    public CyclingActivity(DateTime date, float duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }
    //Getters
    public override float GetDistance()//miles
    {
        return _speed * _duration / 60;
    }
    public override float GetSpeed()//miles per hour
    {
        return _speed;
    }
    public override float GetPace()//minutes per mile
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} Cycling ({_duration} min)-Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} min per mile");
    }
}