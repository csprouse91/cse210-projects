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
        Console.WriteLine($"Please enter how long you wish this activity to last in seconds: ");
        do
        {
            string userInput = Console.ReadLine();
            int duration = int.Parse(userInput);
            if (duration <= 0)
            {
                Console.WriteLine("Please enter a valid number for the duration in seconds: ");
            }
        } while (_duration != );

        Console.WriteLine("Please prepare to begin. ");
    }

    //Method to display ending message
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Good job!");
        Console.WriteLine($"After {_duration} seconds, you have completed the {_name} activity. ");
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