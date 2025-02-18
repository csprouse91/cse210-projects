using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a menu
        Console.WriteLine("Welcome to Eternal Quest!");
        string userInput;
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Please enter one of the options: ");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Creating a new goal");
                    break;
                case "2":
                    Console.WriteLine("Listing goals");
                    break;
                case "3":
                    Console.WriteLine("Saving goals");
                    break;
                case "4":
                    Console.WriteLine("Loading goals");
                    break;
                case "5":
                    Console.WriteLine("Recording event");
                    break;
                case "6":
                    Console.WriteLine("Exiting");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        } while (userInput != "6");

    }
}