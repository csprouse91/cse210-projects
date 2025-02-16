//Subclass of Activity
using System;

public class ReflectionActivity : Activity
{
    //New member variables
    private List<string> _prompts;
    private List<string> _questions;

    //Constructor
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Reflection";
        _description = "During this activity, take time to reflect on the prompt. "
    }
}