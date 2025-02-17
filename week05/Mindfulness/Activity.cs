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
            int userInput = int.Parse(Console.ReadLine());
            if (userInput <= 0)
            {
                Console.WriteLine("Number of seconds must be greater than 0.");
            }
            else
            {
                try
                {
                    _duration = userInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number. ");
                }
            }
        } while (_duration <= 0);
        Console.Clear();
        Console.WriteLine($"Prepare to begin the {_name} activity for {_duration} seconds.");

    }

    //Method to display ending message
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Good job!");
        DisplayPauseAnimation(3);
        Console.WriteLine($"After {_duration} seconds, you have completed the {_name} activity. ");
        //pause for several seconds
        DisplayPauseAnimation(5);

    }

    //Method to display the countdown (timer)
    public void DisplayCountdown(int seconds)
    {
        do
        {
            Console.WriteLine("\b");
            Console.WriteLine($"{seconds}");
            seconds--;
            Thread.Sleep(1000);
            Console.WriteLine("\b\b");
        } while (seconds > 0);
    }

    //Method to display a pause animation
    public void DisplayPauseAnimation(int seconds)
    {
        do
        {
            Console.WriteLine(".");
            Thread.Sleep(250);
            Console.WriteLine("\b\b");
            Console.WriteLine("..");
            Thread.Sleep(250);
            Console.WriteLine("\b\b\b");
            Console.WriteLine("...");
            Thread.Sleep(250);
            Console.WriteLine("\b\b\b\b");
            Thread.Sleep(250);
            seconds--;

        } while (seconds > 0);
    }

}