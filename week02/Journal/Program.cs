using System;
using System.Collections.Generic;
using System.IO;
//Added a loop to allow user to change the prompt
//Added a prompts file to load prompts from

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal App!");
        //Create a Journal 
        Journal journal = new Journal();
        //Declare input to initialize the while loop
        int input = 0;
        //While loop to run until the user inputs 5
        while (input != 5)
        {

            //Display the main menu
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
                // Console.WriteLine("Prompts loaded from promptsFile"); Commented out after verified
                //Display a random entry prompt
                newEntry._promptText = newPromptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                //Get the user's entry text
                Console.Write("Begin your entry(Enter will submit the entry - 0 and enter will change the prompt):\n> ");
                //Exceeding Requirements            Create a loop to allow the user to change the prompt 
                string newPrompt = Console.ReadLine();
                while (newPrompt == "0")
                {
                    newEntry._promptText = newPromptGenerator.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    //Get the user's entry text
                    Console.Write("Begin your entry(Enter will submit the entry - Enter 0 to change the prompt):\n> ");
                    newPrompt = Console.ReadLine();
                }
                newEntry._entryText = newPrompt;
                //Add the entry to the journal
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry saved!");
            }


            //If the user inputs 2
            else if (input == 2)
            {
                //Display all entries
                journal.DisplayAll();

            }

            //If the user inputs 3
            else if (input == 3)
            {
                //Save journal to a file
                string fileName = "userJournal.txt";
                journal.SaveToFile(fileName);
            }
            else if (input == 4)
            {
                Console.WriteLine("Reading from file...");

                //Load journal from file
                string fileName = "userJournal.txt";
                journal.LoadFromFile(fileName);
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
