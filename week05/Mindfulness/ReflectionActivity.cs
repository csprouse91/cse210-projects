//Subclass of Activity
using System;
using System.Collections.Generic;

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
    //Method to move prompt from list to displayed list
    public void MoveToDisplayedPrompts(string prompt)
    {
        for (int index = 0; index < _prompts.Count; index++)
        {
            if (prompt == _prompts[index])
            {
                _prompts.Remove(prompt);
                _displayedPrompts.Add(prompt);
            }
        }
    }
    //Method to move prompt from displayed list to list
    public void MoveFromDisplayedPrompts(string prompt)
    {
        for (int index = 0; index < _displayedPrompts.Count; index++)
        {
            if (prompt == _displayedPrompts[index])
            {
                _displayedPrompts.Remove(prompt);
                _prompts.Add(prompt);
            }
        }
    }
    //Metho to move question from list to displayed list
    public void MoveToDisplayedQuestions(string question)
    {
        for (int index = 0; index < _questions.Count; index++)
        {
            if (question == _questions[index])
            {
                _questions.Remove(question);
                _displayedQuestions.Add(question);
            }
        }
    }
    //Method to move question from displayed list to list
    public void MoveFromDisplayedQuestions(string question)
    {
        for (int index = 0; index < _displayedQuestions.Count; index++)
        {
            if (question == _displayedQuestions[index])
            {
                _displayedQuestions.Remove(question);
                _questions.Add(question);
            }
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
            MoveToDisplayedPrompts(randomPrompt);
        }
        else if (_usePrompts && _prompts.Count == 0)
        {
            _usePrompts = false;
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"------{randomPrompt}------");
            MoveFromDisplayedPrompts(randomPrompt);
        }
        else if (!_usePrompts && _displayedPrompts.Count > 0)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"------{randomPrompt}------");
            MoveFromDisplayedPrompts(randomPrompt);
        }
        else if (!_usePrompts && _displayedPrompts.Count == 0)
        {
            _usePrompts = true;
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"------{randomPrompt}------");
            MoveToDisplayedPrompts(randomPrompt);
        }


    }
    //This method will display the random question and then remove it from the list
    public void DisplayQuestion()
    {
        if (_useQuestions && _questions.Count > 0)
        {
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine(randomQuestion);
            MoveToDisplayedQuestions(randomQuestion);
        }
        else if (_useQuestions && _questions.Count == 0)
        {
            _useQuestions = false;
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine(randomQuestion);
            MoveFromDisplayedQuestions(randomQuestion);
        }
        else if (!_useQuestions && _displayedQuestions.Count > 0)
        {
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine(randomQuestion);
            MoveFromDisplayedQuestions(randomQuestion);
        }
        else if (!_useQuestions && _displayedQuestions.Count == 0)
        {
            _useQuestions = true;
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine(randomQuestion);
            MoveToDisplayedQuestions(randomQuestion);
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
        AddQuestion("What did you learn from this that you can apply to other situations? ");
        AddQuestion("What would you do differently next time?");
        AddQuestion("What advice would you give to yourself, if you were able to in that situation?");
        AddQuestion("What did you learn about yourself?");
        //Display the start message
        DisplayStartMessage();

        //Set timer                
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        do
        {
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
            do
            {
                DisplayQuestion();
                Console.WriteLine();
                DisplayPauseAnimation(5);
                currentTime = DateTime.Now;
            } while (_useQuestions || currentTime < futureTime);
        } while (currentTime < futureTime);

        DisplayEndMessage();
    }
}