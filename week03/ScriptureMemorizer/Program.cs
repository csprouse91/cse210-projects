using System;
using System.Collections.Generic;

//===============================Exceed Requirements===============================
//Added Console.WriteLine to display the hidden word to verify that all words matching the random index are hidden(the same word)
//Try and catch block to handle non-integer input
//Added if else statement to handle randomIndex if the word is already hidden. If the word is already hidden, select another word

//Clear console screen before calling methods to show hidden words for verification
//Clear console screen after  calling methods to match the example video

class Program
{
    static void Main(string[] args)
    {
        //Store a scripture
        Reference reference1 = new Reference("Alma", 37, 37);
        Scripture scripture1 = new Scripture(reference1, "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");

        //Accomodate scripture with multiple verses
        Reference reference2 = new Reference("D & C", 82, 9, 10);
        Scripture scripture2 = new Scripture(reference2, "Or in other words, I give unto you directions how you may act before me, that it may turn to you for your salvation. I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");
        //Clear the console screen and display the scripture reference and text
        do
        {
            //Display the scripture reference and text with hidden words (same length as original word with underscores)
            Console.WriteLine(scripture1.DisplayText());
            //Prompt user to press enter or type quit
            Console.WriteLine("Press enter to hide a word, or a number and enter to hide that number of words, or 'quit' to exit the program.");
            //Display hidden words
            string userInput = Console.ReadLine();
            //If user types quit, exit the program
            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Exiting program...");
                return;
            }
            //If user presses enter, hide a random word
            else if (userInput == "")
            {
                Console.Clear();

                scripture1.HideWords(1);
            }
            //If user types a number and presses enter, hide that number of words
            else try
                {
                    Console.Clear();

                    int wordsToHide = int.Parse(userInput);
                    scripture1.HideWords(wordsToHide);
                }
                catch (FormatException)//If the user types a non-integer, display this error message
                {
                    Console.Clear();//Clear console before displaying error message
                    Console.WriteLine("---------------------Invalid input---------------------");
                }
        } while (scripture1.AllWordsHidden() == false);

        Console.WriteLine(scripture1.DisplayText());//Display the scripture text with all words hidden
        //When all words are hidden, end the program
        Console.WriteLine("All words are hidden. Exiting program...");
        return;

    }
}