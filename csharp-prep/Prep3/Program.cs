using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Part 1 & 2
         
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int guessNumber = int.Parse(magicNumber);

        // Part 3 Random number generator
        Random randomGenertor = new Random();
        int choosenNumber = randomGenertor.Next(0,100);

        //Solution comparason
        //int guessNumber = -1;
        
        //The way I did it 
        Console.Write("What is your guess? ");
        string number = Console.ReadLine();
        int guessNumber = int.Parse(number);
        
        while (guessNumber != choosenNumber)
        {
            //Solution
            //Console.Write("What is your guess? ");
            //string number = Console.ReadLine();
            //guessNumber = int.Parse(number);

            if (guessNumber < choosenNumber)
            {
                Console.WriteLine("Higher");
                //The way I did it
                Console.Write("What is your guess? ");
                string number1 = Console.ReadLine();
                guessNumber = int.Parse(number1); 
            
            }

            else if (guessNumber > choosenNumber) 
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                string number1 = Console.ReadLine();
                guessNumber = int.Parse(number1);
            }

            //else
            //{
            //    Console.WriteLine("You Got It !!!!");
           // }

        Console.WriteLine("You Got It !!!!");

        }
    
    }

}