using System;

//This Program requires you to use "dotnet build" and "dotnet run"

class Program
{

    static void Main()
    {
        Console.WriteLine("Creating QSO...");

        // Create an instance of the Qso class
        USB USB = new USB();

        // Set the details for the QSO
        USB.newQso();
        

        // List the details of the QSO
        USB.listQso();
    }
}

