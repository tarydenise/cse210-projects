using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); //choose random number
        int magicNumber = randomGenerator.Next(1, 101);
        
        int numberOfGuesses = 0; // set variable to count number of guesses after loop
        
        int userGuess; //define to use do-while loop

        do
        {
            Console.Write("What is your guess?");
            userGuess = int.Parse(Console.ReadLine());
            
            numberOfGuesses++; // adds a count number after each loop

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Wrong! Guess a lower number.");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Wrong! Guess a higher number.");
            }
            else
            {
                Console.WriteLine($"Correct! You guessed the magic number in {numberOfGuesses} tries.");
            }

        } while (userGuess != magicNumber);

    }
}