//Class to handle goals of the game
using System.Collections.Generic;
using System.IO;
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
                    Console.WriteLine("Creating a new goal...");
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
                    if (goalType == "3")
                    {
                        Console.Write("How many times must you complete this goal to earn bonus points?");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("How many bonus points do you want this to be?");
                        int bonus = int.Parse(Console.ReadLine());
                        CreateGoal(goalType, goalName, goalDescription, goalPoints, false, target, bonus);
                        break;
                    }
                    else
                    {
                        CreateGoal(goalType, goalName, goalDescription, goalPoints);
                        break;
                    }
                case "2":
                    Console.WriteLine("Listing goals...");
                    ListGoalDetails();
                    break;
                case "3":
                    Console.WriteLine("Saving goals...");
                    SaveGoals();
                    break;
                case "4":
                    Console.WriteLine("Loading goals..");
                    LoadGoals();
                    break;
                case "5":
                    Console.WriteLine("Recording event...");
                    ListGoalNames();
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting... Goodbye!");
                    Thread.Sleep(1000);
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
            string listNumber = (_goals.IndexOf(goal) + 1).ToString();//Googled this line of code
            if (goal.IsComplete())
            {
                Console.WriteLine($"{listNumber}. [x] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{listNumber}. [ ] {goal.GetDetailsString()}");
            }
        }
    }
    public void CreateGoal(string type, string name, string description, string points, bool isComplete = false, int amount = 0, int target = 0, int bonus = 0)
    {


        if (type == "1" || type == "SimpleGoal")
        {
            Goal newGoal = new SimpleGoal(name, description, points, isComplete);
            _goals.Add(newGoal);
        }
        else if (type == "2" || type == "EternalGoal")
        {
            Goal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (type == "3" || type == "ChecklistGoal")
        {

            Goal newGoal = new ChecklistGoal(name, description, points, amount, target, bonus);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type");
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int userGoalSelect = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[userGoalSelect - 1];
        selectedGoal.RecordEvent();//Potentially alter value of _points in ChecklistGoal
        _score += int.Parse(selectedGoal.GetStringRepresentation().Split(" - ")[2]);//Trying to get the points from the string representation

    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save the goals to (include .txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            //Ex: GoalType:GoalName - GOalDescription - Goalpoints - isComplete - amountCompleted - target - bonus
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string[] goalDetails = parts[1].Split(" - ");
            string name = goalDetails[0];
            string description = goalDetails[1];
            string points = goalDetails[2];//Leave as a string for the calculation in RecordEvent
            bool isComplete;
            int amount;
            int target;
            int bonus;
            if (goalType == "SimpleGoal")
            {
                isComplete = bool.Parse(goalDetails[3]);//Looked up this conversion from string to bool
                CreateGoal(goalType, name, description, points, isComplete);
            }
            else if (goalType == "ChecklistGoal")
            {
                bonus = int.Parse(goalDetails[3]);
                amount = int.Parse(goalDetails[4]);
                target = int.Parse(goalDetails[5]);
                CreateGoal(goalType, name, description, points, bonus, amount, target, false);
            }
            else if (goalType == "EternalGoal")
            {
                CreateGoal(goalType, name, description, points);
            }
            else
            {
                _score = int.Parse(goalType);
            }




        }
    }
}