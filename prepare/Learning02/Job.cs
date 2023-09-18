//job class set up
using System;

public class Job
{   
    //variable to store job information
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //print job info
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle}, {_company} {_startYear}-{_endYear}");
    }
}