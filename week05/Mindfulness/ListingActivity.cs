//Subclass of Activity
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    //New member variables
    private List<string> _prompts;
    private int _count;

    //Constructor
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Listing";
        _description = "";
        _duration = duration;
    }
}