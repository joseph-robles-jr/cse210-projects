using System;

public class Activity
{
    protected string _Name;
    protected string _Description;
    protected int _Duration;
     

    public void Start() // begin the activity
    { 
        Console.WriteLine($"Starting {_Name}");
        Console.WriteLine(_Description); 
        Console.Write("Enter the duration in seconds: "); 
        _Duration = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Prepare to begin..."); 
        Thread.Sleep(3000);
    }

    public void End() //End the activity
    {
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You have completed {_Name} for {_Duration} seconds.");
        Thread.Sleep(3000);

    }
}
