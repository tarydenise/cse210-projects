using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your grade percentage? ");
        string userValue = Console.ReadLine();
        int percentage = int.Parse(userValue);

        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remainder =  percentage % 10;
        string sign = "";
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (percentage >= 100)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else if (percentage < 54)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Current grade: {letter}" + sign);

        if (percentage > 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass this time. Better luck next time!");
        }
    }
}