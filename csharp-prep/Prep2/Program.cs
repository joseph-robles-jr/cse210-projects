using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string stringPercentage = Console.ReadLine();
        int intPercentage = int.Parse(stringPercentage);


        string letter = "Unassigned";

        if (intPercentage >= 90)
        {
            letter = "A";   
        }

         else if (intPercentage < 90 && intPercentage >= 80)
        {
            letter = "B";   
        }

         else if (intPercentage < 80 && intPercentage >= 70)
        {
            letter = "C";   
        }

         else if (intPercentage < 70 && intPercentage >= 60)
        {
            letter = "D";   
        }

        else if (intPercentage < 60)
        {
            letter = "F";   
        }
        Console.WriteLine($"Your letter grade is {letter}");
        

        if (letter == "A" || letter == "B" || letter == "C" )
        {
            Console.WriteLine("Good job PASSING the course!!!");
        }

        if (!(letter == "A" || letter == "B" || letter == "C" ))
        {
            Console.WriteLine("Sorry, you FAILED the course!!");
        }


    }
}