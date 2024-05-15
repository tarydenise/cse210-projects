using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userValue;

        do
        {
            Console.WriteLine("Enter number: ");

            userValue = int.Parse(Console.ReadLine());

            if (userValue != 0)
            {
                numbers.Add(userValue);
            }
            
        } while (userValue != 0);

        // Find Sum of list
        int sum = 0;
        
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Find Average of list
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // Find the max num of list
        int max = numbers.Max();

        Console.WriteLine($"The largest number is: {max}");
        



    }
}