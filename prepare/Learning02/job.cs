using System;
  

class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    public void SetJobTitle(string userJob){
        _jobTitle = userJob;
    }
    public void Setcompany(string company){
        _company = company ;
    }
    public void SetStartYear(int startYear){
        _startYear = startYear;
    }
    public void SetEndYear(int endYear){
        _endYear = endYear;
    }
}