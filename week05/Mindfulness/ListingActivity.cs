//Subclass of Activity
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    //New member variables
    private List<string> _prompts = new List<string>();
    private int _count;

    //Constructor
    public ListingActivity(string name = "Listing", string description = "This activity will help you reflect on good things, and have you list as many things as you can in response to the prompt.", int duration = 0) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //Methods
    public string GetRandomPrompt()
    {
        //Create a random index
        int randomIndex = new Random().Next(0, _prompts.Count);
        //Return the prompt at the random index
        return _prompts[randomIndex];
    }

    public void DisplayRandomPrompt()
    {
        Console.WriteLine("Consider this prompt: \n" + GetRandomPrompt());
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void Run()
    {
        //Add prompts to the list
        AddPrompt("What are some personal strengths?");
        AddPrompt("What are some things you are grateful for?");
        AddPrompt("When have you felt the Holy Ghost?");
        AddPrompt("Who do you look up to?");

        //Display the start message
        DisplayStartMessage();
        //Set timer                
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        DisplayRandomPrompt();
        Console.Write("\nPrepare to begin listing...");
        DisplayCountdown(5);
        currentTime = DateTime.Now;
        Console.WriteLine("Begin listing...");
        while (currentTime < futureTime)
        {
            Console.ReadLine();
            _count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndMessage();
    }

}