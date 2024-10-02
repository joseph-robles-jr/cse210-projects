using System;
using System.Reflection;

class Program  //This is a program for the w2 prepare
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2002;
        job1._endYear = 2020;

        Job job2 = new Job();

        job2._company = "IBM";
        job2._jobTitle = "Mainframe Systems Programmer";
        job2._startYear = 1962;
        job2._endYear = 2024;
     
        Resume listOfJobs = new Resume();
        listOfJobs._name = "Allison";
        listOfJobs._jobs.Add(job1); //only assign the jobtitle values
        listOfJobs._jobs.Add(job2);

        // Display the first job title using dot notation
        //Console.WriteLine($"First job title: {listOfJobs._jobs[0]._jobTitle}");
        
        
        
        //job1.ShowJob(); 
        //job2.ShowJob();
        listOfJobs.ShowNameAndJob();


    }
}