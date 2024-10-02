using System.Diagnostics.Contracts;

public class Job
{
    public string _company = "";

    public string _jobTitle = "";

    public int _startYear = 0;

    public int _endYear = 0;



 public void ShowJob() 
    {
        string result = "";
        result += $"{_jobTitle}";
        result += $" ({_company})";
        result += $" {_startYear} - {_endYear}";
        Console.WriteLine(result);
    }



}


