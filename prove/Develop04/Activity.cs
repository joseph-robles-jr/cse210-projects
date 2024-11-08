using System;

public class Activity
{
    public string Name;
    public string Description;
    public int Duration;
     

    public void Start() // begin the activity
    { 
        Console.WriteLine($"Starting {Name}");
        Console.WriteLine(Description); 
        Console.Write("Enter the duration in seconds: "); 
        Duration = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Prepare to begin..."); 
        Thread.Sleep(3000);
    }

    public void End() //End the activity
    {
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You have completed {Name} for {Duration} seconds.");
        Thread.Sleep(3000);

    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This Activity will help you to relac by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
    }

    public void Execute() ///the override replaces the blank Method in the class we derived from.
    {
        Start(); // prints the initial start text to intorduce the activity and prompt for duration. 
        for (int i=0; i < Duration / 2; i++) //Loops for the duration that is set.
        {
            Console.WriteLine("Breath in...");
            Thread.Sleep(3000);
            Console.WriteLine("Breath out...");
            Thread.Sleep(3000);   
        }

        End();
    }

}


public class ReflectionActivity : Activity
{

    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did somthing realy difficult.",
        "Think of a time when you helped somone in need.",
        "Think of a time when you did somthing truly selfless"
    };

    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different that other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How an you keep this experience in mind in the future?"
    };

        public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "This activity will help you to reflect on times in you rlife when you have shown strength.";
    }

    public void Execute()
    {
        Start();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]); // find the lenth of the primpts list, pick a random one in that list and print it.

        for (int i = 0; i< Duration / 10; i++)
        {
            Console.WriteLine(Questions[random.Next(Questions.Count)]); // Random number between list lenght and 0, prints entry to console.

            Thread.Sleep(5000);
            
        }

        End();
    }
}


public class ListingActivity : Activity
{

    private List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you to reflect on the good things in your life by having you list as many things as you can.";
    }

    public void Execute()
    {
        Start();
        Random random = new Random();

        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);

        Thread.Sleep(3000);
        Thread.Sleep(3000);

        Console.WriteLine("Start Listing!");
        Console.ReadLine();
       Thread.Sleep(Duration);
       End();
    }

}
