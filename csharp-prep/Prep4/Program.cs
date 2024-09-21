using System;
using System.Globalization;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int choosenNumber = 999999999;

        List<int> numbers = new List<int>();

        while (choosenNumber > 0)
            {
            
            Console.Write("Enter Number (0 to quit): ");
            string number = Console.ReadLine();
            choosenNumber = int.Parse(number);

            if (choosenNumber==0)
            {
                break;
            }
            
            numbers.Add(choosenNumber);
            
            }

        //Console.WriteLine("Numbers entered: " + string.Join(", ", numbers));

        //total sum
        int totalSum = 0;

        foreach (int num in numbers)
        {
            totalSum += num; 
        }

        Console.WriteLine($"Sum of the numbers: {totalSum}");  

        //Calculate Average
    
        if (numbers.Count > 0)
        {
            int average = totalSum / numbers.Count;
            Console.WriteLine($"Average of the numbers: {average}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

            //Find the largest number
        if (numbers.Count > 0)
        {
            int maximum = numbers[0];

            foreach (int num in numbers)
            {
                if (num > maximum)
                {
                    maximum = num; 
                }
            }

            Console.WriteLine($"Maximum number: {maximum}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

        
    }
}