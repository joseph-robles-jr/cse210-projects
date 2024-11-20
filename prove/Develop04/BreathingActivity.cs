public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _Name = "Breathing Activity";
        _Description = "This Activity will help you to relac by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
    }

    public void Execute() ///the override replaces the blank Method in the class we derived from.
    {
        Start(); // prints the initial start text to intorduce the activity and prompt for duration. 
        for (int i=0; i < _Duration / 2; i++) //Loops for the duration that is set.
        {
            Console.WriteLine("Breath in...");
            Thread.Sleep(3000);
            Console.WriteLine("Breath out...");
            Thread.Sleep(3000);   
        }

        End();
    }

}