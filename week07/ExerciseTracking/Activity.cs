//Superclass to track the date and duration of each activity
using System;

public abstract class Activity
{
    protected DateTime _date;// date.ToString("dd MMM yyyy")
    protected float _duration;//minutes

    //Constructor
    public Activity(DateTime date, float duration)
    {
        _date = date;
        _duration = duration;
    }
    //Getters
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} Activity ({_duration} min)-Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile");
    }
    //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile


}