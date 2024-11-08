using System;

public class Program
{
    static void Main(string[] args)
    {

        BreathingActivity Breathing = new BreathingActivity();
        ReflectionActivity Reflection = new ReflectionActivity();
        ListingActivity Listing = new ListingActivity();


        string choice = "0";
        while (choice != "4")
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            choice = Console.ReadLine();

            
        
            if (choice == "1")
            {
                Breathing.Execute();
            }
            else if (choice == "2")
            {
                Reflection.Execute();
            }
            else if (choice == "3")
            {
                Listing.Execute();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

        }
    }

}
