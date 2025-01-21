using System;

//A code template for the Jobs class
//The responsibility of this class is to hold and display information about each job

public class Job
{
    //Member variables for the Job class starting with _underscore and lowercase
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    //Constructor for the Job class
    public Job()
    {
    }

    //Method to display the job information in format: "JobTitle (Company) StartYear-EndYear"
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}