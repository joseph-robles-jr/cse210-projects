using System;

class Program
{
    static void Main(string[] args)
    {
        QSOarray qsoArray = new QSOarray();
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
}
