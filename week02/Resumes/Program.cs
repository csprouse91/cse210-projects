using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new instance(object) of the Job class
        Job job1 = new Job();
        //Assign values to the member variables using the dot operator
        job1._company = "Total Directional Drilling Services";
        job1._jobTitle = "Directional Driller";
        job1._startYear = 2022;
        job1._endYear = 2024;

        //Create a new instance(object) of the Job class
        Job job2 = new Job();
        //Assign values to the member variables using the dot operator
        job2._company = "Bountiful City";
        job2._jobTitle = "Water Operator";
        job2._startYear = 2024;
        job2._endYear = 2025;


        //Create a new instance(object) of the Resume class
        Resume resume1 = new Resume();
        //Assign values to the member variables using the dot operator
        resume1._name = "Casey Sprouse";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //Call the DisplayResume method
        resume1.DisplayResume();

    }
}