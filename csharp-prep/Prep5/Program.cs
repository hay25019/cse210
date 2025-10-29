using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("Please enter the year you were born: ");
            birthYear = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return (int)Math.Pow(number, 2);
        }

        static void DisplayResult(string userName, int squareNumber, int birthYear)
        {
            DateTime currentDateTime = DateTime.Now;
            int turningAge = currentDateTime.Year - birthYear;
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
            Console.WriteLine($"{userName}, you will turn {turningAge} this year.");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber, birthYear);
    }
}