using System;

class Program
{
    static void Main(string[] args)
    {
        //Test Assignment Class
        Assignment simpleAssignment = new Assignment("John Doe", "Testing Sample Topic");
        Console.WriteLine(simpleAssignment.GetSummary());//John Doe  -Testing Sample Topic

        //Test MathAssignment Class
        MathAssignment sampleMathAssignment = new MathAssignment("Jane Doe", "MathAssignment Topic", "12.3", "7-9, 12-14");
        Console.WriteLine(sampleMathAssignment.GetSummary());//Jane Doe - MathAssignment Topic
        Console.WriteLine(sampleMathAssignment.GetHomeWorkList());//Section 12.3 Problems 7-9, 12-14ls

        //Test WritingAssignment Class
        WritingAssignment sampleWritingAssignment = new WritingAssignment("Raiden Doe", "WritingAssignment Topic", "The Best Way to Write");
        Console.WriteLine(sampleWritingAssignment.GetSummary());//Raiden Doe - WritingAssignment Topic
        Console.WriteLine(sampleWritingAssignment.GetWritingInfo());//The Best Way to Write by Raiden Doe
    }
}