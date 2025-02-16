//Subclass of Activity
using System;

public class BreathingActivity : Activity
{
    //No new member variables

    //Constructor
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Breathing";
        _description = "During this activity, you will need to focus on your breathing. Follow the prompts and take deep breaths. Clear your mind and focus entirely on your breathing.";
        _duration = duration;
    }

    
}