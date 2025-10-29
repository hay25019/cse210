using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);
        Console.Write("What is your guess? ");
        string stringGuess = Console.ReadLine();
        int guess = int.Parse(stringGuess);
        if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}