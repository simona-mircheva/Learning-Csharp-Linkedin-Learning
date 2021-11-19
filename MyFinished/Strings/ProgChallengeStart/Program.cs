using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool keepGoing = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int numberGuesses = 0;
            int guess = 0;

            do
            {
                Console.WriteLine("What is your guess?");
                string guesses = Console.ReadLine();

                bool isNumber = Int32.TryParse(guesses, out guess);

                if (!isNumber)
                {
                    Console.WriteLine("That doesn't look like a number. Please try again.");
                }
                else
                {
                    if (guess == -1)
                    {
                        Console.WriteLine($"I was thinking of {theNumber}");
                        keepGoing = false;
                    }
                    else
                    {
                        numberGuesses++;
                        if (guess == theNumber)
                        {
                            Console.WriteLine($"You guessed right in {numberGuesses} steps!");
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("No, try a number {0} than that.", guess < theNumber ? "higher" : "lower");
                        }
                    }
                }
            }
            while (keepGoing);

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

        }
    }
}
