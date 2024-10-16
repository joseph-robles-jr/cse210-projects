using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    
        
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        


        int selection = 0;
        while (selection != 5)
        {
            selection = 0;
            Console.WriteLine("Please chose a menu option: 1 - 5  ");
            Console.WriteLine("1. Make a new Journal entry.");
            Console.WriteLine("2. List current Journal Entries.");
            Console.WriteLine("3. Save Journals to a File.");
            Console.WriteLine("4. Open an old Journal File");
            Console.WriteLine("5. Exit");
            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                myJournal.JournalEntry();
            }
            if (selection == 2)
            {
                myJournal.ListJournals();
            }

            if (selection == 3)
            {
                myJournal.SaveJournal();
            }
            if (selection == 4)
            {
                myJournal.ReadJournal();
            }
            else
            {;} // if nothing, do nothing.
        }

    }

}