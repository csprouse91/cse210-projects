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

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("There are three types of goals: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Please indicate the type of goal you want to create: ");
        string goalType = Console.ReadLine();
        Console.Write("What do you want to name your goal?");
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
            Console.Write("How many times do you want to do this to complete this goal?");
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