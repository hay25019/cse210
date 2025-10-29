using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool guessRight = false;
        while (guessRight == false)
        {
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
                guessRight = true;
            }
        }
    }
}