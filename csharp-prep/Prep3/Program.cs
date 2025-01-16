using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.WriteLine("Guess the magic number");
        int guess = 0;
        int numberOfGuesses = 0;
        do
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            numberOfGuesses++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

        } while (guess != magicNumber);

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Number of guesses: {numberOfGuesses}");
    }
}