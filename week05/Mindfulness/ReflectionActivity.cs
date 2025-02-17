//Subclass of Activity
using System;

public class ReflectionActivity : Activity
{
    //New member variables
    private List<string> _prompts;
    private List<string> _questions;

    //Constructor
    public ReflectionActivity(string name = "Reflection", string description = "During this activity, you will be provided a prompt to focus and reflect on. You will then be asked a question to answer. You do not have to write anything down, just reflect on your experience. Recognize your power in life and the impact it can have. ", int duration = 0) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

        _prompts = new List<string>();
        _questions = new List<string>();
    }

    //Methods
    public string GetRandomPrompt()
    {
        //Create a random index
        int randomIndex = new Random().Next(0, _prompts.Count);
        //Return the prompt at the random index
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        //Create a random index
        int randomIndex = new Random().Next(0, _questions.Count);
        //Return the question at the random index
        return _questions[randomIndex];
    }

    //Display methods
    public void DisplayPrompt()
    {
        Console.WriteLine($"------{GetRandomPrompt()}------");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    //Method to add prompts
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    //Method to remove prompts
    public void RemovePrompt(int index)
    {
        _prompts.RemoveAt(index);
    }
    //Method to add questions
    public void AddQuestion(string question)
    {
        _questions.Add(question);
    }
    //Method to remove questions
    public void RemoveQuestion(int index)
    {
        _questions.RemoveAt(index);
    }




    public void Run()
    {
        //Add string objects to the list<string> called _prompts
        AddPrompt("Think of a time you accomplished a difficult task.");
        AddPrompt("Reflect on a time you helped someone in need.");
        AddPrompt("Think of a time when you stood up for someone else.");
        AddPrompt("Think of something you are proud of.");
        AddPrompt("Think of a time you made a mistake and learned from it.");
        //Add string objects to the list<string> called _questions
        AddQuestion("Why was this experience meaningful to you?");
        AddQuestion("Have you ever been in a similar situation?");
        AddQuestion("What was the first thing you thought of?");
        AddQuestion("How did you feel during this experience?");
        AddQuestion("What did you learn from this that you can apply to other situations? ");
        AddQuestion("What made this experience unique?");
        AddQuestion("What would you do differently next time?");
        AddQuestion("What advice would you give to yourself, if you were able to in that situation?");
        AddQuestion("What did you learn about yourself?");
        DisplayStartMessage();
        //Pause for a few seconds
        DisplayPauseAnimation(3);
        //Set timer                
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        do
        {
            DisplayPrompt();
            Console.WriteLine("Reflect on the prompt for a few moments. Press enter to continue.");
            string userInput = Console.Read()

            DisplayCountdown(5);
            DisplayCountdown(5);
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        DisplayEndMessage();
    }
}