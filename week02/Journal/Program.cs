using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        //Declare input to initialize the while loop
        int input = 0;
        //While loop to run until the user inputs 5
        while (input != 5)
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
            input = int.Parse(Console.ReadLine());
            //If the user inputs 1
            if (input == 1)
            {
                //Create a new entry
                Entry newEntry = new Entry();
                //Populate the prompt generator with prompts from a file
                PromptGenerator newPromptGenerator = new PromptGenerator();
                string promptsFile = "prompts.txt";
                string[] lines = File.ReadAllLines(promptsFile);
                foreach (string line in lines)
                {
                    newPromptGenerator._prompts.Add(line);
                }
                Console.WriteLine("Prompts loaded from promptsFile");
                //Display a random entry prompt
                newEntry._promptText = newPromptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);

            }
            else if (input == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
