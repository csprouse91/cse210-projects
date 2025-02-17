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
        _description = "During this activity, you will be provided a prompt to focus and reflect on. You will then be asked a question to answer. You do not have to write anything down, just reflect on your experience. Recognize your power in life and the impact it can have. ";
        _duration = duration;
    }
}