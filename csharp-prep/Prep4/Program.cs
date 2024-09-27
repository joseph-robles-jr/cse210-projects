using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        
        int number_to_add = -9999;
        
        while (number_to_add != 0) // Build the list
        {
            Console.Write("Please enter a number When you are done, enter 0 : ");
            string string_to_add = Console.ReadLine();
            number_to_add = int.Parse(string_to_add);
            if (number_to_add != 0) //exit command is 0
                {
                numbers.Add(number_to_add);
                }
        
        }                  

        // *** VARIABLES FOR LOOP **

        int sum_of_list = 0; // Contains the sum of the list
        int i = 0; // Number of items in the list
        int largest_in_list = -9999;

        // *** END OF VARIABLES FOR LOOP ***
        foreach (int item in numbers) // adds the list items and assigns the sum to sum_of_list
        {
            sum_of_list = sum_of_list + item; 
            
            i++; // counts number of items in list

            if (item > largest_in_list)
            { 
                largest_in_list = item;
            }
        }       
       
        int average_of_list = 0; //average of the  numbers list
        average_of_list = sum_of_list / i;

        Console.WriteLine($"The sum is: {sum_of_list}");
        Console.WriteLine($"The Average is: {average_of_list}");
        Console.WriteLine($"The largest number is: {largest_in_list}");

    
       
       
       
       
        // foreach (int item in numbers) // prints the items in the list
        // {
        //     Console.Write(item);
        // }
    
    }
}