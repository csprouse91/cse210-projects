using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1 Ask user for a magic number and convert to integer for conditions
        // Console.Write("What is the magic number? ");
        // string userInputNumber = Console.ReadLine();
        // int number = int.Parse(userInputNumber);

        // Step 2 Ask user for a guess and convert to integer for conditions
        // Console.Write("What is your guess? ");
        // string userInputGuess = Console.ReadLine();
        // int guess = int.Parse(userInputGuess);
        // while (guess != number)
        // {
        //     if (guess < number)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (guess > number)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed the magic number!");
        //     }
        // }

        // Step 3 Generate a random number between 1 and 100
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        // Try a do-while loop and ask for a guess as integer(instead of string then converting to integer)
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        } while (guess != number);
    }
}