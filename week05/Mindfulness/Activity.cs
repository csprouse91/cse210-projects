//Super Class for all activites
using System;

public class Activity
{
    protected string _name;//name of the activity, a description, asks for and sets the duration in seconds, then tell user to prepare to begin and pause
    protected string _description;
    protected int _duration;//Should show some sort of animation to the user (spinner, countdown, periodic dots)

    //Constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //Method to display beginning message
    public void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to the " + _name + " activity!");
        Console.WriteLine(_description);
        Console.WriteLine("Please prepare to begin. ");
        //Pause for 3 seconds
        Console.WriteLine("3...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("2...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("1...");
        System.Threading.Thread.Sleep(1000);
    }

    //Method to display ending message
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Good job!");
        Console.WriteLine($"After {_duration} seconds, you have completed the {_name} activity. ");
        //Pause for 3 seconds and finishes the activity

    }

    //Method to display the countdown (timer)
    public void DisplayCountdown(int seconds)
    {
        while (seconds > 0)
        {
        }
    }

    //Method to display a pause animation
    public void DisplayPauseAnimation(int seconds)
    {

    }

}