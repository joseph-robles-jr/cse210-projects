using System.IO; //for writing the file to disk.
public class Journal
{
    // 
    public DateTime date; // To hold the date
    List<Entry> entries = new List<Entry>();

    
    
    

    public void JournalEntry()
    {
        entries.Add(new Entry());
        int length = entries.Count - 1;
        entries[length].MakeEntry();
    }

    public void ListJournals()
    {
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine(); //blank line for indent
            entries[i].PrintEntry();
        }
    }

    public void SaveJournal()// to be used to write to disk
    {
        Console.Write("What do you want the saved file to be named?: ");
        string file = Console.ReadLine();
        string fileName = file+".txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            for (int i = 0; i < entries.Count; i++)
            {
                outputFile.Write(entries[i].formattedDate + ","); // write the date
                outputFile.Write(entries[i].chosenPrompt + ",");
                outputFile.Write(entries[i].userEntry + ",");
                outputFile.WriteLine();
            }
                     
        }
         
    }

    public void ReadJournal()  //Read from disk adnd print
    {
        Console.Write("What file would you like to read?: ");
        string file = Console.ReadLine();
        string fileName = file+".txt";
        string[] lines = System.IO.File.ReadAllLines(fileName); // open a file into a string
        
        entries.Clear(); //Empty the existing journal

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string readPrompt = parts[1];
            string readResponse = parts[2];


            entries.Add(new Entry());
            int length = entries.Count - 1;
            entries[length].formattedDate = date;
            entries[length].chosenPrompt = readPrompt;
            entries[length].userEntry = readResponse;             
        }

        
       

    }


}