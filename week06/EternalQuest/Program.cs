using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a menu
        Console.WriteLine("Welcome to Eternal Quest!");
        string userInput;
        GoalManager goalManager = new GoalManager();
        do
        {
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
                    goalManager.CreateGoal();
                    break;
                case "2":
                    Console.WriteLine("Listing goals");
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    Console.WriteLine("Saving goals");
                    goalManager.SaveGoals();
                    break;
                case "4":
                    Console.WriteLine("Loading goals");
                    goalManager.LoadGoals();
                    break;
                case "5":
                    Console.WriteLine("Recording event");
                    goalManager.RecordEvent();
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
}