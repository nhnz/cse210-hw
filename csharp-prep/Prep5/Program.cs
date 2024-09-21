using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
        

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write($"Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int favoriteNumber = int.Parse(number);
            return favoriteNumber;
        }

         static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
        }
    

    }
}