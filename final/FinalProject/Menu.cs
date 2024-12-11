public class Menu()
{

        QSOarray qsoArray = new QSOarray(); //innitialize the storage for QSO's

    public void mainMenu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create New QSO");
            Console.WriteLine("2. List all QSS's");
            Console.WriteLine("3. Write to Disk");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
            case 1:
                qsoMenu();
                break;
            case 2:
                Console.WriteLine(qsoArray.returnAllQso());
                Console.WriteLine("Press enter to continue... :");
                Console.ReadLine();
                break;
            case 3:
                Writelog writelog = new Writelog();
                Console.Write("What do you want this file to be called? : ");
                string path = Console.ReadLine();
                writelog.WriteToDisk(qsoArray.returnAllQso(), path);
                break;
            case 6:
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }
        }   
    }
    

    
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
        Console.WriteLine("6. Return to Main Menu");
        Console.Write("Select an option: ");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
        case 1:
            qsoArray.newUsbQso();
            break;
        case 2:
            qsoArray.newLsbQso();
            break;
        case 3:
            qsoArray.newCwQso();
            break;
        case 4:
            qsoArray.newAmQso();
            break;
        case 5:
            qsoArray.newFmQso();
            break;
        case 6:
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
        }
    }   
    }

}