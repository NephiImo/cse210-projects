// _company: string
// _jobTitle: string
// _startYear: int
// _endYear: int

// Display(): void 

using System;
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }

    
}