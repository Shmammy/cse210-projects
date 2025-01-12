using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type the grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }

        else if (gradePercent >= 80 && gradePercent < 90)
        {
            letter = "B";
        }

        else if (gradePercent >=70 && gradePercent < 80)
        {
            letter = "C";
        }

        else if (gradePercent >= 60 && gradePercent < 70)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Letter grade: {letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed the class! Great job!");
        }
        else
        {
            Console.WriteLine("Don't give up! Try again and you can do better next time!");
        }
        
    }
}