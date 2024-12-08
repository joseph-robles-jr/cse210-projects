using System;

class Program
{
    static void Main()
    {
       Program program = new Program(); 
       program.mainMenu();
        
              
    }

    QSOarray qsoArray = new QSOarray();

    private void qsoMenu()
    {        
    bool exit = false;

    while (!exit)
    {
        Console.WriteLine("\nQSO Menu:");
        Console.WriteLine("1. Create USB QSO");
        Console.WriteLine("2. Create LSB QSO");
        Console.WriteLine("3. Create CW QSO");
        Console.WriteLine("4. Create AM QSO");
        Console.WriteLine("5. Create FM QSO");
        Console.WriteLine("6. Exit");
        Console.Write("Select an option: ");
        
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                qsoArray.newUsbQso();
                break;
            case "2":
                qsoArray.newLsbQso();
                break;
            case "3":
                qsoArray.newCwQso();
                break;
            case "4":
                qsoArray.newAmQso();
                break;
            case "5":
                qsoArray.newFmQso();
                break;
            case "6":
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }   
    }


    public void mainMenu()
    {
    bool exit = false;

    while (!exit)
    {
        Console.WriteLine("\nMain Menu:");
        Console.WriteLine("1. Create New QSO");
        Console.WriteLine("2. Broken ");
        Console.WriteLine("3. Broken");
        Console.WriteLine("4. Broken");
        Console.WriteLine("5. Broken");
        Console.WriteLine("6. Exit");
        Console.Write("Select an option: ");
        
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                qsoMenu();
                break;
            case "2":
                ;
                break;
            case "3":
                ;
                break;
            case "4":
                ;
                break;
            case "5":
                ;
                break;
            case "6":
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }   
    }


    


}