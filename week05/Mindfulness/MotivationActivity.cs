using System;
using System.Collections.Generic;

//Subclass of Activity
public class MotivationActivity : Activity
{
    //New member variables
    private List<string> _quotes;
    private int _count;

    //Constructor 
    public MotivationActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Motivation";
        _description = "";
        _duration = duration;
    }

    public void Run()
    {
    }

    //Get random quote
    public void GetRandomQuote()
    {

    }
    //Display quote
    public void DisplayQuote()
    {

    }



}