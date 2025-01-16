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
        Console.WriteLine($"The sum is: {sum}");
    }
}