using System.Diagnostics.Contracts;

public class Resume
{
    public string _name = "";

    public List <Job> _jobs = new List<Job>();

 public void ShowNameAndJob() 
    {
    Console.WriteLine($"\nName: {_name}");   
    Console.WriteLine("Jobs:");
      
        foreach (var job in _jobs)
        {
            job.ShowJob();
        }
    }
}


