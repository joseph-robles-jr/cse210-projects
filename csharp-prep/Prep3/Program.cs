using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)

    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
           
        int intNum = -100;
        while (intNum != magicNumber) 
        {
            Console.Write("What is the magic number?: ");
            string readNumber = Console.ReadLine();
            intNum = int.Parse(readNumber);
            
            if (magicNumber > intNum)
            {
                Console.WriteLine("Higher!");
            }
            else if (magicNumber < intNum)
            {
                Console.WriteLine("Lower!");
            }
        }

        if (intNum == magicNumber) 
        {
            Console.WriteLine("Congrats! That is the right number!");
        }  


    }  
}