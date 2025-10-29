using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain;
        do
        {
            int number = randomGenerator.Next(1, 100);
            bool guessRight = false;
            while (guessRight == false)
            {
                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
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
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes" || playAgain == "Yes");
    }
}