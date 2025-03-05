using System;
  

class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;


    public Job(string company, string userJob, int startYear, int endYear){
        _company = company;
        _jobTitle = userJob;
        _startYear = startYear;
        _endYear = endYear;
    }
    // public void SetJobTitle(string userJob){
    //     _jobTitle = userJob;
    // }
    // public void Setcompany(string company){
    //     _company = company ;
    // }
    // public void SetStartYear(int startYear){
    //     _startYear = startYear;
    // }
    // public void SetEndYear(int endYear){
    //     _endYear = endYear;
    // }

    public void DisplayJob()
    {
        Console.WriteLine($"Name of company:{_company} Job Title: {_jobTitle} Start Year: {_startYear} End Year: {_endYear}");
    }
}