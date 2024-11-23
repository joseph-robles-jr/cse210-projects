using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{

 static void Main()
 {
     int pointsTotal = 0;

    List<Goal> goals = new List<Goal>(); // collection of the goals.
    List<SimpleGoal> simples = new List<SimpleGoal>();
    List<Checklist> checklists = new List<Checklist>();
    List<Eternal> eternals = new List<Eternal>();
 

    int menuSelection = 0; //used for menu choices


    while (menuSelection != 6)
    {
    
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Plese select your choice :");
        menuSelection = int.Parse(Console.ReadLine());

        switch (menuSelection)
        {
            case 1:
                int goalPick = 0;

                while (goalPick != 1 && goalPick != 2 && goalPick != 3)
                {
                Console.WriteLine("What type of goal would you like to make?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Checklist Goal");
                Console.WriteLine("3. Eternal Goal");
                goalPick = int.Parse(Console.ReadLine());

                if (goalPick == 1)
                    {
                        simples.Add(new SimpleGoal());
                        int listLength = simples.Count-1;
                        simples[listLength].constructGoal(); //get-set;
                    }
                else if (goalPick == 2)
                    {
                        //Checklist goals create function here
                        checklists.Add(new Checklist());
                        int listLength = checklists.Count-1;
                        checklists[listLength].constructGoal(); //get-set;
                        
                    }
                else if (goalPick == 3)
                    {
                        //eternal goal create here.
                        eternals.Add(new Eternal());
                        int listLength = eternals.Count-1;
                        eternals[listLength].constructGoal();
                        
                    }
                else
                {
                    ; // do nothing and end the loop.
                }

                }
                                       

                break;
            case 2:
                Console.WriteLine("You selected option 2: List Goals");

                break;
            case 3:
                Console.WriteLine("You selected option 3: Save Goals");

                break;
            case 4:
                Console.WriteLine("You selected option 4: load Goals");

                break;
            case 5:
                Console.WriteLine("You selected option 5: Record Event");

                break;
            case 6:
                Console.WriteLine("You selected option 6: Quit");

                break;

            default:
                Console.WriteLine("Invalid option selected. Please enter a number between 1 and 6.");
                break;

        }   
    }
    
 }
 



    //To be used to select items in the list

public void simpleCreate() //creates a simple class image.
{

}






}

