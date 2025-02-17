using System;

class Program
{
    static void Main(string[] args)
    {
        //Menu to select activity
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select an activity: ");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Motivation");
        Console.WriteLine("5. Exit");
        //User input
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1: //User selects Breathing Activity
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.Run();
                break;
        }
              
    }
}