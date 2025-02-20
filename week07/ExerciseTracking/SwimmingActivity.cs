//subclass of Activity
using System;

public class SwimmingActivity : Activity
{
    private float _laps;//number of laps 50meters each

    //Constructor
    public SwimmingActivity(DateTime date, float duration, float laps) : base(date, duration)
    {
        _laps = laps;
    }
    //Getters
    public override float GetDistance()
    {
        return _laps * 50 / 1000 * 0.62f;//miles
    }
    public override float GetSpeed()
    {
        return GetDistance() / _duration * 60;//miles per hour
    }
    public override float GetPace()
    {
        return _duration / GetDistance();//minutes per mile
    }

    public override string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} Swimming ({_duration} min)-Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} min per mile");
    }
}