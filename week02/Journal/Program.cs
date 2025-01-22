using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Display the main menu
        Console.WriteLine("Welcome to the Journal App!");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. New Entry");
        Console.WriteLine("2. View Journal");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Exit");
        //Get the user's input
        Console.Write("Enter your choice: ");
        int input = int.Parse(Console.ReadLine());
        //Create a prompt generator
        PromptGenerator newPromptGenerator = new PromptGenerator();
        //Populate the prompt generator with prompts from a file
        string promptsFile = "prompts.txt";

        //Do while loop to run until the user inputs 5
        do
        {
            //If the user inputs 1
            if (input == 1)
            {
                //Create a new entry
                Entry newEntry = new Entry();
                //Populate the prompt generator with prompts from a file
                newPromptGenerator._prompts = System.IO.File.ReadAllLines("prompts.txt");
                //Display a random entry prompt
                newEntry._promptText = newPromptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
            }
        } while (input != 5);
    }
}