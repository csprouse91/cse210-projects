using System;
//Add reference to use lists in C#
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Display a prompt to create a list of numbers
        Console.WriteLine("Please enter a number to be added to a list. Enter 0 when you are done. ");

        // Create a list to store the numbers
        List<int> numbers = new List<int>();

        //Loop to add numbers to the list from user input
        int userNumber = -1;
        do
        {
            Console.Write("Enter a number: ");
            // Read the user input and add it to the list
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        // Core 1: Compute the sum, or total, of the numbers in the list and display it to the user.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        //Core 2: Compute the average and display it to the user.
        float avgOfNumbers = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avgOfNumbers}");
        //Core 3: Compute the maximum number in the list and display them to the user.
        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The maximum number is: {maxNumber}");
    }
}