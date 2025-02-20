using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        //Create Objects
        Activity running = new RunningActivity(new DateTime(2025, 02, 19), 25f, 2.1f);
        Activity cycling = new CyclingActivity(new DateTime(2025, 01, 27), 77f, 10f);
        Activity swimming = new SwimmingActivity(new DateTime(2024, 12, 25), 15f, 15f);

        //Create and add to a list of activities
        List<Activity> _activities = [running, cycling, swimming];//Changed from 3 separate .Add method lines to a list
        //Loop through the list and display the summary
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}