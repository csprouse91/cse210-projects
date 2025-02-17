//Subclass of Activity
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    //New member variables
    private List<string> _prompts;
    private int _count;

    //Constructor
    public ListingActivity(string name = "Listing", string description = "", int duration = 0) : base(name, description, duration)
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

    
}