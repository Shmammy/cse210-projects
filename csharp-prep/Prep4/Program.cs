using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberInput = 1;
        
        while (numberInput != 0)
        {
            Console.Write("Enter number: ");
            numberInput = int.Parse(Console.ReadLine());
            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }

        int sum = numbers.Sum();
        double average = numbers.Average();

        int highestNumber = numbers[0];
        int lowestPositiveNum = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > highestNumber)
            {
                highestNumber = number;
            }
            if (number > 0 && number < lowestPositiveNum)
            {
                lowestPositiveNum = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highestNumber}");
        Console.WriteLine($"The lowest positive number is: {lowestPositiveNum}");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}