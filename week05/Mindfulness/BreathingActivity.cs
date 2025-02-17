//Subclass of Activity
using System;

public class BreathingActivity : Activity
{
    //No new member variables

    //Constructor
    public BreathingActivity(string name = "Breathing", string description = "During this activity, you will need to focus on your breathing. Follow the prompts and take deep breaths. Clear your mind and focus entirely on your breathing.", int duration = 0) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        DisplayStartMessage();
        //Set timer                
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        do
        {
            Console.Write("\nBreathe in...");
            DisplayCountdown(5);
            Console.Write("\nBreathe out...");
            DisplayCountdown(5);
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        DisplayEndMessage();
    }
}