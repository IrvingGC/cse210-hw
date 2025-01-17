using System;

public class Job
{
    
    public string _jobTitle;
    public string _company;
    public int _pay;
    

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_pay}");
    }
}
