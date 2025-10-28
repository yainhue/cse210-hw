using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the 'Guess my Number' Game!");
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 100);
        bool HasWon = false;

        while (HasWon == false)
        {
        Console.WriteLine("What is your guess?");
        string Guess = Console.ReadLine();
        int IntGuess = int.Parse(Guess);
        
            if (IntGuess == MagicNumber)
            {
                Console.WriteLine("You've guessed it!");
                Console.WriteLine($"The Magic Number was: {MagicNumber}");
                HasWon = true;
            }
            else if (IntGuess > MagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (IntGuess < MagicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}