public class ListingActivity : Activity
{

    protected List<string> _Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _Name = "Listing Activity";
        _Description = "This activity will help you to reflect on the good things in your life by having you list as many things as you can.";
    }

    public void Execute()
    {
        Start();
        Random random = new Random();

        Console.WriteLine(_Prompts[random.Next(_Prompts.Count)]);

        Thread.Sleep(3000);
        Thread.Sleep(3000);

        Console.WriteLine("Start Listing!");
        Console.ReadLine();
       Thread.Sleep(_Duration);
       End();
    }

}