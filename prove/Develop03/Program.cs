using System;
using System.ComponentModel.Design;
using System.Net.Quic;

class Program
{

        
    static void Main()
    {
            Scriptures scripture = new Scriptures();
       string input_selection = "null";
        while (input_selection != "quit")
        {
            Console.WriteLine("Plese make your seletion.");
            Console.WriteLine("1). Store a new Scripture");
            Console.WriteLine("2). Print the Scripture and Refference");
            Console.WriteLine("3). Remove some words.");
            input_selection = Console.ReadLine();
            switch (input_selection)
            {
                case "1": // fill scripture
                    scripture.init();
                    Console.Clear();
                    break;
                case "2": //print the scripture and refference.
                    scripture.display_scripture();
                    break;
                case "quit": // should end the loop wihtout intervention.
                    break;
                case "" or "3":
                    scripture.remove_word();
                    Console.WriteLine("You should remove more words!");
                    break;
                default:
                    break;
            }
        }
        
    }
}    