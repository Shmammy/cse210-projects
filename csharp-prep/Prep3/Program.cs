using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Magic Number: ");
        string magicNumberInput = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberInput);
        int guess = 0;
        do
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

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
    }
}