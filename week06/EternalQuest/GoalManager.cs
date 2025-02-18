//Class to handle goals of the game
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        //Create a menu
        Console.WriteLine("Welcome to Eternal Quest!");
        string userInput;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.Write("Please enter one of the options: ");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Creating a new goal");
                    CreateGoal();
                    break;
                case "2":
                    Console.WriteLine("Listing goals");
                    ListGoalNames();
                    break;
                case "3":
                    Console.WriteLine("Saving goals");
                    SaveGoals();
                    break;
                case "4":
                    Console.WriteLine("Loading goals");
                    LoadGoals();
                    break;
                case "5":
                    Console.WriteLine("Recording event");
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        } while (userInput != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            string listNumber = (_goals.IndexOf(goal) + 1).ToString();
            Console.WriteLine($"{listNumber}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            string listNumber = (_goals.IndexOf(goal) + 1).ToString();
            Console.WriteLine($"{listNumber}. {goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("There are three types of goals: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Please indicate the type of goal you want to create: ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal?");
        string goalName = Console.ReadLine();
        Console.Write("Give a short description of your goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("How many points is this goal worth?");
        string goalPoints = Console.ReadLine();
        if (goalType == "1")
        {
            Goal newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(newGoal);
        }
        else if (goalType == "2")
        {
            Goal newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(newGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times must you complete this goal to earn bonus points?");
            int target = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points do you want this to be?");
            int bonus = int.Parse(Console.ReadLine());
            Goal newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type");
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {
        
    }

    public void LoadGoals()
    {

    }
}