using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome() // The init welcome mesg.
        {
            Console.WriteLine("Welcome to the Program!");
        }    

        string PromptUserName() // Gets username returns string
        {
            Console.Write("Please enter your Username: ");
            string userName = Console.ReadLine();
            return userName;
        }    

        int SquareNumber() // primpts for an int, squares it, then returns it
        {
            int number_to_square = 0;
            Console.Write("What is your favorite number?: ");
            string unparsed_number= Console.ReadLine();
            number_to_square = int.Parse(unparsed_number);

            int Square_complete = number_to_square * number_to_square;
            return Square_complete;
        } 

        void DisplayResult(string username, int squared_number) //
        {
            Console.WriteLine($"{username}, the square of your number is {squared_number}");
        }    


        DisplayWelcome();

        string username = PromptUserName();
        int squared_number = SquareNumber();
        DisplayResult(username, squared_number);


    }
}