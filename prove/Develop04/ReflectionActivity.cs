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
        _Name = "Reflection Activity";
        _Description = "This activity will help you to reflect on times in you rlife when you have shown strength.";
    }

    public void Execute()
    {
        Start();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]); // find the lenth of the primpts list, pick a random one in that list and print it.

        for (int i = 0; i< _Duration / 10; i++)
        {
            Console.WriteLine(Questions[random.Next(Questions.Count)]); // Random number between list lenght and 0, prints entry to console.

            Thread.Sleep(5000);
            
        }

        End();
    }
}
