using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type the grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        if (gradePercent >= 90)
        {
            Console.WriteLine("Letter grade: A");
        }

        else if (gradePercent >= 80 && gradePercent < 90)
        {
            Console.WriteLine("Letter grade: B");
        }

        else if (gradePercent >=70 && gradePercent < 80)
        {
            Console.WriteLine("Letter grade: C");
        }

        else if (gradePercent >= 60 && gradePercent < 70)
        {
            Console.WriteLine("Letter grade: D");
        }

        else
        {
            Console.WriteLine("Letter grade: F");
        }

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