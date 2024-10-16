public class Entry
{
    public List<string> prompts = new List<string> {"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"}; // to hold the prplts lists 0 - 4

    public string formattedDate; // The date of the entry
    public string chosenPrompt; // The prompt that the user chose
    public string userEntry; // The users response to a prompt




    private string GetPrompt()

    {
        Random random = new Random();
        int randomNumber = random.Next(0,5); //pick number between 0 and 5 to be used to grab a random prompt by index 

        Console.WriteLine("Your prompt is:");
        Console.WriteLine(prompts[randomNumber]+" :"); //prints the prompt by index.
        return prompts[randomNumber];
    }

    private string getEntry()
    {
        Console.WriteLine("Please write your response: ");
        string userInput = Console.ReadLine();


        return userInput;
    }

    public void MakeEntry()
    {
        DateTime currentDate = DateTime.Now;
        formattedDate = currentDate.ToString("MM/dd/yyyy");
        chosenPrompt = GetPrompt();
        userEntry = getEntry();
        
    }

    public void PrintEntry()
    {
        Console.WriteLine(formattedDate);
        Console.WriteLine(chosenPrompt);
        Console.WriteLine(userEntry);
        Console.WriteLine();
    }

}