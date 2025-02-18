using System;
//Added code in the reflection and listing activities to display the prompts and questions and remove them from the list
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
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;
            case 2: //User selects Reflection Activity
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                break;
            case 3: //User selects Listing Activity
                ListingActivity listing = new ListingActivity();
                // listing.Run();
                break;

        }

    }
}