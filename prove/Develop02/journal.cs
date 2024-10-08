using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Journal
{
    DateTime currentDateTime; //to be used to pass to 
    List<string> prompts;
    Random random = new Random();
    int randomPromptNumber = -1; //To be used to pick a prompt between 0 and 6 (7 total)


    //initialize the fields
    public Journal()
    {
        
        currentDateTime = DateTime.Now;

        prompts = new List<string>();
        prompts.Add("What is your favorite color?");
        prompts.Add("What are you grateful for today?");
        prompts.Add("Describe a memorable moment from your childhood.");
        prompts.Add("What are your goals for the next month?");
        prompts.Add("Write about a person who has had a significant impact on your life.");
        prompts.Add("What is something new you learned recently?");
    }

    // Method to display the journal entries
    public void DisplayJournal()
    {
       ;
    }

    public void displayPrompt()
    {
        string promptOK = "n";

        while (promptOK != "Y" && promptOK != "y") // this gives users the prompt selection. Saves prompts index in the global "randomPromptNumber" variable 
        {
            randomPromptNumber = random.Next(0,7);
            Console.WriteLine(prompts[randomPromptNumber]);//selects random prompt. 
            Console.Write("Would you like to do use this prompt? (Y/n): "); // ends loop if set to "Y" or "y".
            promptOK = Console.ReadLine();
        }

    }

}