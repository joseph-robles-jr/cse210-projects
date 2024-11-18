using System.Net.Security;
using System;

abstract class Goal //This is the abstract parent class
{

    //attributes
    protected bool _Done = false; //change when goal is complete
    protected string _Name = ""; //Name of the Goal
    protected int _PointValue = 0; // The point count from the goal.
    protected string _Description = "";

    //Methods
        //Get-Set
        protected string SetName()
        {
            // This will set the _Name attribute
            Console.Write("Name your goal! : ");
            _Name = Console.ReadLine();

            return _Name; //use this to set _Name
        }

        protected string SetDescription()
        {
            // Set the description
            Console.Write("Describe your Goal");
            _Description = Console.ReadLine();
            return _Description; 

        }

        protected abstract int SetPoints();
        //{
           // // Set the point value
           // Console.Write("How many points is this Goal worth?");
            //int _PointValue = int.Parse(Console.ReadLine()); //returns an integer
            //return _PointValue;
        //}

        protected bool SetComplete()
        {
            //set to true if completed.
            bool _Done = true;
            return _Done;            
        }


        //FUCNTIONAL SECTION

        public void constructGoal()
        {
            //set all values to begin
            _Name = SetName();
            _Description = SetDescription();
            _PointValue =SetPoints();            
        }

        public int complete()
        {
            //set _Done to done. return appropriate Values.
            _Done = SetComplete();
            return _PointValue; //return point value for Program Tally.
        }

}