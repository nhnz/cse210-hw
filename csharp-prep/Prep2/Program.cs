using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        Console.Write("What is your grade percentage? " );
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        string letter = "";

        if (percentage >= 90)
        {
             letter = ("A");
        }

        else if (percentage >=80 && percentage < 90)
        {
             letter = ("B");

        }

        else if (percentage >= 70 && percentage < 80)
        {
             letter = ("C");
        }

        else if (percentage >= 60 && percentage < 70)
        {
             letter = ("D");
        }

        else
        {
            letter = ("F");
        }
            
        
        Console.WriteLine($"You got {letter}");



            if (percentage> 70)
            {
                Console.WriteLine("Congratulations you got over 70% you have passed the class");
            }

            else
            {
                Console.WriteLine("Unfortunaley you had to get over 70% you did not make it you have to repeat the class");
            }
    }       

}