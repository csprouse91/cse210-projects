using System;
using System.Collections.Generic;

//A code template for the Resume class
//The responsibility of this class is to keep track of the person's name and a list of their jobs

public class Resume
{
    //Member variables 
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Constructor for the Resume class
    public Resume()
    {

    }

    //Method to display the person's name and their job information
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}