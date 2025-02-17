//Subclass of Activity
using System;
using System.ComponentModel;

public class ReflectionActivity : Activity
{
    //New member variables
    private List<string> _prompts;
    private List<string> _questions;
    //New member variables to avoid duplicate random prompts and questions
    private List<string> _displayedPrompts;
    private List<string> _displayedQuestions;
    private bool _useQuestions = true;
    private bool _usePrompts = true;

    //Constructor
    public ReflectionActivity(string name = "Reflection", string description = "During this activity, you will be provided a prompt to focus and reflect on. You will then be asked a question to answer. You do not have to write anything down, just reflect on your experience. Recognize your power in life and the impact it can have. ", int duration = 0) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

        _prompts = new List<string>();
        _displayedPrompts = new List<string>();
        _questions = new List<string>();
        _displayedQuestions = new List<string>();
    }

    //Methods
    public string GetRandomPrompt()
    {
        //Searched for this code online to avoid duplicate random prompts
        if (_prompts.Count > 0 || _displayedPrompts.Count > 0)
        {
            if (_usePrompts && _prompts.Count > 0)
            {
                //Create a random index
                int randomIndex = new Random().Next(0, _prompts.Count);
                //Return the prompt at the random index
                return _prompts[randomIndex];
            }
            else if (!_usePrompts && _displayedPrompts.Count > 0)
            {
                //Create a random index
                int randomIndex = new Random().Next(0, _displayedPrompts.Count);
                //Return the prompt at the random index
                return _displayedPrompts[randomIndex];
            }
            else
            {
                return "No prompts available.";
            }

        }
        else
        {
            return "No prompts available.";
        }

    }

    public string GetRandomQuestion()
    {
        //Searched for this code online to avoid duplicate random questions
        if (_questions.Count > 0 || _displayedQuestions.Count > 0)
        {
            if (_useQuestions && _questions.Count > 0)
            {
                //Create a random index
                int randomIndex = new Random().Next(0, _questions.Count);
                //Return the question at the random index
                return _questions[randomIndex];
            }
            else if (!_useQuestions && _displayedQuestions.Count > 0)
            {
                //Create a random index
                int randomIndex = new Random().Next(0, _displayedQuestions.Count);
                //Return the question at the random index
                return _displayedQuestions[randomIndex];
            }
            else
            {
                return "No questions available.";
            }
        }
        else
        {
            return "No questions available.";
        }
    }

    //Display methods
    //This method will display the random prompt and then remove it from the list, add to displayed, and set
    //_usePrompts to false if the list is empty
    public void DisplayPrompt()
    {

        if (_usePrompts && _prompts.Count > 0)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"------{randomPrompt}------");
            foreach (string prompt in _prompts)
            {
                if (randomPrompt == prompt)
                {
                    _prompts.Remove(prompt);
                    _displayedPrompts.Add(prompt);
                }
            }
        }
        else if (_usePrompts && _prompts.Count == 0)
        {
            _usePrompts = false;
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"------{randomPrompt}------");
            foreach (string prompt in _displayedPrompts)
            {
                if (randomPrompt == prompt)
                {
                    _prompts.Add(prompt);
                    _displayedPrompts.Remove(prompt);
                }
            }
        }
        else if (!_usePrompts && _displayedPrompts.Count > 0)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"------{randomPrompt}------");
            foreach (string prompt in _displayedPrompts)
            {
                if (randomPrompt == prompt)
                {
                    _displayedPrompts.Remove(prompt);
                    _prompts.Add(prompt);
                }
            }
        }
        else if (!_usePrompts && _displayedPrompts.Count == 0)
        {
            _usePrompts = true;
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"------{randomPrompt}------");
            foreach (string prompt in _prompts)
            {
                if (randomPrompt == prompt)
                {
                    _displayedPrompts.Add(prompt);
                    _prompts.Remove(prompt);
                }
            }
        }


    }
    //This method will display the random question and then remove it from the list
    public void DisplayQuestion()
    {
        if (_useQuestions && _questions.Count > 0)
        {
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine($"------{randomQuestion}------");
            foreach (string question in _questions)
            {
                if (randomQuestion == question)
                {
                    _questions.Remove(question);
                    _displayedQuestions.Add(question);
                }
            }
        }
        else if (_useQuestions && _questions.Count == 0)
        {
            _useQuestions = false;
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine($"------{randomQuestion}------");
            foreach (string question in _displayedQuestions)
            {
                if (randomQuestion == question)
                {
                    _questions.Add(question);
                    _displayedQuestions.Remove(question);
                }
            }
        }
        else if (!_useQuestions && _displayedQuestions.Count > 0)
        {
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine($"------{randomQuestion}------");
            foreach (string question in _displayedQuestions)
            {
                if (randomQuestion == question)
                {
                    _displayedQuestions.Remove(question);
                    _questions.Add(question);
                }
            }
        }
        else if (!_useQuestions && _displayedQuestions.Count == 0)
        {
            _useQuestions = true;
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine($"------{randomQuestion}------");
            foreach (string question in _questions)
            {
                if (randomQuestion == question)
                {
                    _displayedQuestions.Add(question);
                    _questions.Remove(question);
                }
            }
        }
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
        //Get a count of the prompts and questions in each list before the activity begins
        //Display the start message
        DisplayStartMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        //Display prompt to reflect on
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("Reflect on the prompt for a few moments. Press enter to continue.");
        Console.Read();
        Console.WriteLine("Now ponder the following questions as they relate to your experience.");
        Console.WriteLine("Prepare to begin:");
        //Pause for several seconds
        DisplayPauseAnimation(5);
        Console.Clear();
        //Set timer                
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        do
        {
            DisplayQuestion();
            DisplayPauseAnimation(7);

            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        DisplayEndMessage();
    }
}